using System;
using System.Collections.Generic;
using System.IO;
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

namespace Latin_táncok
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

        List<Class1> tancok = new List<Class1>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader olvas = new StreamReader("tancrend.txt");
            while(!olvas.EndOfStream)
            {
                string[] sorok = new string[3];
                for(int i = 0;i<sorok.Length;i++)
                {
                    sorok[i] = olvas.ReadLine();
                }
                tancok.Add(new Class1(sorok[0], sorok[1], sorok[2]));
            }
            olvas.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string szoveg = "Első tánc: " + tancok[0].tanc  + ", utolső tánc:" + tancok[tancok.Count-1].tanc;
            textBlock.Text = szoveg;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
        private int tancSzamol(string tanc)
        {
            int db = 0;
            for(int i = 0;i<tancok.Count;i++) 
            {
                if (tancok[i].tanc==tanc)
                {
                    db++;
                }
            }


            return db;
        }
    }
}
