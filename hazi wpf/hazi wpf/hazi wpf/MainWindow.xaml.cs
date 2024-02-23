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

namespace hazi_wpf
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

        private void csusz1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kep1.Opacity = csusz1.Value;
        }

        private void csusz2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kep2.Opacity = csusz2.Value;
        }

        private void csusz3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kep3.Opacity = csusz3.Value;
        }

        private void csusz4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kep4.Opacity = csusz4.Value;
        }
    }
}
