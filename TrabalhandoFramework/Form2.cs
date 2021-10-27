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
    public partial class Form2 : Form
    {
        private MyEventosDBContext contex;

        public Form2()
        {
            InitializeComponent();
            contex = new MyEventosDBContext();

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            BindingSource bi = new BindingSource();


            var query = from e in contex.Eventos
                        orderby e.Id
                        select new { e.Id, e.Situacao };

            bi.DataSource = query.ToList();

            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();
        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {
            var t = contex.Eventos.Find((int)dataGridView1.SelectedCells[1].Value);
            contex.Eventos.Remove(t);
            contex.SaveChanges();
            RefreshGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeStatus.Text != null && txtNomeStatus.Text != string.Empty)
            {
                var eventos = new Evento()
                {
                    Nome = txtNomeStatus.Text
                };


                contex.Eventos.Add(eventos);
                contex.SaveChanges();

                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Você precisa inserir um evento");
            }
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            if (btnEditar2.Text == "Editar")
            {
                txtNomeStatus.Text = dataGridView1.SelectedCells[1].Value.ToString();
                btnEditar2.Text = "Salvar";
            }
            else if (btnEditar2.Text == "Salvar")
            {
                var editarEventos = contex.Eventos.Find((int)dataGridView1.SelectedCells[0].Value);

                editarEventos.Nome = txtNomeStatus.Text;

                contex.SaveChanges();
                RefreshGrid();

                btnEditar2.Text = "Editar";
                txtNomeStatus.Text = "";
            }
        }
    }
}
