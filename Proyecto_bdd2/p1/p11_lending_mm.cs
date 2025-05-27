using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_bdd2.p1
{
    public partial class p11_lending_mm : Form
    {
            private string usuario;
    private string numCuenta;

    // Modificar el constructor para recibir los parámetros
    public p11_lending_mm(string usuario, string numCuenta)
    {
        InitializeComponent();
        this.usuario = usuario;
        this.numCuenta = numCuenta;
    }


        private void p11_btn_request_Click(object sender, EventArgs e)
        {
            p111_askingForALending form2 = new p111_askingForALending();
            form2.StartPosition = FormStartPosition.Manual;

            // Centrar respecto al formulario actual
            form2.Location = new Point(
                this.Location.X + (this.Width - form2.Width) / 2,
                this.Location.Y + (this.Height - form2.Height) / 2
            );

            form2.Show();
        }

        private void p01_btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            p10_loged_user_mm form2 = new p10_loged_user_mm(usuario, numCuenta);
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Show();
        }
    }
}
