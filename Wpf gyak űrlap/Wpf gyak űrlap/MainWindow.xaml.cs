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
                if (uzenet == "Add vissza az ezresemet!")
                {
                    listBox.Items[listBox.SelectedIndex] = nev + ", " + szhely + ", " + kor;

                    uzenet = "";
                }
                else
                {
                    listBox.Items.Add(nev + ", " + szhely + ", " + kor);

                }
                

                textbox.Text = "";
                textbox1.Text = "";
                textbox2.Text = "";

            }

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        string uzenet = "";
        private void listBox_MouseUp(object sender, MouseButtonEventArgs e)
        {
            string szoveg = ((ListBox)sender).SelectedItem.ToString();
            //MessageBox.Show(szoveg);
            string[] vag = szoveg.Split(", ");
            textbox.Text = vag[0];
            textbox1.Text = vag[1];
            textbox2.Text= vag[2];

            uzenet = "Add vissza az ezresemet!";
        }
    }
}
