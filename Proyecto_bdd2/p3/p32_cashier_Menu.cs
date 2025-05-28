using Proyecto_bdd2.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_bdd2.p3
{
    public partial class p32_cashier_Menu : Form
    {
        private string idTarjeta;
        private string idCuenta;
        private string idCajero; // Nuevo
        private Cuenta cuenta = new Cuenta();

        public p32_cashier_Menu(string idTarjetaRecibida, string idCuentaRecibida, string idCajeroRecibido)
        {
            InitializeComponent();
            idTarjeta = idTarjetaRecibida;
            idCuenta = idCuentaRecibida;
            idCajero = idCajeroRecibido;

            this.Load += p32_cashier_Menu_Load;
        }

        private void p32_cashier_Menu_Load(object sender, EventArgs e)
        {
            try
            {
                string nombreCliente = cuenta.ObtenerNombrePorIdCuenta(idCuenta);

                if (!string.IsNullOrEmpty(nombreCliente))
                {
                    cashier_lbl_saludo.Text = $"Bienvenid@ {nombreCliente},\npor favor, elije una opción a realizar";
                }
                else
                {
                    cashier_lbl_saludo.Text = "Bienvenid@";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el nombre del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void p01_btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            p30_cashier_logger form2 = new p30_cashier_logger
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            form2.Show();
        }

        private void p32_btn_consignar_Click(object sender, EventArgs e)
        {
            p33_consign form2 = new p33_consign(idTarjeta, idCuenta, idCajero);
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Show();
        }

        private void p32_btn_retirar_Click(object sender, EventArgs e)
        {
            p34_retire form2 = new p34_retire(idTarjeta, idCuenta, idCajero);
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Show();
        }

        private void p32_btn_cancelar_Click(object sender, EventArgs e)
        {
            //cancelar y volver
            this.Hide();

            MessageBox.Show("Operación cancelada. Volviendo al menú de cajeros.", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            p31_cashier_verify form2 = new p31_cashier_verify(idCajero);
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Show();
        }
    }

}
