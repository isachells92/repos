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

namespace MyWpfApplication
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

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myTextbox.Text = "hejsan alla cp barn";
            myTextbox2.Text = "Aragorn kommer \n \n Aragorn kommer";
            myTextbox3.Text = "Göm dina barn \n \n göm dina barn!";
            myCheckBox.IsChecked = true;
        }


        private void myButton2_Click(object sender, RoutedEventArgs e)
        {
            myTextbox.Text = "Hejdå alla cp barn";
            myTextbox2.Text = "Rawr rawr";
            myTextbox3.Text = "Meow Meow";
            myCheckBox.IsChecked = false;
        }
    }
}
