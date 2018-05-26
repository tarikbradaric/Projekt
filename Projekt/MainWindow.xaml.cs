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
           new Spieler("Cristiano", "Ronaldo","Real Madrid"),
           new Spieler("Lionel", "Messi","Real Madrid"),
           new Spieler("Neymar", "JR","Real Madrid"),
           new Spieler("Sergio", "Aguero","Real Madrid"),
            };

        ObservableCollection<Trainer> t = new ObservableCollection<Trainer> {
           new Trainer("Zinedin", "Zidane","Real Madrid"),
           new Trainer("Pep", "Guardiola","Man City"),
           new Trainer("Jürgen", "Klopp","Liverpool"),
           new Trainer("Jose", "Mourinho","Man United"),
            };

        Queue<Spieler> st = new Queue<Spieler>();

        Queue<Trainer> tr = new Queue<Trainer>();




        public MainWindow()
        {

            InitializeComponent();

            Mannschaften.ItemsSource = s;

            listBox2.ItemsSource = t;

            for (int i = 0; i < s.Count; i++)
            {


                st.Enqueue(s[i]);


            }

            for (int i = 0; i < s.Count; i++)
            {


                tr.Enqueue(t[i]);


            }
        }

        private void Mannschaften_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //listBox.Items.Add(Mannschaften.SelectedItem);
              
            using (StreamReader r = new StreamReader("Ronaldo.txt"))//StreamReader mit deiner Datei erstellen
            {

            try {
                if(Convert.ToString(Mannschaften.SelectedItem) == "Cristiano Ronaldo(Spieler von Real Madrid)")
                {
                 listBox.Items.Add(System.IO.File.ReadAllText("Ronaldo.txt"));
                }

            }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Kein File gefunden!");
                }
            }
           



            using (StreamReader r = new StreamReader("Messi.txt"))//StreamReader mit deiner Datei erstellen
            {

                try { 
                if (Convert.ToString(Mannschaften.SelectedItem) == "Lionel Messi(Spieler von Real Madrid)") 
                {
                    listBox.Items.Add(System.IO.File.ReadAllText("Messi.txt")); 
                }

                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Kein File gefunden!");
                }

            }

            using (StreamReader r = new StreamReader("Neymar.txt"))//StreamReader mit deiner Datei erstellen
            {

                try
                {
                    if (Convert.ToString(Mannschaften.SelectedItem) == "Neymar JR(Spieler von Real Madrid)")
                    {
                        listBox.Items.Add(System.IO.File.ReadAllText("Neymar.txt"));
                    }

                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Kein File gefunden!");
                }

            }

            using (StreamReader r = new StreamReader("Aguero.txt"))//StreamReader mit deiner Datei erstellen
            {

                try
                {
                    if (Convert.ToString(Mannschaften.SelectedItem) == "Sergio Aguero(Spieler von Real Madrid)")
                    {
                        listBox.Items.Add(System.IO.File.ReadAllText("Aguero.txt"));
                    }

                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Kein File gefunden!");
                }

            }






        }

        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


             
            using (StreamReader r = new StreamReader("Zidane.txt"))//StreamReader mit deiner Datei erstellen
            {

                try {

                if (listBox2.SelectedItem.ToString() == "Zinedin Zidane(Trainer von Real Madrid)")
                {
                    listBox.Items.Add(System.IO.File.ReadAllText("Zidane.txt"));
                }
                }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Kein File gefunden!");
            }

            }
            

             
            using (StreamReader r = new StreamReader("Gurdiola.txt"))//StreamReader mit deiner Datei erstellen
            {

            try {

                if (listBox2.SelectedItem.ToString() == "Pep Guardiola(Trainer von Man City)")
                {
                    listBox.Items.Add(System.IO.File.ReadAllText("Gurdiola.txt"));
                }

                }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Kein File gefunden!");
            }

            }
            

            
            using (StreamReader r = new StreamReader("Klopp.txt"))//StreamReader mit deiner Datei erstellen
            {
                try {


                if (listBox2.SelectedItem.ToString() == "Jürgen Klopp(Trainer von Liverpool)")
                {
                    listBox.Items.Add(System.IO.File.ReadAllText("Klopp.txt"));
                }

                }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Kein File gefunden!");
            }

            }
           

            using (StreamReader r = new StreamReader("Mourinho.txt"))//StreamReader mit deiner Datei erstellen
            {
                try { 


                if (listBox2.SelectedItem.ToString() == "Jose Mourinho(Trainer von Man United)")
                {
                    listBox.Items.Add(System.IO.File.ReadAllText("Mourinho.txt"));
                }

                }

                catch (FileNotFoundException)
                {
                    MessageBox.Show("Kein File gefunden!");
                }

            }

            

            

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {



            try {

                listBox1.Items.Add(st.Dequeue());

                

                //int counter = s.Count -1;

                //s.RemoveAt(counter);
                //counter--;

            }

            catch(System.InvalidOperationException)
            {
                MessageBox.Show("Keine Elemente mehr vorhanden!");
            }
           
           









        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("Ronaldo.txt", true);
            sw.WriteLine(filename.Text);
            sw.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("Messi.txt", true);
            sw.WriteLine(filename.Text);
            sw.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("Neymar.txt", true);
            sw.WriteLine(filename.Text);
            sw.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("Aguero.txt", true);
            sw.WriteLine(filename.Text);
            sw.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("Zidane.txt", true);
            sw.WriteLine(filename.Text);
            sw.Close();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("Gurdiola.txt", true);
            sw.WriteLine(filename.Text);
            sw.Close();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("Klopp.txt", true);
            sw.WriteLine(filename.Text);
            sw.Close();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("Mourinho.txt", true);
            sw.WriteLine(filename.Text);
            sw.Close();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                

                listBox1.Items.Add(tr.Dequeue());

                

            }

            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Keine Elemente mehr vorhanden!");
            }
        }
    }
    }

