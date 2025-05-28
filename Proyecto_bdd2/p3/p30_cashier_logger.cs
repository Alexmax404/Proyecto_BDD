using Proyecto_bdd2.logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_bdd2.p3
{
    public partial class p30_cashier_logger : Form
    {
        private Sucursal sucursal = new Sucursal();
        private Cajero cajero = new Cajero();

        public p30_cashier_logger()
        {
            InitializeComponent();
            this.Load += p30_cashier_logger_Load;
            p30_cb_cashierBranch_chooser.SelectedIndexChanged += p30_cb_cashierBranch_chooser_SelectedIndexChanged;
        }

        private void p30_cashier_logger_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable sucursales = sucursal.ObtenerTodasLasSucursales();

                if (sucursales != null && sucursales.Rows.Count > 0)
                {
                    p30_cb_cashierBranch_chooser.DisplayMember = "Nombre";
                    p30_cb_cashierBranch_chooser.ValueMember = "ID_Sucursal";
                    p30_cb_cashierBranch_chooser.DataSource = sucursales;
                }
                else
                {
                    p30_cb_cashierBranch_chooser.Items.Add("No hay sucursales disponibles");
                    p30_cb_cashierBranch_chooser.SelectedIndex = 0;
                    p30_cb_cashierBranch_chooser.Enabled = false;
                    p30_cb_cashierChosser.Enabled = false;
                    p30_btn_send.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void p30_cb_cashierBranch_chooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (p30_cb_cashierBranch_chooser.SelectedValue == null) return;

                string idSucursal = p30_cb_cashierBranch_chooser.SelectedValue.ToString();
                DataTable cajeros = cajero.ObtenerCajerosPorSucursal(idSucursal);

                if (cajeros != null && cajeros.Rows.Count > 0)
                {
                    p30_cb_cashierChosser.DisplayMember = "ID_CAJERO";
                    p30_cb_cashierChosser.ValueMember = "ID_CAJERO";
                    p30_cb_cashierChosser.DataSource = cajeros;
                    p30_cb_cashierChosser.Enabled = true;
                    p30_btn_send.Enabled = true;
                }
                else
                {
                    p30_cb_cashierChosser.DataSource = null;
                    p30_cb_cashierChosser.Items.Clear();
                    p30_cb_cashierChosser.Items.Add("No hay cajeros disponibles");
                    p30_cb_cashierChosser.SelectedIndex = 0;
                    p30_cb_cashierChosser.Enabled = false;
                    p30_btn_send.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cajeros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void p30_btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                if (p30_cb_cashierChosser.SelectedValue == null || p30_cb_cashierBranch_chooser.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una sucursal y un cajero válidos", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idCajeroSeleccionado = p30_cb_cashierChosser.SelectedValue.ToString();
                string idSucursalSeleccionada = p30_cb_cashierBranch_chooser.SelectedValue.ToString();

                // Verificar estado del cajero
                string estadoCajero = cajero.ObtenerEstadoCajero(idCajeroSeleccionado);
                if (estadoCajero == "Inactivo")
                {
                    MessageBox.Show("Este cajero está inactivo y no puede ser utilizado.", "Acceso denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar estado de la sucursal
                string estadoSucursal = sucursal.ObtenerEstadoSucursal(idSucursalSeleccionada);
                if (estadoSucursal == "Cerrado")
                {
                    MessageBox.Show("La sucursal seleccionada está cerrada. No se puede usar el cajero.", "Acceso denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si todo está bien, abrir siguiente formulario
                p31_cashier_verify formVerificacion = new p31_cashier_verify(idCajeroSeleccionado);
                formVerificacion.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al continuar con el cajero: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void p01_btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            p00_mainMenu form2 = new p00_mainMenu();
            form2.StartPosition = FormStartPosition.Manual;  // Para poder fijar la ubicación
            form2.Location = this.Location;                 // Copia la ubicación de Form1
            form2.Show();
        }
    }
}
