using Proyecto_bdd2.accesoDatos;
using System;
using System.Data;
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

        public void HacerRetiroCajero(string numeroTarjeta, string idCajero, decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor que cero.");

            string consulta = $@"
BEGIN
    transaccion_pkg.HACER_TRANSACCION_CAJERO(
        '{numeroTarjeta.Replace("'", "''")}',
        '{idCajero.Replace("'", "''")}',
        {monto.ToString(CultureInfo.InvariantCulture)},
        'RETIRAR'
    );
END;";

            misDatos.ejecutarDML(consulta);
        }
        public void HacerTransaccionEntreCuentas(string idCuentaOrigen,
                                                 string idCuentaDestino,
                                                 decimal monto,
                                                 string descripcion)
        {
            string consulta = $@"
BEGIN
    transaccion_pkg.HACER_TRANSACCION_ENTRE_CUENTAS(
        P_ID_CUENTA_ORIGEN  => '{idCuentaOrigen.Replace("'", "''")}',
        P_ID_CUENTA_DESTINO => '{idCuentaDestino.Replace("'", "''")}',
        P_MONTO             => {monto.ToString(CultureInfo.InvariantCulture)},
        P_DESCRIPCION       => '{descripcion.Replace("'", "''")}'
    );
END;";

            Datos misDatos = new Datos();
            misDatos.ejecutarDML(consulta);
        }

        public string ObtenerCuentaPorNombre(string nombre)
        {
            Datos misDatos = new Datos();
            string consulta = $@"
        SELECT C.ID_CUENTA
        FROM CUENTA C
        JOIN CLIENTE CL ON C.ID_CLIENTE = CL.ID_CLIENTE
        WHERE UPPER(CL.NOMBRE) = UPPER('{nombre.Replace("'", "''")}')
          AND ROWNUM = 1";  // Asumimos que quieres la primera cuenta si hay varias

            DataSet ds = misDatos.ejecutarSELECT(consulta);

            if (ds.Tables[0].Rows.Count == 0)
                throw new Exception("No se encontró ninguna cuenta para el nombre ingresado.");

            return ds.Tables[0].Rows[0]["ID_CUENTA"].ToString();
        }
        public string ObtenerNombrePorIdCuenta(string idCuenta)
        {
            string nombreCliente = "";
            string consulta = $@"
        SELECT c.NOMBRE
        FROM CLIENTE c
        JOIN CUENTA cu ON c.ID_CLIENTE = cu.ID_CLIENTE
        WHERE cu.ID_CUENTA = '{idCuenta}'";

            Datos datos = new Datos();
            DataSet resultado = datos.ejecutarSELECT(consulta);

            if (resultado.Tables[0].Rows.Count > 0)
            {
                nombreCliente = resultado.Tables[0].Rows[0]["NOMBRE"].ToString();
            }
            else
            {
                throw new Exception("No se encontró un cliente para la cuenta proporcionada.");
            }

            return nombreCliente;
        }



    }
}
