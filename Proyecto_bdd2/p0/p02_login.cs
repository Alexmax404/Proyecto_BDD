using Proyecto_bdd2.logica;
using Proyecto_bdd2.p0.Admin;
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
            usuario = p02_tb_username.Text.Trim();
            numCuenta = p02_tb_numAccount.Text.Trim();

            // Validación especial para Admin
            if (usuario.Equals("Admin", StringComparison.OrdinalIgnoreCase) && numCuenta == "00000")
            {
                MessageBox.Show("Bienvenido administrador.");
                this.Hide();

                admin_mainMenu adminForm = new admin_mainMenu();
                adminForm.StartPosition = FormStartPosition.Manual;
                adminForm.Location = this.Location;
                adminForm.Show();
                return;
            }

            Cliente cliente = new Cliente();
            bool ok = cliente.validarInicioSesion(usuario, numCuenta);
            if (ok)
            {
                MessageBox.Show("¡Bienvenido, " + usuario + "!");
                this.Hide();
                p10_loged_user_mm form2 = new p10_loged_user_mm(usuario, numCuenta);
                form2.StartPosition = FormStartPosition.Manual;
                form2.Location = this.Location;
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

        private void admin_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_mainMenu adminForm = new admin_mainMenu();
            adminForm.StartPosition = FormStartPosition.Manual;
            adminForm.Location = this.Location;
            adminForm.Show();
        }

    }
}
