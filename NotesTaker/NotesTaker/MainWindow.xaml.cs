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

namespace NotesTaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Username.Text == "divoom12" && Password.Password == "19710918")
            {
                MessageBox.Show("Logged In!");
                CurrentPasswords passForm = new CurrentPasswords();
                passForm.Show();

            }

            else
                MessageBox.Show("Wrong Username Or Password!");
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
