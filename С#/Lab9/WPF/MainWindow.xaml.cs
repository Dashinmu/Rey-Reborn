using System;
using System.Collections;
using System.Collections.ObjectModel;
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

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<PersonClass> Persons;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Persons = new ObservableCollection<PersonClass>();
            Persons.Add(new PersonClass("Ivanov", "Ivan", "Ivanich", 25));
            Persons.Add(new PersonClass("Kabanov", "KaBan", "Kabanovich", 22));
            UsersList.DataContext = Persons;
        }

        private void ViewBtn_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2(UsersList.SelectedItem, false);
            window2.Owner = this;
            window2.ShowDialog();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            PersonClass person = new PersonClass();
            Window2 window2 = new Window2(person, true);
            window2.Owner = this;
            window2.ShowDialog();

            if (person.Age != 0)
            {
                Persons.Add(person);
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2(UsersList.SelectedItem, true);
            window2.Owner = this;
            window2.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            PersonClass person = UsersList.SelectedItem as PersonClass;
            string str = string.Format("Delete note: {0} {1}", person.LastName, person.FirstName);
            if (MessageBox.Show(this, str, "Warning", MessageBoxButton.YesNo) == MessageBoxResult.Yes) Persons.Remove(person);
        }
    }
}
