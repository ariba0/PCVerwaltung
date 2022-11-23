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
    /// Interaktionslogik für MonitorPurchWindow.xaml
    /// </summary>
    public partial class MonitorPurchWindow : Window
    {
        public MonitorPurchWindow()
        {
            InitializeComponent();
        }

        private void CompleteBtnClick(object sender, RoutedEventArgs e)
        {
            PurchaseMgmt.MonitortoSQL(HerstellerTxtb.Text, ModellTxtb.Text, AuflösungsTxtb.Text, PreisTxtb.Text);

            ModellTxtb.Text = null;
            HerstellerTxtb.Text = null;
            AuflösungsTxtb.Text = null;
            PreisTxtb.Text = null;
        }

        private void BackBtnClick(object sender, RoutedEventArgs e)
        {
            PurchHWKWindow PurchHWKWin1 = new PurchHWKWindow();
            PurchHWKWin1.Show();
            this.Close();
        }
    }
}
