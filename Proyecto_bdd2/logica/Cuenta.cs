using Proyecto_bdd2.accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_bdd2.logica
{
    public class Cuenta
    {
        Datos misDatos = new Datos();
        public int contarTarjetasPorCuenta(string idCuenta)
        {
            string consulta = $"SELECT COUNT(*) FROM TARJETA WHERE ID_Cuenta = '{idCuenta}'";
            DataSet ds = misDatos.ejecutarSELECT(consulta);

            if (ds.Tables["ResultadoDatos"].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables["ResultadoDatos"].Rows[0][0]);
            }
            return 0;
        }
        public int CrearTarjeta(string idCuenta, string tipoTarjeta)
        {
            // Convertir tipo a mayúsculas y escapar comillas
            string tipoSeguro = tipoTarjeta.ToUpper().Replace("'", "''");
            string cuentaSegura = idCuenta.Replace("'", "''");

            string consulta = "BEGIN tarjeta_pkg.crear_tarjeta('" +
                              cuentaSegura + "', '" +
                              tipoSeguro + "'); END;";

            return misDatos.ejecutarDML(consulta);
        }
        public DataTable ObtenerTarjetasPorCuenta(string idCuenta)
        {
            string consulta = $"SELECT ID_TARJETA, NUMERO_TARJETA FROM TARJETA WHERE ID_CUENTA = '{idCuenta}'";
            DataSet ds = misDatos.ejecutarSELECT(consulta);

            if (ds != null && ds.Tables["ResultadoDatos"].Rows.Count > 0)
            {
                return ds.Tables["ResultadoDatos"];
            }

            return null;
        }
        public int eliminarTarjeta(string idTarjeta)
        {
            string consulta = "BEGIN tarjeta_pkg.eliminar_tarjeta('" + idTarjeta.Replace("'", "''") + "'); END;";
            return misDatos.ejecutarDML(consulta);
        }



    }
}
