using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace apiRESTCheckBd.Models
{
    public class clsCheckBd
    {
        // Definición de atributos
        private string cadConn = ConfigurationManager.ConnectionStrings["bdControl_Acceso"].ConnectionString;
        public string statusMsg;
        public int ban;
        // Definición de métodos (chequeo de conexión a MySql)
        public void checkBd()
        {
            try
            {
                // Prueba de conexión a MySql
                MySqlConnection cnn = new MySqlConnection(cadConn);
                // -----------
                cnn.Open();
                cnn.Close();
                // -----------
                // Conexión exitosa
                // configuración de bandera y mensaje de salida
                ban = 1;
                statusMsg = "Conexion exitosa (MySql) control_acceso";
                // -------------------------
            }
            catch (Exception ex)
            {
                // -----------
                // Conexión exitosa
                // configuración de bandera y mensaje de salida
                ban = 0;
                statusMsg = ex.Message.ToString();
                // -------------------------
            }
        }


    }
}