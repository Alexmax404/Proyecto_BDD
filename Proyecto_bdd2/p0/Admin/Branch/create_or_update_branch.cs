using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_bdd2.p0.Admin.Branch
{
    public partial class create_or_update_branch : Form
    {
        public create_or_update_branch()
        {
            InitializeComponent();
        }

        private void btn_create_branch_Click(object sender, EventArgs e)
        {
            this.Hide();
            create_branch form2 = new create_branch();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }

        private void btn_update_branch_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_branch form2 = new update_branch();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }
    }
}
