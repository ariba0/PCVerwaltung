using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace PCVerwaltung.Model
{
    static class InitData
    {

        static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pcverwaltung;";
        public static void SaveUser(string _username, string _fullname, string _password, User.Role _role)
        {
            string query = "INSERT INTO user(`username`, `fullname`, `password`, `role`) VALUES ('"+ _username +"', '" + _fullname + "', '" + _password + "', '" + _role.ToString() + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("User succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        public static int LoginUser(string _username, string _password)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string queryString = "SELECT role FROM user WHERE username = '" + _username + "' AND password = '" + _password + "'";
                MySqlCommand command = new MySqlCommand(queryString, connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        switch (reader[0])
                        {
                            case "Sachbearbeitung":
                                return (int)User.Role.Sachbearbeitung;
                            case "Hardwarespezialist":
                                return (int)User.Role.Hardwarespezialist;
                            case "Einkauf":
                                return (int)User.Role.Einkauf;
                            default:
                                return (int)User.Role.NoUser;
                        }
                    } else
                    {
                        return (int) User.Role.NoUser;
                    }
                }
            }


        }

        public static void GenerateUsers()
        { 
            SaveUser("johnbuyman", "John Buyman", "123", User.Role.Einkauf);
            SaveUser("danascully", "Dana Scully", "123", User.Role.Sachbearbeitung);
            SaveUser("foxmulder", "Fox Mulder", "123", User.Role.Hardwarespezialist);
        }
    }
}
