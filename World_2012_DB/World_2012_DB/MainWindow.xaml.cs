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
using System.Data.Entity;

namespace World_2012_DB
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AdventureWorksLT2012Entities _context = new AdventureWorksLT2012Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource customerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerViewSource")));
            // Charger les données en définissant la propriété CollectionViewSource.Source :
            // customerViewSource.Source = [source de données générique]
            _context.Customer.Load();
            customerViewSource.Source = _context.Customer.Local;



        }

        /*Bouton CustomerAddress*/
        private void Button_Click_CustomerAdd(object sender, RoutedEventArgs e)
        {
            this.CustomerAdd.Visibility = Visibility.Visible;

        }

    }
}
