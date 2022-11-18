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
    /// Interaktionslogik für KundenErstellen.xaml
    /// </summary>
    public partial class KundenErstellen : Panel
    {
        public KundenErstellen() : base()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txboxKundenName.Text;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Ungültiger Name für einen Kunden!");
                return;
            }

            var exists = KundenSQL._kunden.Find(x => x.Name == name);
            if (exists != null)
            {

                MessageBox.Show("Kunde ist bereits vorhanden!");
                return;
            }

            KundenSQL.SaveKunden(name);
            txboxKundenName.Text = "";
        }
    }
}
