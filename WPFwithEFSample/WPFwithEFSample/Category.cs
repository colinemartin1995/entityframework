using System.Collections.ObjectModel;
namespace WPFwithEFSample
{
    /*Add a ** Category** class with the following definition:*/

    public class Category
    {
        public Category()
        {
            this.Products = new ObservableCollection<Product>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ObservableCollection<Product> Products { get; private set; }

    }
}
