using Proyecto_bdd2.accesoDatos;
using System;
using System.Globalization;

namespace Proyecto_bdd2.logica
{
    public class Transaccion
    {
        private Datos misDatos = new Datos();

        /// <summary>
        /// Ejecuta una consignación mediante el procedimiento TRANSACCION_PKG.HACER_TRANSACCION_CAJERO.
        /// </summary>
        public void HacerTransaccionCajero(string numeroTarjeta, string idCajero, decimal monto, string tipoTransaccion)
        {
            if (tipoTransaccion.ToUpper() != "CONSIGNAR")
                throw new ArgumentException("Este método solo permite el tipo de transacción 'CONSIGNAR'.");

            string consulta = $@"
BEGIN
    transaccion_pkg.HACER_TRANSACCION_CAJERO(
        '{numeroTarjeta.Replace("'", "''")}',
        '{idCajero.Replace("'", "''")}',
        {monto.ToString(CultureInfo.InvariantCulture)},
        'CONSIGNAR'
    );
END;";

            misDatos.ejecutarDML(consulta);
        }
    }
}
