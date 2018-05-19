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
using System.IO;
using System.Collections.ObjectModel;

namespace Projekt
{
    
    public partial class MainWindow : Window
    {

        ObservableCollection<Spieler> s = new ObservableCollection<Spieler> {
           new Spieler("Cristiano", "Ronaldo"),
           new Spieler("Lionel", "Messi"),
           new Spieler("Neymar", "JR"),
           new Spieler("Sergio", "Aguero"),
            };

        ObservableCollection<Trainer> t = new ObservableCollection<Trainer> {
           new Trainer("Zinedin", "Zidane"),
           new Trainer("bla", "ba"),
           new Trainer("schala", "la"),
           new Trainer("jow", "jow"),
            };

        public MainWindow()
        {

            InitializeComponent();

            Mannschaften.ItemsSource = s;

            listBox2.ItemsSource = t;
        }

        private void Mannschaften_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //listBox.Items.Add(Mannschaften.SelectedItem);
            try { 
            using (StreamReader r = new StreamReader(@"G:\SewProjekt\Projekt\Projekt\bin\Debug\Ronaldo.txt"))//StreamReader mit deiner Datei erstellen
            {


                if(Convert.ToString(Mannschaften.SelectedItem) == "Cristiano Ronaldo")
                {
                 listBox.Items.Add(System.IO.File.ReadAllText(@"Ronaldo.txt"));
                }

            }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Kein File gefunden!");
            }

        }

        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            using (StreamReader r = new StreamReader(@"G:\SewProjekt\Projekt\Projekt\bin\Debug\Zidane.txt"))//StreamReader mit deiner Datei erstellen
            {

                

                if (listBox2.SelectedItem.ToString() == "Zinedin Zidane")
                {
                    listBox.Items.Add(System.IO.File.ReadAllText(@"Zidane.txt"));
                }

            }
        }

        




    }
    }

