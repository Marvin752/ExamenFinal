using ExamenFinal.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //Inserto un nuevo personaje en la base de datos========================================================================
        public void Insertar(Fate usr)
        {
            try
            {
                string query = "INSERT INTO fate(Servant,Class,Lv,Noble_Phantasm,NP_Effect,Gender,Invocation_Date,Description,Active)Values(@Servant, @Class, @Lv, @Noble_Phantams, @NPEffect, @Gender, @InvocationDate, @Description, @Activate)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Servant", usr.Servant);
                cmd.Parameters.AddWithValue("@Class", usr.Classe);
                cmd.Parameters.AddWithValue("@Lv", usr.Lv);
                cmd.Parameters.AddWithValue("@Noble_Phantams", usr.Noble_Phantams);
                cmd.Parameters.AddWithValue("@NPEffect", usr.NPEffect);
                cmd.Parameters.AddWithValue("@Gender", usr.Gender);
                cmd.Parameters.AddWithValue("@InvocationDate", usr.InvocationDate);
                cmd.Parameters.AddWithValue("@Description", usr.Description);
                cmd.Parameters.AddWithValue("@Activate", usr.Activate);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
