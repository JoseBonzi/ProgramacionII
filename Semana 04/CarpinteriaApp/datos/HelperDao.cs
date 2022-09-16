using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.datos
{
    internal class HelperDao
    {
        private static HelperDao instancia;
        private string CadenaConexion;
        SqlConnection cnn = new SqlConnection();
        private HelperDao()
        {
            CadenaConexion = Properties.Resources.cnnString;
        }  
        
        public static HelperDao ObtenerInstancia(string v)
        {
           if(instancia == null) 
            instancia = new HelperDao();
            return instancia;
        }

        public DataTable ConsultaSQL(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = strSql;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        internal static object ObtenerInstancia()
        {
            throw new NotImplementedException();
        }
    }
}
