using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_bdd2.p1
{
    public partial class p11_lending_mm : Form
    {
        private string usuario;
        private string numCuenta;

        // Constructor modificado para recibir el usuario y la cuenta
        public p11_lending_mm(string usuario, string numCuenta)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.numCuenta = numCuenta;

            // Asociar el evento Load con el método que carga el mensaje
            this.Load += p11_lending_mm_Load;
        }

        // Evento Load del formulario
        private void p11_lending_mm_Load(object sender, EventArgs e)
        {
            CargarMensajePrestamo();
        }

        // Llama a la clase Prestamo para obtener el mensaje y mostrarlo en el label
        private void CargarMensajePrestamo()
        {
            try
            {
                string estado = Prestamo.ObtenerEstadoPrestamo(numCuenta);
                p11_lbl_message.Text = estado;

                if (estado.Contains("no tiene deudas", StringComparison.OrdinalIgnoreCase))
                {
                    // Puede pedir préstamo
                    p11_btn_request.Enabled = true;
                    p11_btn_pay.Enabled = false;
                }
                else
                {
                    // Tiene deuda → solo puede pagar
                    p11_btn_request.Enabled = false;
                    p11_btn_pay.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el estado del préstamo: " + ex.Message);
                p11_btn_request.Enabled = false;
                p11_btn_pay.Enabled = false;
            }
        }




        // Botón para solicitar un préstamo
        private void p11_btn_request_Click(object sender, EventArgs e)
        {
            var form2 = new p111_askingForALending(numCuenta);
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(
                this.Location.X + (this.Width - form2.Width) / 2,
                this.Location.Y + (this.Height - form2.Height) / 2
            );

            // Cuando el formulario de solicitud se cierre, recarga estado
            form2.FormClosed += (s, args) => CargarMensajePrestamo();

            form2.Show();
        }

        // Botón para volver atrás
        private void p01_btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            p10_loged_user_mm form2 = new p10_loged_user_mm(usuario, numCuenta);
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Show();
        }

        private void p11_btn_pay_Click(object sender, EventArgs e)
        {
            var form2 = new p112_paying_a_lending(numCuenta);
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(
                this.Location.X + (this.Width - form2.Width) / 2,
                this.Location.Y + (this.Height - form2.Height) / 2
            );

            // Suscripción al cierre para refrescar estado
            form2.FormClosed += (s, args) => CargarMensajePrestamo();

            form2.Show();
        }
    }
}
