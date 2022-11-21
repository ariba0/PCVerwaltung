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

namespace PCVerwaltung.Model.Sachbearbeitung.Windows
{
    /// <summary>
    /// Interaktionslogik für KundenInfo.xaml
    /// </summary>
    public partial class KundenInfo : UserControl
    {
        public KundenInfo()
        {
            InitializeComponent();
        }

        private void btnViewRechnungen(object sender, RoutedEventArgs e)
        {
            // Get rechnungen von user
            string kunde = kundenInfoFullname.Content.ToString();
            MessageBox.Show(kunde);
        }

        private void btnKundenOptions(object sender, RoutedEventArgs e)
        {
            cmButton.PlacementTarget = sender as Button;
            cmButton.IsOpen = true;
        }

        private void clickEdit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit Kunden");
        }
        private void clickDelete(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete Kunden");
        }
    }
}
