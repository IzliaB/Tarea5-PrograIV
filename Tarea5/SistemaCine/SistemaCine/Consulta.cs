using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEUTEC;

namespace SistemaCine
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }
        public bool Conectar()
        {
            if (auxiliar.conn.Conectar(".",
                                        "Cine",
                                        "sa",
                                        "princesa23"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error al conectar: " +
                                auxiliar.conn.SQLError());
                return false;
            }
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            if (Conectar())
            {
                CargarLista();
            }
        }
     
        private void CargarLista()
        {
            string query = "";
            DataTable dt = null;

            query = @"SELECT 
                      p.id_pelicula,
                      p.nombre_pelicula as pelicula
                      FROM
                      peliculas p   
                     ";

            if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
            {
                dgvconsulta.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar datos: " + auxiliar.conn.SQLError());
            }

        }

        private void dgvconsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Ticket tickets = new Ticket();
            Consulta consulta = new Consulta();

            DataGridViewRow llenar = dgvconsulta.Rows[e.RowIndex];

            tickets.txtidpelicula.Text = llenar.Cells["n_id_ticket"].Value.ToString();
            tickets.Show();
            
        }
        private void buscar()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

       
        }
    }
}
