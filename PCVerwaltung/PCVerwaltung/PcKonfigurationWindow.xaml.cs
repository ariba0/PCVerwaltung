using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PCVerwaltung
{
   
    public partial class PcKonfigurationWindow : Window
    {
        public PcKonfigurationWindow()
        {
            InitializeComponent();
        }
        /*
        string connectionString = @"Data Source=MyServerName;Initial Catalog=MyDbName; User ID=Admin; Password=Root";

        SqlConnection connection = new SqlConnection(connectionString);

        connection.open();
        
        string sql = "Select BookID, BookName, BookCategory from Books";
        SqlCommand cmd = new SqlCommand(sql, connection);
        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
       {

            string rowResult = string.Format("BookId: {0}, Book Name: {1}, Book Category: {2}",
            reader.GetValue(0), reader.GetValue(1), reader.GetValue(2));
            Console.WriteLine(rowResult);

       }
       // Alle Datenbank zugehörigen Objekte schließen
       reader.Close();
       cmd.Dispose();
       connection.Close();
       
        */








        private void CpuComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CpuCoolerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MotherboardComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MemoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void StorageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void VideoCardComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CaseComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PowerSupplyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OperatingSystemComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
