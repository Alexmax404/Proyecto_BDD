using Proyecto_bdd2.logica;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Proyecto_bdd2.p3
{
    public partial class p33_consign : Form
    {
        private  string idTarjeta;   // número de tarjeta (P_NUMERO_TARJETA)
        private  string idCuenta;    // no se usa aquí, pero lo conservamos
        private  string idCajero;    // cajero que hizo login
        private Transaccion trx = new Transaccion();

        public p33_consign(string numeroTarjeta, string idCuentaRecibida, string idCajeroRecibido)
        {
            InitializeComponent();
            idTarjeta = numeroTarjeta;
            idCuenta = idCuentaRecibida;
            idCajero = idCajeroRecibido;

            p33_btn_enviar.Click += p33_btn_enviar_Click;
        }

        private void p33_btn_enviar_Click(object sender, EventArgs e)
        {
            // 1. Obtener y validar monto
            if (!decimal.TryParse(p33_tb_cuantoAConsignar.Text.Trim(),
                                  NumberStyles.Number,
                                  CultureInfo.InvariantCulture,
                                  out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido y mayor que 0.",
                                "Dato inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmar
            if (MessageBox.Show($"¿Confirmar consignación de {monto:C}?",
                                "Confirmar",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                // 3. Ejecutar la transacción (CONSIGNAR)
                trx.HacerTransaccionCajero(idTarjeta, idCajero, monto, "CONSIGNAR");

                MessageBox.Show("Consignación exitosa.",
                                "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                p33_tb_cuantoAConsignar.Clear();
                this.Close();   // o lo que prefieras hacer al terminar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consignar:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
