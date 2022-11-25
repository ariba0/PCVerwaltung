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

        public static void CPUtoSQL(string producer, string model, string frequence, string price,string anzKerne,string kühlleistung)
        {

            frequence = frequence.Replace(',','.');
            price = price.Replace(',', '.');

            string query = $"INSERT INTO cpu(`producer`, `model`, `frequence`, `price`,`cores`,`cooling efficiency`) VALUES ('{producer}','{model}','{frequence}','{price}','{anzKerne}','{kühlleistung}')";

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

        public static void MainboardtoSQL(string producer, string model, int architectureIndex, string price)
        {
            price = price.Replace(',', '.');
            Architektur architecture = (Architektur)architectureIndex;

            string query = $"INSERT INTO mainboard(`producer`, `model`, `architecture`, `price`) VALUES ('{producer}','{model}','{architecture}','{price}')";

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

        public static void SSDtoSQL(string producer, string model, string storage, string price)
        {

            storage = storage.Replace(',', '.');
            price = price.Replace(',', '.');

            string query = $"INSERT INTO ssd(`producer`, `model`, `storage (GB)`, `price`) VALUES ('{producer}','{model}','{storage}','{price}')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("SSD succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        public static void MonitortoSQL(string producer, string model, string resolution, string price)
        {

            price = price.Replace(',', '.');

            string query = $"INSERT INTO monitor(`producer`, `model`, `resolution`, `price`) VALUES ('{producer}','{model}','{resolution}','{price}')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Monitor succesfully registered");

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
