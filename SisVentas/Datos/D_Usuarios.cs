using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentas.Datos
{
    public class D_Usuarios
    {
        public DataTable Login_us(string cLogin_us, string cPassword_us) 
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_login_us", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cLogin_us", MySqlDbType.VarChar).Value = cLogin_us;
                Comando.Parameters.Add("cPassword_us", MySqlDbType.VarChar).Value = cPassword_us;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (SqlCon.State==ConnectionState.Open) 
                {
                    SqlCon.Close();
                }
            }
        }
    }
}
