using Proyecto_bdd2.logica;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Proyecto_bdd2.p3
{
    public partial class p34_retire : Form
    {
        private string idTarjeta;
        private string idCuenta;
        private string idCajero;
        private Transaccion trx = new Transaccion();

        public p34_retire(string numeroTarjeta, string idCuentaRecibida, string idCajeroRecibido)
        {
            InitializeComponent();

            idTarjeta = numeroTarjeta;
            idCuenta = idCuentaRecibida;
            idCajero = idCajeroRecibido;

            //p34_btn_retirar.Click += p34_btn_retirar_Click;
        }

        private void p34_btn_retirar_Click(object sender, EventArgs e)
        {
            // 1. Validar monto
            if (!decimal.TryParse(p34_tb_cuantoARetirar.Text.Trim(),
                                  NumberStyles.Number,
                                  CultureInfo.InvariantCulture,
                                  out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido y mayor que 0.",
                                "Dato inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmación
            if (MessageBox.Show($"¿Confirmar retiro de {monto:C}?",
                                "Confirmar",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            // 3. Ejecutar retiro
            try
            {
                trx.HacerRetiroCajero(idTarjeta, idCajero, monto);

                MessageBox.Show("Retiro exitoso.",
                                "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                p34_tb_cuantoARetirar.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al retirar:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
