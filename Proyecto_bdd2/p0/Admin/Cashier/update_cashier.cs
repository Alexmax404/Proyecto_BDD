using Proyecto_bdd2.logica;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Proyecto_bdd2.p0.Admin
{
    public partial class update_cashier : Form
    {
        private Sucursal sucursal = new Sucursal();
        private Cajero cajero = new Cajero();

        public update_cashier()
        {
            InitializeComponent();
            this.Load += update_cashier_Load;
            cashier_cb_updateBranch.SelectedIndexChanged += cashier_cb_updateBranch_SelectedIndexChanged;
            cashier_cb_update_selectID.SelectedIndexChanged += cashier_cb_update_selectID_SelectedIndexChanged;
        }

        private void DeshabilitarTodosLosControles()
        {
            cashier_cb_updateBranch.Enabled = false;
            cashier_cb_update_selectID.Enabled = false;
            update_cb_cashier_state.Enabled = false;
            update_lbl_mont_to_add.Enabled = false;
            update_btn_cashier.Enabled = false;
        }

        private void HabilitarControlesBasicos()
        {
            cashier_cb_updateBranch.Enabled = true;
            // Los demás controles se habilitan cuando se selecciona una sucursal con cajeros
        }

        private void update_cashier_Load(object sender, EventArgs e)
        {
            try
            {
                // Configurar ComboBox de estado
                update_cb_cashier_state.Items.AddRange(new string[] { "Activo", "Inactivo" });

                // Inicialmente deshabilitar todos los controles
                DeshabilitarTodosLosControles();

                // Cargar sucursales
                DataTable sucursales = sucursal.ObtenerTodasLasSucursales();

                if (sucursales != null && sucursales.Rows.Count > 0)
                {
                    cashier_cb_updateBranch.DisplayMember = "Nombre";
                    cashier_cb_updateBranch.ValueMember = "ID_Sucursal";
                    cashier_cb_updateBranch.DataSource = sucursales;
                    HabilitarControlesBasicos();
                }
                else
                {
                    cashier_cb_updateBranch.Items.Add("No hay sucursales disponibles");
                    cashier_cb_updateBranch.SelectedIndex = 0;
                    DeshabilitarTodosLosControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el formulario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DeshabilitarTodosLosControles();
            }
        }

        private void cashier_cb_updateBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Deshabilitar controles dependientes inicialmente
                cashier_cb_update_selectID.Enabled = false;
                update_cb_cashier_state.Enabled = false;
                update_lbl_mont_to_add.Enabled = false;
                update_btn_cashier.Enabled = false;

                if (cashier_cb_updateBranch.SelectedValue == null) return;

                string idSucursal = cashier_cb_updateBranch.SelectedValue.ToString();
                DataTable cajeros = cajero.ObtenerCajerosPorSucursal(idSucursal);

                if (cajeros != null && cajeros.Rows.Count > 0)
                {
                    cashier_cb_update_selectID.DisplayMember = "ID_CAJERO";
                    cashier_cb_update_selectID.ValueMember = "ID_CAJERO";
                    cashier_cb_update_selectID.DataSource = cajeros;
                    cashier_cb_update_selectID.Enabled = true;
                }
                else
                {
                    cashier_cb_update_selectID.DataSource = null;
                    cashier_cb_update_selectID.Items.Clear();
                    cashier_cb_update_selectID.Items.Add("No hay cajeros disponibles");
                    cashier_cb_update_selectID.SelectedIndex = 0;
                    cashier_cb_update_selectID.Enabled = false;

                    // Limpiar controles
                    update_cb_cashier_state.SelectedIndex = -1;
                    update_lbl_mont_to_add.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cajeros: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cashier_cb_update_selectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                update_cb_cashier_state.Enabled = false;
                update_lbl_mont_to_add.Enabled = false;
                update_btn_cashier.Enabled = false;

                if (cashier_cb_update_selectID.SelectedValue == null) return;

                string idCajero = cashier_cb_update_selectID.SelectedValue.ToString();

                // Habilitar controles ahora que tenemos un cajero seleccionado
                update_cb_cashier_state.Enabled = true;
                update_lbl_mont_to_add.Enabled = true;
                update_btn_cashier.Enabled = true;

                // Cargar estado actual
                string estado = cajero.ObtenerEstadoCajero(idCajero);
                update_cb_cashier_state.SelectedItem = estado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del cajero: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_btn_cashier_Click(object sender, EventArgs e)
        {
            try
            {
                if (cashier_cb_update_selectID.SelectedValue == null)
                {
                    MessageBox.Show("Por favor seleccione un cajero", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idCajero = cashier_cb_update_selectID.SelectedValue.ToString();

                // Cambiar estado si es diferente
                string estadoActual = cajero.ObtenerEstadoCajero(idCajero);
                if (update_cb_cashier_state.SelectedItem?.ToString() != estadoActual)
                {
                    cajero.CambiarEstadoCajero(idCajero);
                }

                // Agregar monto si se especificó
                if (!string.IsNullOrWhiteSpace(update_lbl_mont_to_add.Text))
                {
                    decimal monto = decimal.Parse(update_lbl_mont_to_add.Text, CultureInfo.InvariantCulture);
                    if (monto > 0)
                    {
                        cajero.AgregarMonto(idCajero, monto);
                    }
                }

                MessageBox.Show("Cajero actualizado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar datos
                cashier_cb_updateBranch_SelectedIndexChanged(null, EventArgs.Empty);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese un monto válido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cajero: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}