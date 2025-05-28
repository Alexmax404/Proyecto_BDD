using Proyecto_bdd2.p3;

namespace Proyecto_bdd2
{
    public partial class p00_mainMenu : Form
    {
        public p00_mainMenu()
        {
            InitializeComponent();
        }

        private void p0_btn_Acceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            p01_log_reg form2 = new p01_log_reg();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Asegura que todos los formularios ocultos también terminen
        }

        private void p0_lb_Bienvenido_Click(object sender, EventArgs e)
        {

        }

        private void p0_btn_UsarCajero_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            p30_cashier_logger form2 = new p30_cashier_logger();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }
    }
}
