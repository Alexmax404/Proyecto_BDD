namespace Proyecto_bdd2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();               // Oculta el formulario actual (Form1)
            Form2 form2 = new Form2();
            form2.Show();              // Muestra Form2
        }
    }
}
