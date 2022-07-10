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

namespace Projekt_II
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ////using (var context = new MyDbContext())
            ////{
            ////  context.Database.EnsureCreated();
            ////}
                InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            using (var context = new MyDbContext())
            {
                var btn = sender as Button;
                listadokumentów.Children.Clear();
                var dokumenty = context.dokumenty.ToArray();
                foreach (var dokument in dokumenty)
                {
                    listadokumentów.Children.Add(new Label()
                    {
                        Content = $"{dokument.id}. {dokument.stan} {dokument.numer}"
                    }); 
                }
            }
            using (var context = new MyDbContext())
            {
                var btn = sender as Button;
                listasamochodow.Children.Clear();
                var samochody = context.samochod.ToArray();
                foreach (var samochod in samochody)
                {
                    listasamochodow.Children.Add(new Label()
                    {
                        Content = $"{samochod.id}. {samochod.marka} {samochod.VIN} {samochod.Status}"
                    });
                }
            }
            using (var context = new MyDbContext())
            {
                var btn = sender as Button;
                listawlascieli.Children.Clear();
                var wlasciciele = context.wlasciciel.ToArray();
                foreach (var wlasciciel in wlasciciele)
                {
                    listawlascieli.Children.Add(new Label()
                    {
                        Content = $"{wlasciciel.id}. {wlasciciel.imie} {wlasciciel.nazwisko} {wlasciciel.numer_tel}"
                    });
                }
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContext())
            {
                var dokument = Convert.ToInt32(doks.Text);
                var znajdzdok = context.dokumenty.SingleOrDefault(x => x.numer == dokument);

               if (znajdzdok == null)
                {
                    MessageBox.Show("Podany numer Dokumentu nie znajduje sie w bazie danych", "Brak danych", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
               else if (znajdzdok != null)
               {
                    MessageBox.Show("Podany numer Dokumentu  znajduje sie w bazie danych", "Dane Zgodne", MessageBoxButton.OK, MessageBoxImage.Information);
               }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContext())
            {
                var samochod = Convert.ToInt32(samo.Text);
                var znajdzsam = context.samochod.SingleOrDefault(x => x.id == samochod);

                if (znajdzsam == null)
                {
                    MessageBox.Show("Podany numer id samochodu nie znajduje sie w bazie danych", "Brak danych", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (znajdzsam != null)
                {
                    MessageBox.Show("Podany numer id samochodu  znajduje sie w bazie danych", "Dane Zgodne", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContext())
            {
                var wlasciciel = Convert.ToInt32(wlas.Text);
                var znajdzwla = context.wlasciciel.SingleOrDefault(x => x.id == wlasciciel);

                if (znajdzwla == null)
                {
                    MessageBox.Show("Podany numer id wlasciciela nie znajduje sie w bazie danych", "Brak danych", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (znajdzwla != null)
                {
                    MessageBox.Show("Podany numer id wlasciciela  znajduje sie w bazie danych", "Dane Zgodne", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }

        }
    }
}
