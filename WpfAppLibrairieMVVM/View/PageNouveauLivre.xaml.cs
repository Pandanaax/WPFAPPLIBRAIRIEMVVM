﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

namespace WpfAppLibrairieMVVM.View
{
    /// <summary>
    /// Interaction logic for PageNouveauLivre.xaml
    /// </summary>
    public partial class PageNouveauLivre : Page
    {
        public PageNouveauLivre()
        {
            InitializeComponent();
            ChargerListeLivreExterne();
        }

        private void ChargerListeLivreExterne()
        {
            // Cas 1 la source est une liste de fichier

            // Cas un WS

            cbbListeLivreSource.ItemsSource = Helpers.Utils.GetListBook();

        }
    }
}
