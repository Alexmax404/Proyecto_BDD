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
    public partial class p01_log_reg : Form
    {
        public p01_log_reg()
        {
            InitializeComponent();
        }

        private void p01_btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            p02_login form2 = new p02_login();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }

        private void p01_btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            p03_register form2 = new p03_register();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }

        private void p01_btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            p00_mainMenu form2 = new p00_mainMenu();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
