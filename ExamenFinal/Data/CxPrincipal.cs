using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Data
{
    internal class CxPrincipal
    {
        //Conecto la base de datos==============================================================================================
        string connectionString = "server=localhost;database=examenfinal;user=root;password=EggTortuga78";
        MySqlConnection connection;

        //constructor===========================================================================================================
        public CxPrincipal()
        {
            connection = new MySqlConnection(connectionString);
        }

        //Pruebo a ver si conecto===============================================================================================
        public bool probarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        
        //Cargo la base de datos================================================================================================
        public DataTable Cargar()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM fate";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }
            return personajes;
        }
    }
}
