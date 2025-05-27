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

namespace Proyecto_bdd2.p2
{
    public partial class p20_creditCards_MainMenu : Form
    {
        private Cuenta cuenta = new Cuenta();
        private string usuario;
        private string numCuenta;
        public p20_creditCards_MainMenu(string usuario, string numCuenta)
        {
            InitializeComponent();
            this.Load += p20_creditCards_MainMenu_Load;
            this.usuario = usuario;
            this.numCuenta = numCuenta;
        }
        private void p20_creditCards_MainMenu_Load(object sender, EventArgs e)
        {
            int cantidadTarjetas = cuenta.contarTarjetasPorCuenta(numCuenta);

            // Si no tiene tarjetas → inhabilitar botón de eliminar
            if (cantidadTarjetas == 0)
            {
                p20_btn_removeCreditCard.Enabled = false;
            }

            // Si ya tiene 3 o más tarjetas → inhabilitar botón de añadir
            if (cantidadTarjetas >= 3)
            {
                p20_btn_addCreditCard.Enabled = false;
            }

            // Mostrar tarjetas en el ComboBox
            DataTable tarjetas = cuenta.ObtenerTarjetasPorCuenta(numCuenta);
            if (tarjetas != null)
            {
                p20_cb_creditCard.DisplayMember = "NUMERO_TARJETA"; // Lo que se ve
                p20_cb_creditCard.ValueMember = "ID_TARJETA";       // El valor interno
                p20_cb_creditCard.DataSource = tarjetas;
            }
            else
            {
                p20_cb_creditCard.Items.Add("No hay tarjetas registradas");
                p20_cb_creditCard.SelectedIndex = 0;
                p20_cb_creditCard.Enabled = false;
            }
        }

        private void p20_cb_creditCard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void p20_btn_addCreditCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            p201_creatingCreditCard form2 = new p201_creatingCreditCard(usuario,numCuenta);
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }

        private void p20_btn_removeCreditCard_Click(object sender, EventArgs e)
        {
            // 1. Validar selección
            if (p20_cb_creditCard.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una tarjeta para eliminar.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmar
            if (MessageBox.Show("¿Seguro que desea eliminar esta tarjeta?", "Confirmación",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                // 3. Eliminar en la BD
                string idTarjeta = p20_cb_creditCard.SelectedValue.ToString();
                int filas = cuenta.eliminarTarjeta(idTarjeta);

                if (filas <= 0)
                {
                    MessageBox.Show("La tarjeta ya no existe.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tarjeta eliminada correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Refrescar ComboBox DE FORMA SEGURA
            p20_cb_creditCard.DataSource = null;          // 👉 quitar el binding primero
            p20_cb_creditCard.Items.Clear();              // ahora sí se puede limpiar

            DataTable tarjetas = cuenta.ObtenerTarjetasPorCuenta(numCuenta);
            if (tarjetas != null && tarjetas.Rows.Count > 0)
            {
                p20_cb_creditCard.DisplayMember = "NUMERO_TARJETA";
                p20_cb_creditCard.ValueMember = "ID_TARJETA";
                p20_cb_creditCard.DataSource = tarjetas;
                p20_cb_creditCard.Enabled = true;
            }
            else
            {
                p20_cb_creditCard.Items.Add("No hay tarjetas registradas");
                p20_cb_creditCard.SelectedIndex = 0;
                p20_cb_creditCard.Enabled = false;
            }

            // 5. Actualizar botones
            int cantidadTarjetas = cuenta.contarTarjetasPorCuenta(numCuenta);
            p20_btn_removeCreditCard.Enabled = (cantidadTarjetas > 0);
            p20_btn_addCreditCard.Enabled = (cantidadTarjetas < 3);
        }

    }
}
