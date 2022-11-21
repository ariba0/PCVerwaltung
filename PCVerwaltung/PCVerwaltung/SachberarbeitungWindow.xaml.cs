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
        UserControl currentControl;

        public SachberarbeitungWindow()
        {
            InitializeComponent();
        }

        private void addKundeButton(object sender, RoutedEventArgs e)
        {
            if (currentControl != null)
                MainGrid.Children.Remove(currentControl);

            currentControl = new KundenErstellen();
            Grid.SetColumn(currentControl, 1);
            MainGrid.Children.Add(currentControl);
        }

        private void addRechnungButton(object sender, RoutedEventArgs e)
        {

        }

        private void addfinanzierungButton(object sender, RoutedEventArgs e)
        {

        }

        private void getKundenBtn(object sender, RoutedEventArgs e)
        {
            if (currentControl != null)
                MainGrid.Children.Remove(currentControl);

            currentControl = new KundenListe();
            Grid.SetColumn(currentControl, 1);
            MainGrid.Children.Add(currentControl);
        }
    }
}
