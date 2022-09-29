using PCVerwaltung.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PCVerwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User> Users;
        public MainWindow()
        {
            InitializeComponent();
            //InitData.GenerateUsers();










        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
      





        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        { 

            string username = Textbox_username.Text;
            string password = Textbox_password.Text;
            if( string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                Textbox_fehler_ausgabe.Text = string.Copy("No input");
                Console.WriteLine(Textbox_fehler_ausgabe.Text);
            }
            else if(string.IsNullOrEmpty(username))
            {
                Textbox_fehler_ausgabe.Text = string.Copy("No username input");
                Console.WriteLine(Textbox_fehler_ausgabe.Text);
            }
            else if(string.IsNullOrEmpty(password))
            {
                Textbox_fehler_ausgabe.Text = string.Copy("No password input");
                Console.WriteLine(Textbox_fehler_ausgabe.Text);
            }


            string connectionString = @"Date Source=pcverwaltung;Initial Catalog=root@localhost; User ID =Admin; Password=Root";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            connection.Close();
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}
