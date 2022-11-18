using PCVerwaltung.Model.Sachbearbeitung.Windows;
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
using System.Windows.Shapes;

namespace PCVerwaltung
{
    /// <summary>
    /// Interaktionslogik für SachberarbeitungWindow.xaml
    /// </summary>
    public partial class SachberarbeitungWindow : Window
    {

        public SachberarbeitungWindow()
        {
            InitializeComponent();
        }

        private void addKundeButton(object sender, RoutedEventArgs e)
        {
            KundenErstellen menu = new KundenErstellen();
            Grid.SetColumn(menu, 1);
            MainGrid.Children.Add(menu);
        }

        private void addRechnungButton(object sender, RoutedEventArgs e)
        {

        }

        private void addfinanzierungButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
