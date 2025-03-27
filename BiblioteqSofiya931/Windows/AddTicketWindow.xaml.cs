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
    /// Логика взаимодействия для AddTicketWindow.xaml
    /// </summary>
    public partial class AddTicketWindow : Window
    {
        public static List<Chitatel> chitatel { get; set; }
        public static List<Employee> employee { get; set; }
        public AddTicketWindow()
        {
            InitializeComponent();
            chitatel = new List<Chitatel>(Connection.biblioteq.Chitatel.Where(i => i.IsDelete == false).ToList());
            employee = new List<Employee>(Connection.biblioteq.Employee.Where(i => i.IsDelete == false).ToList());
            this.DataContext = this;
        }

        private void AddTicketBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddTicketWindow addTicketWindow = new Windows.AddTicketWindow();    
            addTicketWindow.Show();
        }

        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {
            ReaderCm.ItemsSource = new List<Chitatel>(Connection.biblioteq.Chitatel.Where(i => i.IsDelete == false).ToList());
        }

        private void SaveTicketBtn_Click(object sender, RoutedEventArgs e)
        {
            ChitatelBilet chitatelBilet = new ChitatelBilet();
            chitatelBilet.IsDelete = false;
            chitatelBilet.DateReg = DateTime.Now;
            var chitate = ReaderCm.SelectedItem as Chitatel;
            chitatelBilet.Id_Chitatel = chitate.ID;
            var employee = EmployeeCm.SelectedItem as Employee;
            chitatelBilet.Id_Employee = employee.ID;
            Connection.biblioteq.ChitatelBilet.Add(chitatelBilet);
            Connection.biblioteq.SaveChanges();
            MessageBox.Show("Новый билет добавлен.");
            Close();
        }
    }
    
}
