using Proyecto_bdd2.accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_bdd2.logica
{
    internal class Cajero
    {
        private Datos misDatos = new Datos();

        public void CrearCajero(string idSucursal, decimal montoDisponible)
        {
            try
            {
                // Llamada directa al procedimiento PL/SQL
                string consulta = $@"BEGIN
                                    cajero_pkg.crear_cajero(
                                        p_id_sucursal => '{idSucursal?.Replace("'", "''")}',
                                        p_monto_disponible => {montoDisponible.ToString(CultureInfo.InvariantCulture)}
                                    );
                                    END;";

                // Ejecución simple sin verificación de filas
                misDatos.ejecutarDML(consulta);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el cajero: " + ex.Message);
            }

        }
        public DataTable ObtenerCajerosPorSucursal(string idSucursal)
        {
            string sql = $@"
        SELECT ID_CAJERO 
          FROM Cajero 
         WHERE ID_Sucursal = '{idSucursal.Replace("'", "''")}' 
         ORDER BY ID_CAJERO";

            return misDatos.ejecutarSELECT(sql).Tables["ResultadoDatos"];
        }
        public string ObtenerEstadoCajero(string idCajero)
        {
            string consulta = $"SELECT ESTADO_CAJERO FROM CAJERO WHERE ID_CAJERO = '{idCajero?.Replace("'", "''")}'";
            DataTable dt = misDatos.ejecutarSELECT(consulta).Tables[0];
            return dt.Rows.Count > 0 ? dt.Rows[0]["ESTADO_CAJERO"].ToString() : null;
        }

        public void CambiarEstadoCajero(string idCajero)
        {
            string consulta = $"BEGIN cajero_pkg.CAMBIAR_ESTADO_CAJERO('{idCajero?.Replace("'", "''")}'); END;";
            misDatos.ejecutarDML(consulta);
        }

        public void AgregarMonto(string idCajero, decimal monto)
        {
            string consulta = $"BEGIN cajero_pkg.AGREGAR_MONTO('{idCajero?.Replace("'", "''")}', {monto.ToString(CultureInfo.InvariantCulture)}); END;";
            misDatos.ejecutarDML(consulta);
        }
        public string ObtenerUltimaRecarga(string idCajero)
        {
            string consulta = $"SELECT Ultima_Recarga FROM Cajero WHERE ID_Cajero = '{idCajero}'";
            DataSet resultado = misDatos.ejecutarSELECT(consulta);

            if (resultado.Tables[0].Rows.Count > 0 && resultado.Tables[0].Rows[0]["Ultima_Recarga"] != DBNull.Value)
            {
                DateTime ultimaRecarga = Convert.ToDateTime(resultado.Tables[0].Rows[0]["Ultima_Recarga"]);
                return ultimaRecarga.ToString("dd/MM/yyyy HH:mm"); // o el formato que desees
            }

            return "Sin recarga";
        }

    }
}
