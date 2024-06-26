﻿using ExamenFinal.Data.Models;
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
    public class CxPrincipal
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
        public bool Insertar(Fate usr)
        {
            try
            {
                string query = "INSERT INTO fate(Servant,Class,Lv,Noble_Phantasm,NP_Effect,Gender,Invocation_date,Description,Active)Values(@Servant, @Class, @Lv, @Noble_Phantams, @NPEffect, @Gender, @InvocationDate, @Description, @Activate)";
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
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        //Borro un personaje del formulario=====================================================================================
        public bool Eliminar(Fate usr)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM fate WHERE ID = @ID";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", usr.ID);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al borrar el registro: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        //Actualizo un personaje por su ID=======================================================================================
        public bool Actualizar(Fate usr)
        {
            try
            {
                string query = "UPDATE fate SET Servant = @Servant, Class = @Class, Lv = @Lv, Noble_Phantasm = @Noble_Phantasm, NP_Effect = @NPEffect, Gender = @Gender, Invocation_date = @InvocationDate, Description = @Description, Active = @Active WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", usr.ID);
                cmd.Parameters.AddWithValue("@Servant", usr.Servant);
                cmd.Parameters.AddWithValue("@Class", usr.Classe);
                cmd.Parameters.AddWithValue("@Lv", usr.Lv);
                cmd.Parameters.AddWithValue("@Noble_Phantasm", usr.Noble_Phantams);
                cmd.Parameters.AddWithValue("@NPEffect", usr.NPEffect);
                cmd.Parameters.AddWithValue("@Gender", usr.Gender);
                cmd.Parameters.AddWithValue("@InvocationDate", usr.InvocationDate);
                cmd.Parameters.AddWithValue("@Description", usr.Description);
                cmd.Parameters.AddWithValue("@Active", usr.Activate);
                connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        //Parte para avanzar entre los Servants=================================================================================
        public List<Fate> ObtenerTodosLosUsuarios()
        {
            List<Fate> Servants = new List<Fate>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM fate";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Fate servant = new Fate
                        (
                            id: reader.GetInt32("ID"),
                            servant: reader.GetString("Servant"),
                            classe: reader.GetString("Class"),
                            lv: reader.GetByte("Lv"),
                            noblePhantams: reader.GetString("Noble_Phantasm"),
                            npEffect: reader.GetString("NP_Effect"),
                            gender: reader.GetString("Gender"),
                            invocationDate: reader.GetDateTime("Invocation_Date"),
                            description: reader.GetString("Description"),
                            activate: reader.GetBoolean("Active")
                        );

                        Servants.Add(servant);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return Servants;
        }

        //Para filtrar los registros============================================================================================
        public DataTable FiltrarRegistros(Fate usr)
        {
            DataTable Servants = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = "";
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;

                // Caso 1: Solo ID está definido
                if (usr.ID > 0 &&
                    string.IsNullOrEmpty(usr.Servant) &&
                    string.IsNullOrEmpty(usr.Classe) &&
                    usr.Lv <= 0 &&
                    string.IsNullOrEmpty(usr.Noble_Phantams) &&
                    string.IsNullOrEmpty(usr.NPEffect) &&
                    string.IsNullOrEmpty(usr.Gender) &&
                    string.IsNullOrEmpty(usr.Description))
                {
                    sql = "SELECT * FROM fate WHERE ID = @ID";
                    command.Parameters.AddWithValue("@ID", usr.ID);
                }
                // Caso 2: Solo Class está definido
                else if (usr.ID <= 0 &&
                         string.IsNullOrEmpty(usr.Servant) &&
                         !string.IsNullOrEmpty(usr.Classe) &&
                         usr.Lv <= 0 &&
                         string.IsNullOrEmpty(usr.Noble_Phantams) &&
                         string.IsNullOrEmpty(usr.NPEffect) &&
                         string.IsNullOrEmpty(usr.Gender) &&
                         string.IsNullOrEmpty(usr.Description))
                {
                    sql = "SELECT * FROM fate WHERE Class = @Class";
                    command.Parameters.AddWithValue("@Class", usr.Classe);
                }
                // Caso 3: Solo Servant esta definido
                else if (usr.ID <= 0 &&
                         !string.IsNullOrEmpty(usr.Servant) &&
                         string.IsNullOrEmpty(usr.Classe) &&
                         usr.Lv <= 0 &&
                         string.IsNullOrEmpty(usr.Noble_Phantams) &&
                         string.IsNullOrEmpty(usr.NPEffect) &&
                         string.IsNullOrEmpty(usr.Gender) &&
                         string.IsNullOrEmpty(usr.Description))
                {
                    sql = "SELECT * FROM fate WHERE Servant = @Servant";
                    command.Parameters.AddWithValue("@Servant", usr.Servant);
                }
                // Caso 4: Solo Nivel esta definido
                else if (usr.ID <= 0 &&
                         string.IsNullOrEmpty(usr.Servant) &&
                         string.IsNullOrEmpty(usr.Classe) &&
                         usr.Lv > 0 &&
                         string.IsNullOrEmpty(usr.Noble_Phantams) &&
                         string.IsNullOrEmpty(usr.NPEffect) &&
                         string.IsNullOrEmpty(usr.Gender) &&
                         string.IsNullOrEmpty(usr.Description))
                {
                    sql = "SELECT * FROM fate WHERE LV = @Lv";
                    command.Parameters.AddWithValue("@Lv", usr.Lv);
                }
                // Caso 5: Solo Noble_Phantasm esta definido
                else if (usr.ID <= 0 &&
                         string.IsNullOrEmpty(usr.Servant) &&
                         string.IsNullOrEmpty(usr.Classe) &&
                         usr.Lv <= 0 &&
                         !string.IsNullOrEmpty(usr.Noble_Phantams) &&
                         string.IsNullOrEmpty(usr.NPEffect) &&
                         string.IsNullOrEmpty(usr.Gender) &&
                         string.IsNullOrEmpty(usr.Description))
                {
                    sql = "SELECT * FROM fate WHERE Noble_Phantasm = @Noble_Phantasm";
                    command.Parameters.AddWithValue("@Noble_Phantasm", usr.Noble_Phantams);
                }
                // Caso 6: Solo NP_Effect esta definido
                else if (usr.ID <= 0 &&
                         string.IsNullOrEmpty(usr.Servant) &&
                         string.IsNullOrEmpty(usr.Classe) &&
                         usr.Lv <= 0 &&
                         string.IsNullOrEmpty(usr.Noble_Phantams) &&
                         !string.IsNullOrEmpty(usr.NPEffect) &&
                         string.IsNullOrEmpty(usr.Gender) &&
                         string.IsNullOrEmpty(usr.Description))
                {
                    sql = "SELECT * FROM fate WHERE NP_Effect = @NPEffect";
                    command.Parameters.AddWithValue("@NPEffect", usr.NPEffect);
                }
                // Caso 7: Solo Gender esta definido
                else if (usr.ID <= 0 &&
                         string.IsNullOrEmpty(usr.Servant) &&
                         string.IsNullOrEmpty(usr.Classe) &&
                         usr.Lv <= 0 &&
                         string.IsNullOrEmpty(usr.Noble_Phantams) &&
                         string.IsNullOrEmpty(usr.NPEffect) &&
                         !string.IsNullOrEmpty(usr.Gender) &&
                         string.IsNullOrEmpty(usr.Description))
                {
                    sql = "SELECT * FROM fate WHERE Gender = @Gender";
                    command.Parameters.AddWithValue("@Gender", usr.Gender);
                }
                // Caso 8: Solo conozco alguna parte de la historia
                else if (usr.ID <= 0 &&
                         string.IsNullOrEmpty(usr.Servant) &&
                         string.IsNullOrEmpty(usr.Classe) &&
                         usr.Lv <= 0 &&
                         string.IsNullOrEmpty(usr.Noble_Phantams) &&
                         string.IsNullOrEmpty(usr.NPEffect) &&
                         string.IsNullOrEmpty(usr.Gender) &&
                         !string.IsNullOrEmpty(usr.Description))
                {
                    sql = "SELECT * FROM fate WHERE Description Like @Description";
                    command.Parameters.AddWithValue("@Description", "%" + usr.Description + "%");
                }
                try
                {
                    // Ejecutar consulta
                        connection.Open();
                        command.CommandText = sql;
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(Servants);
                        }
                    return Servants;
                }
                catch(Exception)
                {
                    MessageBox.Show("Por favor ingrese un campo a la vez");
                    return Cargar();
                }
            }
        }

        //Buscar por fecha======================================================================================================
        public DataTable FiltrarFecha(DateTime Desde, DateTime Hasta)
        {
            DataTable Servant = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM fate WHERE Invocation_date BETWEEN @Desde and @Hasta";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Desde", Desde);
                    command.Parameters.AddWithValue("@Hasta", Hasta);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(Servant);
                    }
                }
            }
            return Servant;
        }
    }
}
