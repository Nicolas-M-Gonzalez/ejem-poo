using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace registro_personas
{
    public partial class registro1 : Form
    {
        public registro1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1aceptar_Click(object sender, EventArgs e)
        {
            string apellido = txtapellido.Text;
            listresult.Items.Add(" apellido: " + apellido);
            string nombre = txtnombre.Text;
            listresult.Items.Add(" nombre: " +  nombre);
            string edad = txtedad.Text;
            listresult.Items.Add("edad: " +  edad);
            string direccion = txtdireccion.Text;
            listresult.Items.Add(" direccion: " +  direccion);

            if (txtapellido.Text == "")
                txtapellido.BackColor = Color.Red;
            if (txtnombre.Text == "")
                txtnombre.BackColor = Color.Red;

            if (txtedad.Text == "")
                txtedad.BackColor = Color.Red;
            if (txtdireccion.Text == "")
                txtdireccion.BackColor = Color.Red;


           

        }  

                private void txtapellido_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listresult_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void listresult_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void btn2cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
