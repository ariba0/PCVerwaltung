using PCVerwaltung.Model;
using System;
using System.Collections.Generic;
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

            if( username.Equals(" "))
            {


                Textbox_fehler_ausgabe.Text = string.Copy("No input");
                Console.WriteLine(Textbox_fehler_ausgabe);



            }




        }
    }
}
