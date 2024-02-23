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

namespace Wpf_gyak_űrlap
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nev = textbox.Text;
            string szhely = textbox1.Text;
            string kor = textbox2.Text;

            if(nev=="" || szhely=="" || kor == "")
            {
                MessageBox.Show("Töltsd ki mind! ");
            }
            else
            {
                listBox.Items.Add(nev + ", " + szhely + ", " + kor);

                textbox.Text = "";
                textbox1.Text = "";
                textbox2.Text = "";

            }

        }
    }
}
