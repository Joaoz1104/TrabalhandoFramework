using TrabalhandoFramework.ConfigDB;
using TrabalhandoFramework.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoFramework
{
    public partial class Form1 : Form
    {
        private MyEventosDBContext contex;

        public Form1()
        {
            InitializeComponent();
            contex = new MyEventosDBContext();

            var status = contex.Statuses.ToString();

            foreach (Status s in status)
            {
                comboBox1.Items.Add(s);
            }

            RefreshGrid();

        }

        private void RefreshGrid()
        {
            BindingSource bi = new BindingSource();

            var query = from e in contex.Eventos
                        orderby e.Data descending
                        select new { e.Id, e.Nome, e.Data, e.status };
            bi.DataSource = query.ToList();

            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && txtNome.Text != string.Empty)
            {
                var evento = new Evento()
                {
                    Nome = txtNome.Text,
                    Data = dateTimePicker1.Value,
                    StatusId = (comboBox1.SelectedItem as Status).Id
                };

                contex.Eventos.Add(evento);
                contex.SaveChanges();

                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um status ou inserir um evento");
            }
        }
    }
}
