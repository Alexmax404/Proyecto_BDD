namespace Proyecto_bdd2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void p0_btn_Acceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicaci�n
            form2.Location = this.Location;                 // Copia la ubicaci�n de Form1
            form2.Show();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Asegura que todos los formularios ocultos tambi�n terminen
        }

        private void p0_lb_Bienvenido_Click(object sender, EventArgs e)
        {

        }
    }
}
