using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace Proyecto_bdd2.accesoDatos
{
    public class Datos
    {
        /* paso 1 crear cadena de conexión */
        string cadenaConexion = "Data Source=localhost;User ID=pf_bdd2;Password=oracle";

        /* paso 2: crear el metodo que ejecuta una operación DML 
         * insert, update, delete */
        public int ejecutarDML(String consulta)
        {
            int filasAfectadas = 0;
            // paso 1: creo una conexión

            OracleConnection miConexion = new OracleConnection(cadenaConexion);

            /* paso 2: creo un objeto de tipo comando el cual recibe la instrucción SQL
             * que ejecutará la BD */

            OracleCommand miComando = new OracleCommand(consulta, miConexion);

            /* paso 3: abro la conexión */

            miConexion.Open();

            /* paso 4: ejecuto el comando, Al ejecutar el comando, el devuelve un entero 
             * que simboliza el numero de filas que se afectaron en la operación DML 
             * (insert, update, delete) */

            filasAfectadas = miComando.ExecuteNonQuery();

            /* paso 5: cerrar la conexión */

            miConexion.Close();

            /* paso 6: retornar filas afectadas*/

            return filasAfectadas;
        }
        public DataSet ejecutarSELECT(String consulta)
        {
            /* paso 1: creo un dataset vacio */

            DataSet miDS = new DataSet();

            /* paso 2: creo un adaptador */

            OracleDataAdapter miAdaptador = new OracleDataAdapter(consulta, cadenaConexion);

            /* paso 3: llenar el dataset */

            miAdaptador.Fill(miDS, "ResultadoDatos");
            return miDS;
        }

    }

}
