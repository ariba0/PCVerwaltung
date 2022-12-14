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
    /// Interaktionslogik für CPUPurchWindow.xaml
    /// </summary>
    public partial class CPUPurchWindow : Window
    {
        public CPUPurchWindow()
        {
            InitializeComponent();
        }

        private void CompleteBtnOrder(object sender, RoutedEventArgs e)
        {
        }

        private void CompleteBtnClick(object sender, RoutedEventArgs e)
        {
            PurchaseMgmt.CPUtoSQL(HerstellerTxtb.Text,ModellTxtb.Text,TaktfrequenzTxtb.Text,PreisTxtb.Text,AnzahlKerneTxtb.Text,KühlleistungTxtb.Text);
            
            ModellTxtb.Text = null;
            HerstellerTxtb.Text = null;
            TaktfrequenzTxtb.Text = null;
            PreisTxtb.Text = null;
            AnzahlKerneTxtb.Text = null;
            KühlleistungTxtb.Text = null;
        }

        private void BackBtnClick(object sender, RoutedEventArgs e)
        {
            PurchHWKWindow PurchHWKWin1 = new PurchHWKWindow();
            PurchHWKWin1.Show();
            this.Close();
        }

        private void PreisTxtb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
