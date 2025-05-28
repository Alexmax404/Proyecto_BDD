using Proyecto_bdd2.accesoDatos;
using System;
using System.Collections.Generic;
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
    }
}
