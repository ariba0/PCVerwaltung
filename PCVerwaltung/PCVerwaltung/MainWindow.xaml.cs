using PCVerwaltung.Model;
using PCVerwaltung.Model.Sachbearbeitung;
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

            KundenSQL.UpdateLocal();
            SachberarbeitungWindow windowSB = new SachberarbeitungWindow();
            windowSB.Show();
            this.Close();
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

            string username = txbUsername.Text;
            string password = txbPassword.Text;
            if( string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                txbOutput.Text = string.Copy("No input");
            }
            else if(string.IsNullOrEmpty(username))
            {
                txbOutput.Text = string.Copy("No username input");
            }
            else if(string.IsNullOrEmpty(password))
            {
                txbOutput.Text = string.Copy("No password input");
            }


            int validUser = InitData.LoginUser(username, password);

            // Öffne das jeweilige Menu abhängig von User.Role
            switch (validUser)
            {
                case (int)User.Role.Einkauf:
                    PurchaseWindows.PurchHWKWindow purch1 = new PurchaseWindows.PurchHWKWindow();
                    purch1.Show();
                    this.Close();
                    break;
                case (int) User.Role.Sachbearbeitung:
                    SachberarbeitungWindow windowSB = new SachberarbeitungWindow();
                    windowSB.Show();
                    this.Close();
                    break;
                case (int) User.Role.Hardwarespezialist:
                    PcKonfigurationWindow pckonfig = new PcKonfigurationWindow();
                    pckonfig.Show();
                    this.Close();
                    break;
                case (int) User.Role.NoUser:
                    MessageBox.Show("Benutzerdaten sind nicht gültig.");
                    break;
                default:
                    break;
            }
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}
