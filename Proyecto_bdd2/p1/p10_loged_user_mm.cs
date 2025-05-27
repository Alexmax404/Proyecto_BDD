using Proyecto_bdd2.accesoDatos;
using Proyecto_bdd2.logica;
using Proyecto_bdd2.p1;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_bdd2
{
    public partial class p10_loged_user_mm : Form
    {
        private Cliente cliente = new Cliente();
        private string usuario;
        private string numCuenta;

        public p10_loged_user_mm(string usuario, string numCuenta)
        {
            InitializeComponent();
            this.Load += p10_loged_user_mm_Load;
            this.usuario = usuario;
            this.numCuenta = numCuenta;
        }
        private void p10_loged_user_mm_Load(object sender, EventArgs e)
        {
            // 1) Mostrar nombre de usuario
            p10_lb_nombre.Text = usuario;

            // 2) Mostrar número de cuenta
            try
            {
                string cuentaBD = cliente.obtenerIdCuentaDesdeUsuario(usuario);
                p10_lb_num_cuenta.Text = cuentaBD ?? "(no encontrada)";

                Decimal saldo = cliente.obtenerSaldoCuenta(cuentaBD);
                p10_lb_dineroDisp.Text = saldo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void p03_btn_back_Click(object sender, EventArgs e)
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


        private void p10_btn_historial_de_transacciones_Click(object sender, EventArgs e)
        {

        }

        private void p10_btn_sendMoney_Click(object sender, EventArgs e)
        {
            p101_sendMoney form2 = new p101_sendMoney();
            form2.StartPosition = FormStartPosition.Manual;

            // Centrar respecto al formulario actual
            form2.Location = new Point(
                this.Location.X + (this.Width - form2.Width) / 2,
                this.Location.Y + (this.Height - form2.Height) / 2
            );

            form2.Show();
        }
        private void p10_btn_lendings_Click(object sender, EventArgs e)
        {
            this.Hide();
            p11_lending_mm form2 = new p11_lending_mm(usuario,numCuenta);
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();

            form2.Show();
        }
    }
}
