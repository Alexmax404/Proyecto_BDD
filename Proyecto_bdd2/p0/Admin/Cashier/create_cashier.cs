using Proyecto_bdd2.logica;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Proyecto_bdd2.p0.Admin
{
    public partial class create_cashier : Form
    {
        private Sucursal sucursal = new Sucursal(); // Ya inicializamos aquí

        public create_cashier()
        {
            InitializeComponent();
            this.Load += create_cashier_Load; // Nos aseguramos de cargar los datos al abrir
        }

        private void create_cashier_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = sucursal.ObtenerTodasLasSucursales();

                if (tabla != null && tabla.Rows.Count > 0)
                {
                    cashier_cb_sucursalDeCajero.DisplayMember = "Nombre";
                    cashier_cb_sucursalDeCajero.ValueMember = "ID_Sucursal";
                    cashier_cb_sucursalDeCajero.DataSource = tabla;
                    cashier_cb_sucursalDeCajero.SelectedIndex = 0;

                    cashier_btn_create.Enabled = true;
                }
                else
                {
                    cashier_cb_sucursalDeCajero.Items.Add("No hay sucursales disponibles");
                    cashier_cb_sucursalDeCajero.SelectedIndex = 0;
                    cashier_cb_sucursalDeCajero.Enabled = false;

                    cashier_btn_create.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cashier_btn_create.Enabled = false; // Por seguridad, deshabilita el botón en caso de error
            }
        }



        private void cashier_btn_create_Click(object sender, EventArgs e)
        {
            // Validar los campos de texto
            if (string.IsNullOrWhiteSpace(cashier_tb_monto.Text))
            {
                MessageBox.Show("El monto no puede estar vacío.");
                cashier_tb_monto.Focus();
                return;
            }
            //validar que se seleccione una sucursal
            if (cashier_cb_sucursalDeCajero.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una sucursal.");
                cashier_cb_sucursalDeCajero.Focus();
                return;
            }

            try
            {
                string idSucursal = cashier_cb_sucursalDeCajero.SelectedValue.ToString();
                decimal monto = decimal.Parse(cashier_tb_monto.Text, CultureInfo.InvariantCulture);

                Cajero cajeroDAO = new Cajero();
                cajeroDAO.CrearCajero(idSucursal, monto);

                MessageBox.Show("Cajero creado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el cajero: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            this.Close(); // Cerrar el formulario después de crear el cajero
        }

    }
}