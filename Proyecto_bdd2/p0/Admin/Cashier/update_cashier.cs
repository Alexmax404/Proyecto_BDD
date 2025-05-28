using Proyecto_bdd2.logica;
using System;
using System.Data;
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
            branch_cb_updateBranch.SelectedIndexChanged += branch_cb_updateBranch_SelectedIndexChanged;
        }

        private void update_cashier_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable sucursales = sucursal.ObtenerTodasLasSucursales();

                if (sucursales != null && sucursales.Rows.Count > 0)
                {
                    branch_cb_updateBranch.DisplayMember = "Nombre";
                    branch_cb_updateBranch.ValueMember = "ID_Sucursal";
                    branch_cb_updateBranch.DataSource = sucursales;
                }
                else
                {
                    branch_cb_updateBranch.Items.Add("No hay sucursales disponibles");
                    branch_cb_updateBranch.SelectedIndex = 0;
                    branch_cb_updateBranch.Enabled = false;
                    branch_cb_update_selectID.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void branch_cb_updateBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string idSucursal = branch_cb_updateBranch.SelectedValue.ToString();

                DataTable cajeros = cajero.ObtenerCajerosPorSucursal(idSucursal);

                if (cajeros != null && cajeros.Rows.Count > 0)
                {
                    branch_cb_update_selectID.DisplayMember = "ID_CAJERO";
                    branch_cb_update_selectID.ValueMember = "ID_CAJERO";
                    branch_cb_update_selectID.DataSource = cajeros;
                    branch_cb_update_selectID.Enabled = true;
                }
                else
                {
                    branch_cb_update_selectID.DataSource = null;
                    branch_cb_update_selectID.Items.Clear();
                    branch_cb_update_selectID.Items.Add("No hay cajeros");
                    branch_cb_update_selectID.SelectedIndex = 0;
                    branch_cb_update_selectID.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cajeros: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
