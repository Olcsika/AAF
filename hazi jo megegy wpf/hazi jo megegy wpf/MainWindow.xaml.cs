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

namespace hazi_jo_megegy_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool betoltott=false;
        public MainWindow()
        {
            InitializeComponent();

            this.betoltott = true;
        }

        double[] ertekek=new double[4] { 1,1,1,1};
        private void csusz1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott)
            {
                ertekek[0] = csusz1.Value;
                ertekek[0] = ((Slider)sender).Value;
                kep1.Opacity = (1 - ertekek[0]) * ertekek[1];
                kep2.Opacity = ertekek[0] * ertekek[2];
            }
            
        }

        private void csusz4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott) 
            {
                ertekek[1] = csusz4.Value;
                ertekek[1] = ((Slider)sender).Value;
                kep1.Opacity = (1 - ertekek[0]) * ertekek[1];
                kep3.Opacity = (1 - ertekek[0]) * ertekek[3];
            }
            
        }

        private void csusz3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott)
            {
                ertekek[2] = csusz4.Value;
                ertekek[2] = ((Slider)sender).Value;
                kep3.Opacity = (1 - ertekek[1]) * ertekek[2];
                kep4.Opacity = (1 - ertekek[1]) * ertekek[3];
            }

        }

        private void csusz2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott)
            {
                ertekek[3] = csusz4.Value;
                ertekek[3] = ((Slider)sender).Value;
                kep2.Opacity = (1 - ertekek[2]) * ertekek[3];
                kep4.Opacity = (1 - ertekek[3]) * ertekek[0];
            }

        }
    }
}
