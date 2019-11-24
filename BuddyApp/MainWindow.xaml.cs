using BuddyApp.Models;
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

namespace BuddyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Buddy> Buddies = new List<Buddy>();
        int SummSpend = 0;
        public MainWindow()
        {
            Buddies.Add(new Buddy("Vova"));
            Buddies.Add(new Buddy("Roman"));
            Buddies.Add(new Buddy("Sergei"));
            Buddies.Add(new Buddy("Igor"));
            Buddies.Add(new Buddy("Sanya"));
            InitializeComponent();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if(!string.IsNullOrEmpty(textBox.Text))
                {
                    var expence = Convert.ToInt32(textBox.Text);
                    SetBuddyExpand(textBox.Name, expence);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("FUCK!");
            }
        }

        void SetBuddyExpand(string name, int expance)
        {
            var buddy = Buddies.FirstOrDefault(b => b.Name == name);
            buddy.Spent = expance;
            SummSpend = Buddies.Sum(b => b.Spent);
            if(this.FindName("Spend") != null)
            (this.FindName("Spend") as Label).Content = SummSpend.ToString();
        }
    }
}
