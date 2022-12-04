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

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private PersonClass _tmpPerson;
        private PersonClass _curPerson;

        public Window2(object obj, bool IsEdit) : this()
        {
            _curPerson = obj as PersonClass;
            this.DataContext = _curPerson;
            if(IsEdit)
            {
                _tmpPerson = new PersonClass(_curPerson);
            } else
            {
                CancelButton.Visibility = Visibility.Collapsed;
                LastName.IsEnabled = IsEdit;
                FirstName.IsEnabled = IsEdit;
                SecondName.IsEnabled = IsEdit;
                Age.IsEnabled = IsEdit;
            }
        }

        public Window2()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            PersonClass.CopyData(_curPerson, _tmpPerson);
            this.Close();
        }
    }
}
