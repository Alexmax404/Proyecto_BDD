using Proyecto_bdd2.logica;
using System;
using System.Windows.Forms;

namespace Proyecto_bdd2
{
    public partial class p2011_info : Form
    {
        private Cuenta cuenta = new Cuenta();
        private string numeroTarjeta;

        public p2011_info(string numeroTarjeta)
        {
            InitializeComponent();
            this.numeroTarjeta = numeroTarjeta?.Trim();
            this.Load += p2011_info_Load;
        }

        private void p2011_info_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeroTarjeta))
            {
                MessageBox.Show("Número de tarjeta vacío.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            p2011_lbl_noTarjeta.Text = cuenta.ObtenerNumeroTarjeta(numeroTarjeta) ?? "No encontrado";
            p2011_lbl_fechaVencimiento.Text = cuenta.ObtenerFechaVencimiento(numeroTarjeta) ?? "No disponible";
            p2011_lbl_owner.Text = cuenta.ObtenerPropietario(numeroTarjeta) ?? "Desconocido";
            p2011_lbl_cvv.Text = cuenta.ObtenerCVV(numeroTarjeta) ?? "No disponible";
        }
    }
}
