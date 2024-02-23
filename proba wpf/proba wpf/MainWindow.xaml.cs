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

namespace proba_wpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Initialized(object sender, EventArgs e)
        {

        }

        private void almafa_Drop(object sender, DragEventArgs e)
        {

        }

        private void Button_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(ize.Visibility == Visibility.Visible)
            {
                ize.Visibility = Visibility.Hidden;
            }
            else
            {
                ize.Visibility = Visibility.Visible;
            }
        }

        private void bela_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ize.Opacity = bela.Value;
        }
    }
}
