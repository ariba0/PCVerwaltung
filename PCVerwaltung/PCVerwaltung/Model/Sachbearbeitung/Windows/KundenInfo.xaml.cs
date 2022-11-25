using Microsoft.VisualBasic;
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
            string input = Interaction.InputBox("Neuen Namen eingeben:", "Kunden Bearbeiten", "");
            if (String.IsNullOrEmpty(input))
            {
                MessageBox.Show("Kein gültiger Name wurde eingegeben.");

            } else
            {
                KundenSQL.EditKunden(kundenInfoFullname.Content.ToString(), input);
                kundenInfoFullname.Content = input;
            }
        }
        private void clickDelete(object sender, RoutedEventArgs e)
        {
            string input = Interaction.InputBox("Schreiben sie den KUNDEN NAMEN um den Kunden zu löschen.", "Kunden Löschen", "");
            if (String.IsNullOrEmpty(input))
            {
                return;
            }


            if (kundenInfoFullname.Content.ToString() == input)
            {
                KundenSQL.RemoveKunden(kundenInfoFullname.Content.ToString());
                ((Panel)this.Parent).Children.Remove(this);
            }
        }
    }
}
