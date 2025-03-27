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
using System.Windows.Shapes;

namespace BiblioteqSofiya931.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddReader.xaml
    /// </summary>
    public partial class AddReader : Window
    {
        public AddReader()
        {
            InitializeComponent();
        }

        private void SaveTicketBtn_Click(object sender, RoutedEventArgs e)
        {
            Chitatel chitatel = new Chitatel();
            chitatel.SurName = LastNameTb.Text.Trim();
            chitatel.Name = NameTb.Text.Trim();
            chitatel.Lastname = PatromymicTb.Text.Trim();
            chitatel.DateBirth = BirthDateDp.SelectedDate;
            chitatel.NomerPhone = PhoneTb.Text.Trim();
            chitatel.IsDelete = false;
            Connection.biblioteq.Chitatel.Add(chitatel);
            Connection.biblioteq.SaveChanges();
            MessageBox.Show("Читатель успешно добавлен");
            Close();
        }
    }
}
