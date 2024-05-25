using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BD
{
   public class ClsConexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;

        private static ClsConexion Con = null;

        public ClsConexion()
        {
            this.Base = "PRUEBAFINAL";
           // this.Servidor = "DESKTOP-K54DEQR\\SQLEXPRESS";
            this.Servidor = "DESKTOP-63RH14Q\\SQLEXPRESS";
            this.Usuario = "sa";
            this.Clave = "12345678";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor +
                                           "; Database=" + this.Base +
                                           ";User Id=" + this.Usuario +
                                           "; Password=" + this.Clave;
                Cadena.Open();
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static ClsConexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new ClsConexion();

            }
            return Con;
        }

    }
}
