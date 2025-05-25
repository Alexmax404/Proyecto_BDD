using Proyecto_bdd2.accesoDatos;
using Proyecto_bdd2.logica;
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
    }
}
