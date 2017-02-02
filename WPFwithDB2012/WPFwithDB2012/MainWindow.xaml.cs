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
using System.Data.Entity;

namespace WPFwithDB2012
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductContext _context = new ProductContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource customerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerViewSource")));
            _context.Customer.Load();
            customerViewSource.Source = _context.Customer.Local;

            System.Windows.Data.CollectionViewSource productCategoryViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productCategoryViewSource")));
            // Charger les données en définissant la propriété CollectionViewSource.Source :
            // productCategoryViewSource.Source = [source de données générique]
            _context.ProductCategory.Load();
            productCategoryViewSource.Source = _context.ProductCategory.Local;
        }

        private void Button_Click_CustomAdd(object sender, RoutedEventArgs e)
        {
            CustomAddWindow.Visibility = Visibility.Visible;
            ProductCatWindow.Visibility = Visibility.Collapsed;
        }

        // ProductCatWindow
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductCatWindow.Visibility = Visibility.Visible;
            CustomAddWindow.Visibility = Visibility.Collapsed;
        }
    }
}
