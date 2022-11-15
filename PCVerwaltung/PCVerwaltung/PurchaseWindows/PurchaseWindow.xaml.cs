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

namespace PCVerwaltung.PurchaseWindows
{
    /// <summary>
    /// Interaktionslogik für PurchaseWindow.xaml
    /// </summary>
    public partial class PurchaseWindow : Window
    {
        public PurchaseWindow()
        {
            InitializeComponent();
        }

        private void PurchButtonClick(object sender, RoutedEventArgs e)
        {
            PurchHWKWindow purchHWKWindow = new PurchHWKWindow();
            purchHWKWindow.Show();
            this.Close();
        }

        private void LogoutClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainwin = new MainWindow();
            mainwin.Show();
            this.Close();
        }
    }
}
