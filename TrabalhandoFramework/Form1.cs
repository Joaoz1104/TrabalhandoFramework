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

            var statuses = contex.Statuses.ToList();

            foreach (Status s in statuses)
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
                        select new { e.Id, e.Nome, e.Data, e.Situacao };
            bi.DataSource = query.ToList();

            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && txtNome.Text != string.Empty)
            {
                var eventos = new Evento()
                {
                    Nome = txtNome.Text,
                    Data = dateTimePicker1.Value,
                    StatusId = (comboBox1.SelectedItem as Status).Id
                };

                contex.Eventos.Add(eventos);

                contex.SaveChanges();

                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um status ou inserir um evento");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var t = contex.Eventos.Find((int)dataGridView1.SelectedCells[0].Value);
            contex.Eventos.Remove(t);
            contex.SaveChanges();
            RefreshGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.Text = "Selecionar...";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar")
            {
                txtNome.Text = dataGridView1.SelectedCells[1].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.SelectedCells[2].Value;

                foreach (Status s in comboBox1.Items)
                {
                    if (s.Nome == dataGridView1.SelectedCells[1].Value.ToString())
                    {
                        comboBox1.SelectedItem = s;
                    } 
                }

                btnEditar.Text = "Salvar";
            }
            else if (btnEditar.Text == "Salvar")
            {
                var editarEventos = contex.Eventos.Find((int)dataGridView1.SelectedCells[0].Value);

                editarEventos.Nome = txtNome.Text;
                editarEventos.Data = dateTimePicker1.Value;
                editarEventos.StatusId = (comboBox1.SelectedItem as Status).Id;

                contex.SaveChanges();
                RefreshGrid();

                btnEditar.Text = "Editar";
                txtNome.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                comboBox1.Text = "Selecionar...";

            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
