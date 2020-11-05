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

namespace Demo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)             //Skapa textboxar i Canvasen ---  Dynamiskt skapar ett skräddarsytt verktyg via kanvas.
            {
                TextBox tb = new TextBox();
                tb.Width = 100;
                string name = "textBox"+i;           // DENNA BEHÖVS INTE för att vi använder RegisterName.
                tb.Text = "Textboxen nr" + i;
                RegisterName(name, tb);              //registrerar textboxen så att man kan hitta den senare
                Canvas.SetLeft(tb, 25);
                Canvas.SetTop(tb,i*20);
                myCanvas.Children.Add(tb);           //Skapar textboxen - amazing.
            }



        }

        private void darkMode_Clicked(object sender, RoutedEventArgs e)                                   // Skapa darkmode
        {
            if (DarkMode.IsChecked == true)
            {
                myWindow.Background = new SolidColorBrush(Colors.Black);
                DarkMode.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                myWindow.Background = new SolidColorBrush(Colors.White);
                DarkMode.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)                                       // klickar och ändrar width
        {
            myRectangle.Width = myRectangle.Width - 10;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)                                     // klickar o ändrar width
        {
            myRectangle.Width = myRectangle.Width + 10;
        }

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)       //Använder slider för att ändra height
        {
            myRectangle.Height = mySlider.Value;
            myProgressbar.Value = mySlider.Value;
        }

        private void CalculateDiff_SelextedDateChanged(object sender, SelectionChangedEventArgs e)        //Datetime med Null reference.
        {
            DateTime? selectedDate = dateSelect.SelectedDate;
            DateTime? christmasDate = DateTime.Parse("2020-12-24");                                       //anger sökt datum

            TimeSpan? dayDifference = (christmasDate - selectedDate);

            christmasInfo.Text = $"{dayDifference.Value.Days} dagar till julafton";                      // jämnför sökt datetime och skriver ut den på ChristmasInfo.

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)             // söker och hittar registrerad textbox (Tex textbox3 för denna knapp)
        {
            TextBox tb3 = (TextBox)FindName("textBox3");
            if (tb3 != null)                                                      // om den inte är null, Nu kan vi hitta den och manipulera den.
            {
                tb3.Text = "Detta är textbox3!";
            }
        }
    }
}
