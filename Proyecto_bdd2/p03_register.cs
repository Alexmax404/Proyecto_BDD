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
    public partial class p03_register : Form
    {
        public p03_register()
        {
            InitializeComponent();

            this.Shown += p03_register_Shown;
        }


        private void p03_register_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = p03_pn_register;
        }

        private void p03_btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            p02_login form2 = new p02_login();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }
    }
}
