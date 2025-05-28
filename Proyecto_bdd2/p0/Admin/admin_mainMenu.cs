using Proyecto_bdd2.p0.Admin.Branch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_bdd2.p0.Admin
{
    public partial class admin_mainMenu : Form
    {
        public admin_mainMenu()
        {
            InitializeComponent();
        }

        private void p01_btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Volver al login (sin parámetros, porque es un nuevo intento de login)
            p02_login form2 = new p02_login
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            form2.Show();
        }

        private void admin_btn_cajeros_Click(object sender, EventArgs e)
        {
            
            create_or_update_cashier form2 = new create_or_update_cashier();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }

        private void admin_btn_sucursales_Click(object sender, EventArgs e)
        {
            create_or_update_branch form2 = new create_or_update_branch();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
            
        }
    }
}
