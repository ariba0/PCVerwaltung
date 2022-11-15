using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PCVerwaltung.Model.Sachbearbeitung
{
    class KundenSQL
    {
        private static List<Kunde> _kunden;
        private static List<Rechnung> _rechnungen;
        private static List<Finanzierung> _finanzierungen;

        static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pcverwaltung;";
        public static void SaveKunden(string _kundenName)
        {
            string query = "INSERT INTO kunden('fullname') VALUES ('" + _kundenName + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Kunde wurde eingepflegt.");

                databaseConnection.Close();

                _kunden = GetKunden();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<Kunde> GetKunden()
        {
            string query = "SELECT * FROM kunden";

            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            MySqlCommand dbCMD = new MySqlCommand(query, dbConnection);
            List<Kunde> kunden = new List<Kunde>();
            using (var reader = dbCMD.ExecuteReader())
            {
                while (reader.Read())
                {
                    kunden.Add(new Kunde((int)reader["fullname"], reader["fullname"].ToString()));
                }
            }
            return kunden;
        }


        public static List<Rechnung> GetRechnungen()
        {
            string query = "SELECT * FROM rechnung";

            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            MySqlCommand dbCMD = new MySqlCommand(query, dbConnection);
            List<Rechnung> rechnungen = new List<Rechnung>();
            using (var reader = dbCMD.ExecuteReader())
            {
                while (reader.Read())
                {
                    rechnungen.Add(new Rechnung((double)reader["price"], (string) reader["product"], (int)reader["kundenid"]));
                }
            }
            return rechnungen;
        }

        public static List<Finanzierung> GetFinanzierungen()
        {
            string query = "SELECT * FROM finanzierung";

            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            MySqlCommand dbCMD = new MySqlCommand(query, dbConnection);
            List<Finanzierung> finanzierungen = new List<Finanzierung>();
            using (var reader = dbCMD.ExecuteReader())
            {
                while (reader.Read())
                {
                    finanzierungen.Add(new Finanzierung((int) reader["runtime"], (double) reader["rates"], (double) reader["finalcost"], (int) reader["kundenid"] ));
                }
            }
            return finanzierungen;
        }


        public static void SaveFinanzierung(int runtime, double rate, double finalcost, int kundenid)
        {
            string query = "INSERT INTO finanzierung( 'runtime', 'rate', 'finalcost', 'kundenid')" +
                "VALUES('" + runtime +"','" + rate +"','" + finalcost +"','" + kundenid +"')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Finanzierung wurde eingepflegt.");

                databaseConnection.Close();
                _finanzierungen = GetFinanzierungen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SaveRechnung(double price, string product, int kundenid)
        {
            string query = "INSERT INTO rechnung('price', 'product', 'kundenid')" +
                "VALUES('" + price +"','" + product +"', '" + kundenid +"')";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Rechnung wurde eingepflegt.");

                databaseConnection.Close();
                _rechnungen = GetRechnungen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
