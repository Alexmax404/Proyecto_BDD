using Proyecto_bdd2.accesoDatos;
using System;
using System.Globalization;

namespace Proyecto_bdd2.logica
{
    public class Transaccion
    {
        private Datos misDatos = new Datos();

        /// <summary>
        /// Ejecuta el procedimiento HACER_TRANSACCION_CAJERO.
        /// tipoTransaccion debe ser "CONSIGNAR" o "RETIRAR".
        /// </summary>
        public void HacerTransaccionCajero(string numeroTarjeta,
                                           string idCajero,
                                           decimal monto,
                                           string tipoTransaccion)
        {
            string consulta = $@"
BEGIN
    cajero_pkg.HACER_TRANSACCION_CAJERO(
        P_NUMERO_TARJETA   => '{numeroTarjeta.Replace("'", "''")}',
        P_ID_CAJERO        => '{idCajero.Replace("'", "''")}',
        P_MONTO            => {monto.ToString(CultureInfo.InvariantCulture)},
        P_TIPO_TRANSACCION => '{tipoTransaccion.ToUpper()}'
    );
END;";

            misDatos.ejecutarDML(consulta);
        }
    }
}
