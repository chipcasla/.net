using System.Data.SqlClient;

namespace Foresi.Datos
{
    public class Base
    {
        public SqlConnection Conexion { get; private set; }
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Windows\\Downloads\\Net.DB.Usuario.mdf;Integrated Security=True;Connect Timeout=30";

        public Base()
        {
            Conexion = new SqlConnection(connectionString);
        }

        public void openConnection()
        {
            try
            {
                if(Conexion.State != System.Data.ConnectionState.Open)
                {
                    Conexion.Open();
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }            
        }

        public void closeConnection()
        {
            if (Conexion.State != System.Data.ConnectionState.Closed)
            {
                Conexion.Close();
            }
        }
    }
}