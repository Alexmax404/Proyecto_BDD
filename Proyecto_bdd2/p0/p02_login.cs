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
    }
}
