using Proyecto_bdd2.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_bdd2
{
    public partial class p02_login : Form
    {
        public String usuario;
        public String numCuenta;

        //set y gets
        public String getUsuario()
        {
            return usuario;
        }
        public String getNumCuenta()
        {
            return numCuenta;
        }
        public p02_login()
        {
            InitializeComponent();
        }

        private void p01_btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            p01_log_reg form2 = new p01_log_reg();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }

        private void p02_btn_login_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            usuario = p02_tb_username.Text.Trim();
            numCuenta = p02_tb_numAccount.Text.Trim();

            bool ok = cliente.validarInicioSesion(usuario, numCuenta);
            if (ok)
            {
                MessageBox.Show("¡Bienvenido, " + usuario + "!");
                this.Hide();
                p10_loged_user_mm form2 = new p10_loged_user_mm(usuario, numCuenta);

                form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
                form2.Location = this.Location;                 // Copia la ubicación de Form1
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o número de cuenta incorrectos.");
            }
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            p10_loged_user_mm form2 = new p10_loged_user_mm("Glenn", "CUE0001");

            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }
    }
}
