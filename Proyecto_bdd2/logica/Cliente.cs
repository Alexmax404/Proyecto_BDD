using Proyecto_bdd2.accesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_bdd2.logica
{
    public class Cliente
    {
        Datos misDatos = new Datos();

        public int ingresarCliente(string nombre, string correo, string telefono)
        {
        // Generar un bloque PL/SQL válido directamente en la cadena
        string consulta = "BEGIN cliente_pkg.crear_cliente('" + 
                      nombre.Replace("'", "''") + "', '" + 
                      correo.Replace("'", "''") + "', '" + 
                      telefono.Replace("'", "''") + "'); " +
                      "END;";

        return misDatos.ejecutarDML(consulta);
        }
        public bool validarInicioSesion(string usuario, string numCuenta)
        {
            // Construimos la consulta con JOIN
            string consulta = $@"
            SELECT 1
            FROM CUENTA cue
            JOIN CLIENTE cli
            ON cue.ID_CLIENTE = cli.ID_CLIENTE
            WHERE cli.NOMBRE       = '{usuario}'
            AND cue.ID_CUENTA      = '{numCuenta}'
            AND cli.ESTADO_CLIENTE = 'Activo'
            AND cue.ESTADO_CUENTA  = 'Activa'
            ";

            // Ejecutamos el SELECT
            DataSet ds = misDatos.ejecutarSELECT(consulta);

            // Si hay al menos una fila, el login es válido
            return (ds.Tables["ResultadoDatos"].Rows.Count > 0);
        }
        public string obtenerIdCuentaDesdeUsuario(string nombreUsuario)
        {
            string consulta = $@"
        SELECT cue.ID_CUENTA
        FROM CUENTA cue
        JOIN CLIENTE cli ON cue.ID_CLIENTE = cli.ID_CLIENTE
        WHERE cli.NOMBRE = '{nombreUsuario}'
          AND cli.ESTADO_CLIENTE = 'Activo'
          AND cue.ESTADO_CUENTA = 'Activa'
        ";

            DataSet ds = misDatos.ejecutarSELECT(consulta);

            if (ds.Tables["ResultadoDatos"].Rows.Count > 0)
            {
                return ds.Tables["ResultadoDatos"].Rows[0]["ID_CUENTA"].ToString();
            }

            return null; // No se encontró
        }
    }
}
