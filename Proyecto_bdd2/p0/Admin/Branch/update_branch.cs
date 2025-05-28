using Proyecto_bdd2.logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_bdd2.p0.Admin.Branch
{
    public partial class update_branch : Form
    {
        private Sucursal sucursal = new Sucursal();

        public update_branch()
        {
            InitializeComponent();

            // Configurar el orden de tabulación
            panelBackground.TabIndex = 0;
            branch_cb_pickABranch.TabIndex = 1;
            branch_tb_update_name.TabIndex = 2;
            branch_tb_update_address.TabIndex = 3;
            branch_tb_update_phone.TabIndex = 4;
            branch_cb_update_state.TabIndex = 5;
            branch_btn_update.TabIndex = 6;
            branch_btn_delete.TabIndex = 7;

            this.Load += update_branch_Load;
            branch_cb_pickABranch.SelectedIndexChanged += branch_cb_pickABranch_SelectedIndexChanged;
        }

        private void update_branch_Load(object sender, EventArgs e)
        {
            try
            {
                // Establecer foco al panel de fondo
                this.ActiveControl = panelBackground;

                // Deshabilitar todos los controles inicialmente
                DeshabilitarTodosLosControles();

                DataTable tabla = sucursal.ObtenerTodasLasSucursales();

                if (tabla != null && tabla.Rows.Count > 0)
                {
                    // Configurar el ComboBox de sucursales
                    branch_cb_pickABranch.DisplayMember = "Nombre";
                    branch_cb_pickABranch.ValueMember = "Nombre";
                    branch_cb_pickABranch.DataSource = tabla;

                    // Cargar datos de la primera sucursal
                    branch_cb_pickABranch.SelectedIndex = 0;
                    CargarDatosSucursal(tabla.Rows[0]["Nombre"].ToString());

                    // Habilitar controles (incluyendo el botón de actualizar)
                    HabilitarControles();
                }
                else
                {
                    branch_cb_pickABranch.Items.Add("No hay sucursales disponibles");
                    branch_cb_pickABranch.SelectedIndex = 0;
                    branch_cb_pickABranch.Enabled = false;

                    // Mantener todos los controles deshabilitados
                    DeshabilitarTodosLosControles();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CargarDatosSucursal(string nombreSucursal)
        {
            if (string.IsNullOrEmpty(nombreSucursal)) return;

            branch_tb_update_name.Text = nombreSucursal;
            branch_tb_update_address.Text = sucursal.ObtenerDireccionSucursal(nombreSucursal);
            branch_tb_update_phone.Text = sucursal.ObtenerTelefonoSucursal(nombreSucursal);

            string estado = sucursal.ObtenerEstadoSucursal(nombreSucursal);
            if (!string.IsNullOrEmpty(estado))
            {
                branch_cb_update_state.SelectedItem = estado;
            }
            else
            {
                branch_cb_update_state.SelectedIndex = -1;
            }

            try
            {
                string idSucursal = sucursal.ObtenerIdPorNombre(nombreSucursal);
                lbl_id.Text = $"ID: {idSucursal}";
            }
            catch (Exception)
            {
                lbl_id.Text = "ID: No encontrado";
            }
        }


        private void branch_cb_pickABranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (branch_cb_pickABranch.SelectedValue == null) return;

            string nombreSucursal = branch_cb_pickABranch.SelectedValue.ToString();
            CargarDatosSucursal(nombreSucursal);

            // Asegurarse que el botón de actualizar permanezca habilitado
            branch_btn_update.Enabled = true;
        }


        private void branch_btn_update_Click(object sender, EventArgs e)
        {
            // 1) Nombre original desde el combo
            string nombreOriginal = branch_cb_pickABranch.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(nombreOriginal))
            {
                MessageBox.Show("Por favor seleccione una sucursal", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Valores nuevos de los TextBox
            string nuevoNombre = branch_tb_update_name.Text.Trim();
            string direccion = branch_tb_update_address.Text.Trim();
            string telefono = branch_tb_update_phone.Text.Trim();

            try
            {
                // 3) Llamada al método
                sucursal.ActualizarSucursal(
                    nombreOriginal,
                    nuevoNombre,
                    direccion,
                    telefono,
                    branch_cb_update_state.SelectedItem?.ToString() ?? "Activo" // Por defecto "Activo"
                );
                MessageBox.Show("Sucursal actualizada correctamente",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5) Recargar combo y volver a seleccionar la misma (ahora con nuevo nombre)
                update_branch_Load(null, EventArgs.Empty);
                branch_cb_pickABranch.SelectedValue = nuevoNombre;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void branch_btn_delete_Click(object sender, EventArgs e)
        {
            string nombreSucursal = branch_cb_pickABranch.SelectedValue?.ToString();
            string idSucursal = sucursal.ObtenerIdPorNombre(nombreSucursal);

            if (string.IsNullOrEmpty(idSucursal))
            {
                MessageBox.Show("Por favor selecciona una sucursal válida.", "Advertencia");
                return;
            }

            if (MessageBox.Show("¿Seguro que quieres eliminar esta sucursal?",
                                "Confirmar",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    sucursal.EliminarSucursalPorId(idSucursal);
                    MessageBox.Show("Sucursal eliminada correctamente.");

                    // Recargar y actualizar interfaz
                    CargarSucursalesEnComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
            this.Hide();
        }


        private void DeshabilitarTodosLosControles()
        {
            // Limpiar campos
            branch_tb_update_name.Text = string.Empty;
            branch_tb_update_address.Text = string.Empty;
            branch_tb_update_phone.Text = string.Empty;
            branch_cb_update_state.SelectedIndex = -1;
            lbl_id.Text = "ID: ";

            // Deshabilitar controles
            branch_cb_pickABranch.Enabled = false;
            branch_tb_update_name.Enabled = false;
            branch_tb_update_address.Enabled = false;
            branch_tb_update_phone.Enabled = false;
            branch_cb_update_state.Enabled = false;
            branch_btn_update.Enabled = false;
            branch_btn_delete.Enabled = false;
        }

        private void CargarSucursalesEnComboBox()
        {
            DataTable tabla = sucursal.ObtenerTodasLasSucursales();

            if (tabla.Rows.Count > 0)
            {
                branch_cb_pickABranch.DisplayMember = "Nombre";
                branch_cb_pickABranch.ValueMember = "ID_Sucursal";
                branch_cb_pickABranch.DataSource = tabla;

                branch_cb_pickABranch.Enabled = true;
                HabilitarControles();

                // Seleccionar la primera sucursal y cargar sus datos
                branch_cb_pickABranch.SelectedIndex = 0;
                CargarDatosSucursal(tabla.Rows[0]["Nombre"].ToString());
            }
            else
            {
                branch_cb_pickABranch.DataSource = null;
                branch_cb_pickABranch.Items.Clear();
                branch_cb_pickABranch.Items.Add("No hay sucursales disponibles");
                branch_cb_pickABranch.SelectedIndex = 0;
                branch_cb_pickABranch.Enabled = false;

                DeshabilitarTodosLosControles();
            }
        }


        private void HabilitarControles()
        {
            branch_cb_pickABranch.Enabled = true;
            branch_tb_update_name.Enabled = true;
            branch_tb_update_address.Enabled = true;
            branch_tb_update_phone.Enabled = true;
            branch_cb_update_state.Enabled = true;
            branch_btn_update.Enabled = true; // Ahora se habilita junto con los demás
            branch_btn_delete.Enabled = true;
        }

    }
}