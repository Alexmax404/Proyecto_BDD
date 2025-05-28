using Proyecto_bdd2.accesoDatos;
using System.Data;

public class Tarjeta
{
    private Datos misDatos = new Datos();

    public string ObtenerIdCuentaPorTarjeta(string numeroTarjeta)
    {
        try
        {
            // Limpiar el número de tarjeta (eliminar espacios, guiones)
            string numeroLimpio = numeroTarjeta.Trim().Replace(" ", "").Replace("-", "");

            // Consulta segura con parámetros
            string consulta = $"SELECT ID_CUENTA, ESTADO_TARJETA FROM TARJETA WHERE REPLACE(REPLACE(NUMERO_TARJETA, ' ', ''), '-', '') = '{numeroLimpio.Replace("'", "''")}'";

            DataSet ds = misDatos.ejecutarSELECT(consulta);
            DataTable dt = ds.Tables["ResultadoDatos"];

            // Verificar si hay resultados y si la tarjeta está activa
            if (dt.Rows.Count > 0)
            {
                string estado = dt.Rows[0]["ESTADO_TARJETA"].ToString();
                if (estado == "Activa")
                {
                    return dt.Rows[0]["ID_CUENTA"].ToString();
                }
                throw new Exception("La tarjeta no está activa");
            }
            throw new Exception("Tarjeta no encontrada");
        }
        catch (Exception ex)
        {
            throw new Exception("Error al validar tarjeta: " + ex.Message);
        }
    }


}