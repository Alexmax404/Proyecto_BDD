using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_bdd2.logica;
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
            p01_log_reg form2 = new p01_log_reg();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }
        private void validateTextBox(TextBox textBox, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(errorMessage);
                textBox.Focus();
                return;
            }
        }
        private int validarCampos()
        {
            // Validar los campos de texto
            if (string.IsNullOrWhiteSpace(p03_tb_name.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                p03_tb_name.Focus();
                return 0;
            }
            else if (string.IsNullOrWhiteSpace(p03_tb_email.Text))
            {
                MessageBox.Show("El correo no puede estar vacío.");
                p03_tb_email.Focus();
                return 0;
            }
            else if (string.IsNullOrWhiteSpace(p03_tb_phone.Text))
            {
                MessageBox.Show("El teléfono no puede estar vacío.");
                p03_tb_phone.Focus();
                return 0;
            }
            return 1;
        }
        private void p03_btn_register_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            // Validar el formato del correo electrónico
            if (!System.Text.RegularExpressions.Regex.IsMatch(p03_tb_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                p03_tb_email.Focus();
                return;
            }

            // Validar los campos de texto
            if (validarCampos() == 0)
            {
                return;
            }
            cliente.ingresarCliente(p03_tb_name.Text, p03_tb_email.Text, p03_tb_phone.Text);

            MessageBox.Show("Cliente registrado correctamente");
            // Limpiar los campos de texto
            p03_tb_name.Clear();
            p03_tb_email.Clear();
            p03_tb_phone.Clear();

            // Volver al formulario de inicio de sesión
            this.Hide();
            p01_log_reg form2 = new p01_log_reg();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }
    }
}
