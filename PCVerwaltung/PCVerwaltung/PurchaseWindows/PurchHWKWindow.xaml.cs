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
    /// Interaktionslogik für PurchHWKWindow.xaml
    /// </summary>
    public partial class PurchHWKWindow : Window
    {
        public PurchHWKWindow()
        {
            InitializeComponent();
        }

        private void CPUClick(object sender, RoutedEventArgs e)
        {
            CPUPurchWindow CPUPurchWin1 = new CPUPurchWindow();
            CPUPurchWin1.Show();
            this.Close();
        }

        private void LogoutClick(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void MainboardClick(object sender, RoutedEventArgs e)
        {
            MainboardPurchWindow MBPurchWin1 = new MainboardPurchWindow();
            MBPurchWin1.Show();
            this.Close();
        }

        private void SSDClick(object sender, RoutedEventArgs e)
        {
            SSDPurchWindow SSDPurchWin1 = new SSDPurchWindow();
            SSDPurchWin1.Show();
            this.Close();
        }

        private void MonitorClick(object sender, RoutedEventArgs e)
        {
            MonitorPurchWindow MonPurchWin1 = new MonitorPurchWindow();
            MonPurchWin1.Show();
            this.Close();
        }
    }
}
