using Proyecto_bdd2.accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public DataRow ObtenerDetallesTarjeta(string idTarjeta)
        {
            string consulta = $@"
                SELECT 
                    t.NUMERO_TARJETA,
                    TO_CHAR(t.FECHA_VENCIMIENTO, 'MM/YYYY') AS FECHA_VENCIMIENTO,
                    c.NOMBRE || ' ' || c.APELLIDO AS PROPIETARIO,
                    t.CVV
                FROM TARJETA t
                JOIN CUENTA cu ON t.ID_CUENTA = cu.ID_CUENTA
                JOIN CLIENTE c ON cu.ID_CLIENTE = c.ID_CLIENTE
                WHERE t.ID_TARJETA = '{idTarjeta}'";

            DataSet ds = misDatos.ejecutarSELECT(consulta);
            if (ds.Tables["ResultadoDatos"].Rows.Count > 0)
            {
                return ds.Tables["ResultadoDatos"].Rows[0];
            }
            else
            {
                return null;
            }
        }
        public string ObtenerIdTarjetaPorCuenta(string idCuenta)
        {
            string consulta = $@"
        SELECT ID_TARJETA
        FROM TARJETA
        WHERE ID_CUENTA = '{idCuenta}'
        ORDER BY FECHA_EMISION DESC";  // Asumiendo que quieres la más reciente

            DataSet ds = misDatos.ejecutarSELECT(consulta);

            if (ds.Tables["ResultadoDatos"].Rows.Count > 0)
            {
                return ds.Tables["ResultadoDatos"].Rows[0]["ID_TARJETA"].ToString();
            }

            return null;
        }
        public string ObtenerNumeroTarjeta(string numeroTarjeta)
        {
            string sql = $"SELECT NUMERO_TARJETA FROM TARJETA WHERE NUMERO_TARJETA = '{numeroTarjeta}'";
            DataSet ds = misDatos.ejecutarSELECT(sql); // Cambio aquí
            return ds.Tables["ResultadoDatos"].Rows.Count > 0 ? ds.Tables["ResultadoDatos"].Rows[0][0].ToString() : null;
        }

        public string ObtenerFechaVencimiento(string numeroTarjeta)
        {
            string sql = $"SELECT TO_CHAR(FECHA_VENCIMIENTO, 'MM/YYYY') FROM TARJETA WHERE NUMERO_TARJETA = '{numeroTarjeta}'";
            DataSet ds = misDatos.ejecutarSELECT(sql); // Cambio aquí
            return ds.Tables["ResultadoDatos"].Rows.Count > 0 ? ds.Tables["ResultadoDatos"].Rows[0][0].ToString() : null;
        }

        public string ObtenerCVV(string numeroTarjeta)
        {
            string sql = $"SELECT CVV FROM TARJETA WHERE NUMERO_TARJETA = '{numeroTarjeta}'";
            DataSet ds = misDatos.ejecutarSELECT(sql); // Cambio aquí
            return ds.Tables["ResultadoDatos"].Rows.Count > 0 ? ds.Tables["ResultadoDatos"].Rows[0][0].ToString() : null;
        }

        public string ObtenerPropietario(string numeroTarjeta)
        {
            string sql = @"
        SELECT C.NOMBRE AS PROPIETARIO
        FROM TARJETA T
        JOIN CUENTA CU ON T.ID_CUENTA = CU.ID_CUENTA
        JOIN CLIENTE C ON CU.ID_CLIENTE = C.ID_CLIENTE
        WHERE T.NUMERO_TARJETA = '" + numeroTarjeta + "'";

            DataSet ds = misDatos.ejecutarSELECT(sql);
            return ds.Tables["ResultadoDatos"].Rows.Count > 0 ? ds.Tables["ResultadoDatos"].Rows[0][0].ToString() : null;
        }
        public string ObtenerNombrePorIdCuenta(string idCuenta)
        {
            string consulta = $@"
        SELECT C.NOMBRE
        FROM CUENTA CU
        JOIN CLIENTE C ON CU.ID_CLIENTE = C.ID_CLIENTE
        WHERE CU.ID_CUENTA = '{idCuenta.Replace("'", "''")}'";

            DataSet ds = misDatos.ejecutarSELECT(consulta);

            if (ds.Tables["ResultadoDatos"].Rows.Count > 0)
            {
                return ds.Tables["ResultadoDatos"].Rows[0]["NOMBRE"].ToString();
            }

            return null;
        }
        public static decimal ObtenerSaldoCuenta(string idCuenta)
        {
            Datos datos = new Datos();
            string consulta = $@"
            SELECT SALDO 
            FROM CUENTA 
            WHERE ID_CUENTA = '{idCuenta}'";

            DataSet ds = datos.ejecutarSELECT(consulta);
            if (ds.Tables["ResultadoDatos"].Rows.Count > 0)
            {
                return Convert.ToDecimal(ds.Tables["ResultadoDatos"].Rows[0]["SALDO"]);
            }

            // Si no existe la cuenta, devolvemos 0 o podrías lanzar excepción
            return 0m;
        }




    }
}
