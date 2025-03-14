
using System.Configuration;
using System.Data.SqlClient;

namespace PROYECTO_FINAL
{
    
        public class Conexion
        {
            private SqlConnection cn;

            public SqlConnection AbrirConexion()
            {
                cn = new SqlConnection("server=LAPTOP-L3M57PGQ\\SQLEXPRESS; database=ReservasDB; integrated security=true");
                cn.Open();
                return cn;
            }

            public void CerrarConexion()
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }
        }
    

}
