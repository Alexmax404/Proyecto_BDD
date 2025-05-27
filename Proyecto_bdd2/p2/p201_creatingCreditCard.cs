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

namespace Proyecto_bdd2
{
    public partial class p201_creatingCreditCard : Form
    {
        private Cuenta cuenta = new Cuenta();
        private string usuario;
        private string numCuenta;
        public p201_creatingCreditCard(string usuario, string numCuenta)
        {
            this.usuario = usuario;
            this.numCuenta = numCuenta;
            InitializeComponent();

            // Estilo: solo permite selección (sin escribir manualmente)
            p201_cb_CardType.DropDownStyle = ComboBoxStyle.DropDownList;

            // Agregar opciones
            p201_cb_CardType.Items.Add("Seleccione tipo de tarjeta");
            p201_cb_CardType.Items.Add("Credito");
            p201_cb_CardType.Items.Add("Debito");

            // Mostrar el mensaje inicial sin seleccionar una opción válida
            p201_cb_CardType.SelectedIndex = 0;

            // Deshabilitar el botón al inicio
            p201_btn_addCreditCard.Enabled = false;

            // Suscribirse al evento
            p201_cb_CardType.SelectedIndexChanged += p201_cb_CardType_SelectedIndexChanged;
        }

        private void p201_cb_CardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita el botón solo si se selecciona una opción válida
            p201_btn_addCreditCard.Enabled = (p201_cb_CardType.SelectedIndex != 0);
        }

        private void P201_btn_addCreditCard_Click(object sender, EventArgs e)
        {
               cuenta.CrearTarjeta(numCuenta, p201_cb_CardType.SelectedItem.ToString());
            MessageBox.Show("Tarjeta creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Cerrar el formulario después de crear la tarjeta
            this.Close();

        }
    }
}
