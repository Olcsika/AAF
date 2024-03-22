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

            List<string> tancNevek = new List<string>();

            for(int i = 0; i<tancok.Count;i++)
            {
                if (tancNevek.Contains(tancok[i].tanc))
                {
                    tancNevek.Add(tancok[i].tanc);
                }
            }
            listBox.ItemsSource = tancNevek;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string szoveg = "Első tánc: " + tancok[0].tanc  + ", utolső tánc:" + tancok[tancok.Count-1].tanc;
            textBlock.Text = szoveg;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "A samba-t " + tancSzamol("samba") + " táncolta";
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

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            label1.Content=tancSzamol(lb.SelectedItem.ToString());
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;

            string partner = "Ilyet nem táncolt";
            for(int i = 0; i<tancok.Count;i++)
            {
                if (tancok[i].lany=="Vilma")
                {
                    if (tancok[i].lany == lb.SelectedItem.ToString())
                    {
                        partner = tancok[i].fiu;
                    }
                }
               
            }
            label2.Content=partner;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            List<string> lanyok = new List<string>();
            List<string> fiuk = new List<string>();

            for (int i = 0;i<tancok.Count ; i++)
            {
                if (!lanyok.Contains(tancok[i].lany))
                {
                    lanyok.Add(tancok[i].lany);
                }
                if (!fiuk.Contains(tancok[i].fiu))
                {
                    fiuk.Add(tancok[i].fiu);
                }
                StreamWriter ir = new StreamWriter("szereplők.txt");
                ir.WriteLine("Lányok: {0}",String.Join(", ",lanyok));
                ir.WriteLine("Fiuk: {0}", String.Join(", ", fiuk));
                ir.Close();

                /*
                <tancosok>
                    <fiuk>
                        <nev> Kálmán</nev>
                        <nev> Józsi</nev>
                        <nev> Huni</nev>
                    </fiuk>

                </tancosok>
                 
                */
            }
        }
    }
}
