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
    public partial class create_or_update_cashier : Form
    {
        public create_or_update_cashier()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            this.Hide();
            create_cashier form2 = new create_cashier();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_cashier form2 = new update_cashier();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }
    }
}
