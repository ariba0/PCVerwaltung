using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PCVerwaltung.Model.HWKomponente;

namespace PCVerwaltung.PurchaseWindows
{
    class PurchaseMgmt
    {
        static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pcverwaltung;";

        public static void CPUtoSQL(string producer, string model, string frequence, string price)
        {

            frequence = frequence.Replace(',','.');
            price = price.Replace(',', '.');

            string query = $"INSERT INTO cpu(`producer`, `model`, `frequence`, `price`) VALUES ('{producer}','{model}','{frequence}','{price}')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("CPU succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        public static void MainboardtoSQL(string producer, string model, object architektur, string price)
        {
            price = price.Replace(',', '.');

            string query = $"INSERT INTO mainboard(`producer`, `model`, `architecture`, `price`) VALUES ('{producer}','{model}','{architektur.ToString()}','{price}')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Mainboard succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
