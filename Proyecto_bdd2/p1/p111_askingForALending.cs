
using System;
using System.Windows.Forms;

namespace Proyecto_bdd2.p1
{
    public partial class p111_askingForALending : Form
    {
        private string idCuenta;
        private Prestamo Prestamo = new Prestamo();
        public p111_askingForALending(string idCuenta)
        {
            InitializeComponent();
            this.idCuenta = idCuenta;
        }

        private void p111_btn_request_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar el monto ingresado
                if (!decimal.TryParse(p111_tb_moneyToLend.Text, out decimal monto) || monto <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido.", "Monto inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal interes = 0.1m; // 10% de interés fijo

                // Llamar a la lógica para crear el préstamo
                Prestamo.CrearPrestamo(idCuenta, monto, interes);

                MessageBox.Show("✅ Préstamo solicitado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Cerrar el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al solicitar el préstamo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
