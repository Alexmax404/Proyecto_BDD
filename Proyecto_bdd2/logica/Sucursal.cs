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
    public class Sucursal
    {
        private Datos misDatos = new Datos();

        public int crearSucursal(string nombre, string direccion, string telefono)
        {
            string consulta = "BEGIN sucursal_pkg.crear_sucursal('" +
                              nombre.Replace("'", "''") + "', '" +
                              direccion.Replace("'", "''") + "', '" +
                              telefono.Replace("'", "''") + "'); END;";

            return misDatos.ejecutarDML(consulta);
        }
        public DataTable ObtenerTodasLasSucursales()
        {
            string sql = "SELECT ID_Sucursal, Nombre FROM SUCURSAL ORDER BY Nombre";
            DataSet ds = misDatos.ejecutarSELECT(sql);
            return ds.Tables["ResultadoDatos"];
        }
        public string ObtenerNombreSucursal(string nombreSucursal)
        {
            string consulta = $"SELECT nombre FROM sucursal WHERE nombre = '{nombreSucursal.Replace("'", "''")}'";
            DataTable dt = misDatos.ejecutarSELECT(consulta).Tables["ResultadoDatos"];
            return dt.Rows.Count > 0 ? dt.Rows[0]["nombre"].ToString() : null;
        }

        public string ObtenerDireccionSucursal(string nombreSucursal)
        {
            string consulta = $"SELECT direccion FROM sucursal WHERE nombre = '{nombreSucursal.Replace("'", "''")}'";
            DataTable dt = misDatos.ejecutarSELECT(consulta).Tables["ResultadoDatos"];
            return dt.Rows.Count > 0 ? dt.Rows[0]["direccion"].ToString() : null;
        }

        public string ObtenerTelefonoSucursal(string nombreSucursal)
        {
            string consulta = $"SELECT telefono FROM sucursal WHERE nombre = '{nombreSucursal.Replace("'", "''")}'";
            DataTable dt = misDatos.ejecutarSELECT(consulta).Tables["ResultadoDatos"];
            return dt.Rows.Count > 0 ? dt.Rows[0]["telefono"].ToString() : null;
        }

        public string ObtenerEstadoSucursal(string nombreSucursal)
        {
            string consulta = $"SELECT estado_sucursal FROM sucursal WHERE nombre = '{nombreSucursal.Replace("'", "''")}'";
            DataTable dt = misDatos.ejecutarSELECT(consulta).Tables["ResultadoDatos"];
            return dt.Rows.Count > 0 ? dt.Rows[0]["estado_sucursal"].ToString() : null;
        }

        /// <summary>
        /// Recupera el ID de sucursal dado su nombre.
        /// </summary>
        /// <summary>
        /// Recupera el ID_SUCURSAL (string) dado el nombre de la sucursal.
        /// </summary>
        public string ObtenerIdPorNombre(string nombreSucursal)
        {
            string consulta = $@"
            SELECT ID_Sucursal 
              FROM SUCURSAL 
             WHERE Nombre = '{nombreSucursal.Replace("'", "''")}'";

            DataTable dt = misDatos.ejecutarSELECT(consulta)
                                .Tables["ResultadoDatos"];
            if (dt.Rows.Count == 0)
                throw new Exception("Sucursal no encontrada");

            return dt.Rows[0]["ID_Sucursal"].ToString();
        }

        /// <summary>
        /// Llama al procedimiento PL/SQL sucursal_pkg.actualizar_sucursal
        /// mediante un bloque anónimo, usando ejecutarDML.
        /// </summary>
        public void ActualizarSucursal(
        string nombreOriginal,
        string nuevoNombre,
        string direccion,
        string telefono,
        string estado)
        {
            // 1) Obtener el ID de la sucursal
            string idSucursal = ObtenerIdPorNombre(nombreOriginal);

            // 2) Escapar apóstrofes para evitar errores de sintaxis
            nuevoNombre = nuevoNombre.Replace("'", "''");
            direccion = direccion.Replace("'", "''");
            telefono = telefono.Replace("'", "''");
            estado = estado.Replace("'", "''");

            // 3) Llamar al procedimiento PL/SQL para nombre, dirección y teléfono
            string plsql = $@"
BEGIN
    sucursal_pkg.actualizar_sucursal(
        '{idSucursal}',
        '{nuevoNombre}',
        '{direccion}',
        '{telefono}'
    );
END;";
            misDatos.ejecutarDML(plsql);

            // 4) Actualizar el estado directamente con un UPDATE
            string sqlEstado = $@"
UPDATE SUCURSAL
   SET ESTADO_SUCURSAL = '{estado}'
 WHERE ID_SUCURSAL = '{idSucursal}'";
            misDatos.ejecutarDML(sqlEstado);
        }

        /// <summary>
        /// Elimina la sucursal cuyo ID ya conocemos (p_id_sucursal VARCHAR2).
        /// </summary>
        public void EliminarSucursalPorId(string idSucursal)
        {
            string plsql = $@"
BEGIN
    sucursal_pkg.eliminar_sucursal('{idSucursal}');
END;";
            misDatos.ejecutarDML(plsql);
        }



    }
}
