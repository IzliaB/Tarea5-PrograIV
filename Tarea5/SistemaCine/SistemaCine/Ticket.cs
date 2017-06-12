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
    public partial class Ticket : Form
    {
        public int p_id_ticket = 0;
        public Ticket()
        {

            InitializeComponent();
        }
        public void Contar()
        {
            string query = @"SELECT TOP 1 
                             (id_ticket) as Contador 
                             FROM tickets";

            query = string.Format(query,
                                   Convert.ToInt16(txtid_ticket.Text));

            DataRow dr = null;

            if (auxiliar.conn.SQLSelectDataRow(query, ref dr))
            {
                
                if (dr[0].ToString() == "Contador")
                {
                    txtid_ticket.Text = dr[0].ToString();
                }
            }
            else
            {
                MessageBox.Show(auxiliar.conn.SQLError());
            }
            
        }
        public void Guardar()
        {
            string query = @"INSERT INTO tickets ( id_pelicula, fecha_funcion, precio_pelicula)
                                    VALUES ({0},'{1}',{2})";

            query = string.Format(query,  
                                  txtidpelicula.Text,
                                  dtpfecha.Value.ToString("dd/MM/yyyy"),
                                  Convert.ToDouble(txtprecio.Text));

            if (auxiliar.conn.SqlExec(query))
            {
                MessageBox.Show("Ticket Almacenado en con exito con codigo");
                this.Close();
            }else
            {
                MessageBox.Show(auxiliar.conn.SQLError());
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            if (c.Conectar())
            {
                Guardar();
            }
            

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.Show();
            Hide();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
           
        }

        private void txtid_ticket_TextChanged(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            if (c.Conectar())
            {
                Contar();
            }
        }
    }
}
