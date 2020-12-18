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
using WpfAppLibrairieMVVM.View;

namespace WpfAppLibrairieMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frmPrincial.Navigate(new PagePrincipale());
        }

        private void GoToPageNouveauLivre_Click(object sender, RoutedEventArgs e)
        {
            frmPrincial.Navigate(new PageNouveauLivre());
        }
    }
}
