using Proyecto_bdd2.logica;
using System;
using System.Windows.Forms;

namespace Proyecto_bdd2.p0.Admin.Branch
{
    public partial class create_branch : Form
    {
        Sucursal sucursal = new Sucursal();
        public create_branch()
        {
            InitializeComponent();
        }

        private void branch_btn_create_Click(object sender, EventArgs e)
        {
            // Validar los campos de texto
            if (string.IsNullOrWhiteSpace(branch_tb_name.Text))
            {
                MessageBox.Show("El nombre de la sucursal no puede estar vacío.");
                branch_tb_name.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(branch_tb_address.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.");
                branch_tb_address.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(branch_tb_phone.Text))
            {
                MessageBox.Show("El teléfono no puede estar vacío.");
                branch_tb_phone.Focus();
                return;
            }

            // Crear la sucursal
            sucursal.crearSucursal(branch_tb_name.Text, branch_tb_address.Text, branch_tb_phone.Text);
            MessageBox.Show("Sucursal creada exitosamente.");

            // Limpiar los campos
            branch_tb_name.Clear();
            branch_tb_address.Clear();
            branch_tb_phone.Clear();
            
            this.Hide();

        }
    }
}
