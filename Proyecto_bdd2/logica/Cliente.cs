using Proyecto_bdd2.accesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_bdd2.logica
{
    public class Cliente
    {
        Datos misDatos = new Datos();

        public int ingresarCliente(string nombre, string correo, string telefono)
        {

            string consulta = "execute cliente_pkg.crear_cliente('" + nombre + "','" + correo + "','" + telefono + "')";
            return misDatos.ejecutarDML(consulta);
        }
    }
}
