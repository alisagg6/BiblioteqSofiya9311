using BiblioteqSofiya931.DBConnection;
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

namespace BiblioteqSofiya931.Pages
{
    /// <summary>
    /// Логика взаимодействия для BookPage1.xaml
    /// </summary>
    public partial class BookPage1 : Page
    {
        public static List<book> books {  get; set; }
        public BookPage1()
        {
            InitializeComponent();
            books = new List<book>(Connection.biblioteq.book.Where(i => i.IsDelete == false).ToList());
            this.DataContext = this;
        }

        private void cbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var t = cbFilter.SelectedItem as Avtor;
            //if (t.ID != -1)
            //    Lv.ItemsSource = books.Where(i => i.ID == t.ID).ToList();
            //else
            //    Lv.ItemsSource = books.ToList();
        }

        private void btnnew_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
