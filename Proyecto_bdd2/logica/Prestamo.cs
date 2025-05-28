using System;
using System.Data;
using Proyecto_bdd2.accesoDatos;

public class Prestamo
{
    public static string ObtenerEstadoPrestamo(string idCuenta)
    {
        Datos datos = new Datos();
        string consulta = $@"
            SELECT MONTO, SALDO_PENDIENTE 
            FROM PRESTAMO 
            WHERE ID_CUENTA = '{idCuenta}' 
              AND ESTADO_PRESTAMO = 'Activo'";

        DataSet resultado = datos.ejecutarSELECT(consulta);

        if (resultado.Tables["ResultadoDatos"].Rows.Count > 0)
        {
            var fila = resultado.Tables["ResultadoDatos"].Rows[0];
            decimal monto = Convert.ToDecimal(fila["MONTO"]);
            decimal saldo = Convert.ToDecimal(fila["SALDO_PENDIENTE"]);

            return $"Préstamo pendiente\nPréstamo total: ${monto:F2}\nSaldo pendiente: ${saldo:F2}";
        }
        else
        {
            return "No tiene deudas registradas para usted\npuede pedir un préstamo.";
        }
    }

    public static void CrearPrestamo(string idCuenta, decimal monto, decimal interes)
    {
        Datos datos = new Datos();

        string consulta = $@"
            BEGIN
                prestamo_pkg.crear_prestamo('{idCuenta}', {monto}, {interes});
            END;";

        datos.ejecutarDML(consulta);
    }
    public static string ObtenerIdPrestamoActivo(string idCuenta)
    {
        Datos conexion = new Datos();
        string query = $"SELECT ID_Prestamo FROM PRESTAMO WHERE ID_Cuenta = '{idCuenta}' AND Estado_Prestamo = 'Activo'";
        DataSet ds = conexion.ejecutarSELECT(query);

        if (ds.Tables["ResultadoDatos"].Rows.Count > 0)
        {
            return ds.Tables["ResultadoDatos"].Rows[0]["ID_Prestamo"].ToString();
        }

        return null;
    }

    public static bool AbonarAPrestamo(string idCuenta, decimal monto)
    {
        string idPrestamo = ObtenerIdPrestamoActivo(idCuenta);
        if (idPrestamo == null) return false;

        Datos conexion = new Datos();
        string query = $"BEGIN prestamo_pkg.REGISTRAR_PAGO_A_PRESTAMO('{idPrestamo}', {monto.ToString(System.Globalization.CultureInfo.InvariantCulture)}); END;";
        try
        {
            conexion.ejecutarDML(query);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool PagarTodoPrestamo(string idCuenta)
    {
        Datos conexion = new Datos();
        string idPrestamo = ObtenerIdPrestamoActivo(idCuenta);
        if (idPrestamo == null) return false;

        string querySaldo = $"SELECT Saldo_Pendiente FROM PRESTAMO WHERE ID_Prestamo = '{idPrestamo}'";
        DataSet ds = conexion.ejecutarSELECT(querySaldo);
        if (ds.Tables["ResultadoDatos"].Rows.Count == 0) return false;

        decimal saldo = Convert.ToDecimal(ds.Tables["ResultadoDatos"].Rows[0]["Saldo_Pendiente"]);

        return AbonarAPrestamo(idCuenta, saldo);
    }
    public static decimal ObtenerSaldoPendiente(string idCuenta)
{
    Datos datos = new Datos();
    string consulta = $@"
        SELECT SALDO_PENDIENTE 
        FROM PRESTAMO 
        WHERE ID_CUENTA = '{idCuenta}' 
          AND ESTADO_PRESTAMO = 'Activo'";

    DataSet ds = datos.ejecutarSELECT(consulta);
    if (ds.Tables["ResultadoDatos"].Rows.Count > 0)
    {
        return Convert.ToDecimal(ds.Tables["ResultadoDatos"].Rows[0]["SALDO_PENDIENTE"]);
    }

    return 0m; // Si no hay préstamo activo, el saldo pendiente es 0
}

}
