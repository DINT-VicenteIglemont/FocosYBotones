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

namespace Focos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Textbox1.Text != null)
            {
                Textbox1.Select(Textbox1.Text.Length, 0);
                Textbox1.Text = Textbox1.Text.ToUpper();
            }
        }

        private void Textbox1_GotFocus(object sender, RoutedEventArgs e)
        {
            FocoTextbox.Text = "TextBox 1";
        }
        

        private void Textbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F1)
            {
                Textbox2.Text = "Ayuda";
            }
        }

        private void Textbox2_GotFocus(object sender, RoutedEventArgs e)
        {
            FocoTextbox.Text = "TextBox 2";
        }


        private void Textbox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string texto = "";

            for (int i = 0; i < Textbox3.Text.Length; i++)
            {

                if(Textbox3.Text[i] != 'a' && 
                   Textbox3.Text[i] != 'e' && 
                   Textbox3.Text[i] != 'i' && 
                   Textbox3.Text[i] != 'o' && 
                   Textbox3.Text[i] != 'o' && 
                   Textbox3.Text[i] != 'u' && 
                   Textbox3.Text[i] != 'A' && 
                   Textbox3.Text[i] != 'E' && 
                   Textbox3.Text[i] != 'I' && 
                   Textbox3.Text[i] != 'O' && 
                   Textbox3.Text[i] != 'U')
                {
                    texto += Textbox3.Text[i].ToString();
                }

            }
            Textbox3.Select(texto.Length, 0);
            Textbox3.Text = texto;

        }

        private void Textbox3_GotFocus(object sender, RoutedEventArgs e)
        {
            FocoTextbox.Text = "TextBox 3";
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ClickIzquierdoTextbox.Background = Brushes.Red;
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ClickIzquierdoTextbox.Background = Brushes.White;
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ClickDerechoTextbox.Background = Brushes.Red;
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            ClickDerechoTextbox.Background = Brushes.White;
        }

        private void Textbox1_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobreTextbox.Text = ((TextBox)sender).Name;
        }

        private void Textbox2_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobreTextbox.Text = ((TextBox)sender).Name;
        }

        private void Textbox3_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobreTextbox.Text = ((TextBox)sender).Name;
        }
    }
}
