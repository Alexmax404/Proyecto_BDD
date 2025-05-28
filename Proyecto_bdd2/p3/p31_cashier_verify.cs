using System;
using System.Windows.Forms;

namespace Proyecto_bdd2.p3
{
    public partial class p31_cashier_verify : Form
    {
        private string idCajero;

        public p31_cashier_verify(string idCajeroRecibido)
        {
            InitializeComponent();
            idCajero = idCajeroRecibido;
            this.Load += p31_cashier_verify_Load;
        }

        private void p31_cashier_verify_Load(object sender, EventArgs e)
        {
            // Aquí puedes usar idCajero para cargar datos o verificar algo
            MessageBox.Show("Cajero recibido: " + idCajero, "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ejemplo: cargar información del cajero
            // Cajero cajero = new Cajero();
            // DataRow datos = cajero.ObtenerDatos(idCajero);
            p31_lbl_chasierNum.TextAlign = ContentAlignment.MiddleCenter;
            p31_lbl_chasierNum.Text = "Cajero ID: " + idCajero;



        }

        private void p01_btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            p00_mainMenu form2 = new p00_mainMenu();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void p31_btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                string idTarjeta = p03_tb_name.Text.Trim();

                if (string.IsNullOrWhiteSpace(idTarjeta))
                {
                    MessageBox.Show("Debe ingresar una tarjeta válida.", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    p03_tb_name.Focus();
                    return;
                }

                Tarjeta tarjetaService = new Tarjeta();
                string idCuenta = tarjetaService.ObtenerIdCuentaPorTarjeta(idTarjeta);

                // Abrir menú de cajero
                this.Hide();
                var menuForm = new p32_cashier_Menu(idTarjeta, idCuenta, idCajero)  // <- Aquí estaba el error
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.Location
                };
                menuForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en tarjeta",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                p03_tb_name.SelectAll();
                p03_tb_name.Focus();
            }
        }

    }
}
