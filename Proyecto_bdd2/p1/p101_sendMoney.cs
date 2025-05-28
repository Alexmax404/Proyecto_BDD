using Microsoft.VisualBasic.ApplicationServices;
using Proyecto_bdd2.logica;
using Proyecto_bdd2.p1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_bdd2
{
    public partial class p101_sendMoney : Form
    {
        private string idCuentaOrigen;
        private Transaccion trx = new Transaccion();

        public p101_sendMoney(string idCuentaOrigenRecibida)
        {
            InitializeComponent();
            idCuentaOrigen = idCuentaOrigenRecibida;
            //p101_btn_send.Click += p101_btn_send_Click;
        }

        private void p101_btn_send_Click(object sender, EventArgs e)
        {
            string idCuentaDestino = p101_tb_whoSend.Text.Trim();
            if (string.IsNullOrWhiteSpace(idCuentaDestino))
            {
                MessageBox.Show("Ingrese el número de cuenta destino.",
                                "Falta información",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(p101_tb_howMany.Text.Trim(),
                                  NumberStyles.Number,
                                  CultureInfo.InvariantCulture,
                                  out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido y mayor que 0.",
                                "Dato inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"¿Confirmar transferencia de {monto:C} a la cuenta {idCuentaDestino} a nombre de: {trx.ObtenerNombrePorIdCuenta(idCuentaDestino)}?",
                                "Confirmar",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                trx.HacerTransaccionEntreCuentas(idCuentaOrigen, idCuentaDestino, monto, "Transferencia desde app");
                MessageBox.Show("Transferencia realizada con éxito.",
                                "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                p101_tb_whoSend.Clear();
                p101_tb_howMany.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la transferencia:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
