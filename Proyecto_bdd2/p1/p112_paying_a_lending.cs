
using Proyecto_bdd2.logica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_bdd2.p1
{
    public partial class p112_paying_a_lending : Form
    {
        private string numCuenta;

        public p112_paying_a_lending(string numCuenta)
        {
            InitializeComponent();
            this.numCuenta = numCuenta;
        }

        private void p112_btn_pay_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(p112_tb_moneyTopay.Text, out decimal monto) && monto > 0)
            {
                decimal saldoCuenta = Cuenta.ObtenerSaldoCuenta(numCuenta);
                decimal saldoPendiente = Prestamo.ObtenerSaldoPendiente(numCuenta);

                if (saldoPendiente == 0m)
                {
                    MessageBox.Show("No hay préstamo pendiente por pagar.");
                    this.Close();
                    return;
                }

                if (monto > saldoCuenta)
                {
                    MessageBox.Show(
                        $"Fondos insuficientes.\n" +
                        $"Saldo disponible: ${saldoCuenta:F2}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // Si el monto ingresado es mayor al saldo pendiente, se ajusta
                if (monto > saldoPendiente)
                {
                    monto = saldoPendiente;
                    MessageBox.Show(
                        $"El monto ingresado supera el saldo pendiente.\n" +
                        $"Solo se abonarán ${monto:F2}.", "Monto ajustado", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }

                bool exito = Prestamo.AbonarAPrestamo(numCuenta, monto);

                if (exito)
                {
                    MessageBox.Show("Abono registrado correctamente.");
                    this.Close(); // Cierra el formulario
                }
                else
                {
                    MessageBox.Show("Error al registrar el abono.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido.");
            }
        }




        private void p111_btn_payAll_Click(object sender, EventArgs e)
        {
            decimal saldoDisponible = Cuenta.ObtenerSaldoCuenta(numCuenta);
            decimal saldoPendiente = Prestamo.ObtenerSaldoPendiente(numCuenta);

            if (saldoPendiente == 0m)
            {
                MessageBox.Show("No hay préstamo activo o ya está pagado.");
                return;
            }

            if (saldoPendiente > saldoDisponible)
            {
                MessageBox.Show(
                    $"Fondos insuficientes para pagar el préstamo.\n" +
                    $"Saldo pendiente: ${saldoPendiente:F2}\n" +
                    $"Saldo disponible: ${saldoDisponible:F2}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            bool exito = Prestamo.PagarTodoPrestamo(numCuenta);
            if (exito)
            {
                MessageBox.Show("Préstamo pagado en su totalidad.");
                this.Close();  // <- Cierra este formulario y vuelve al anterior
            }
            else
            {
                MessageBox.Show("Error al pagar el préstamo.");
            }
        }


    }
}
