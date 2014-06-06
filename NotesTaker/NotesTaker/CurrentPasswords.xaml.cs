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

namespace NotesTaker
{
    /// <summary>
    /// Interaction logic for CurrentPasswords.xaml
    /// </summary>
    public partial class CurrentPasswords : Window
    {
        public CurrentPasswords()
        {
            InitializeComponent();

            string[] listOfNames = { "Facebook.com, konqMoi - 175485739",
                                 "Zamunda.net, gotinPi4 - sdfkv5885f",
                                 "Arena.Bg, pomorieca - mmmn5783d",
                                 "Prodavalnik.bg, geroqNaSveta - 1234567",
                                 "BgMafia.com, miro - qwertyuiiop",
                                 "Youtube.com, bai_Ganio - bulgaria123" };
            string[] splitted = new string[2];
            for (int i = 0; i < listOfNames.Length; i++)
            {
                splitted = listOfNames[i].Split('-');
                usernames.Items.Add(splitted[0]);
                passwords.Items.Add(splitted[1]);
            }
            usernames.Height = usernames.Items.Count * 18;
            passwords.Height = usernames.Items.Count * 18;
            this.Height = usernames.Height + 50;
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
