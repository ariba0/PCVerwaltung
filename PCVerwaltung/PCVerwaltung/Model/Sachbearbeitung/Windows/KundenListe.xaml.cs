﻿using System;
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
    /// Interaktionslogik für KundenListe.xaml
    /// </summary>
    public partial class KundenListe : UserControl
    {
        public KundenListe()
        {
            InitializeComponent();

            KundenSQL.UpdateLocal();

            foreach(var kunde in KundenSQL._kunden)
            {
                KundenInfo newEntry = new KundenInfo();
                newEntry.kundenInfoFullname.Content = kunde.Name;
                stackKunden.Children.Add(newEntry);
            }
        }
    }
}
