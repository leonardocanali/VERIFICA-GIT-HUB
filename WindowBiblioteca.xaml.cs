using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Biblioteca
{
    /// <summary>
    /// Logica di interazione per WindowBiblioteca.xaml
    /// </summary>
    public partial class WindowBiblioteca : Window
    {
        Biblioteca biblioteca;
        private List<Libro> libri;
        public WindowBiblioteca(Biblioteca b)
        {
            InitializeComponent();
            biblioteca = b;
        }

        private void btn_RicercaPerTirolo_Click(object sender, RoutedEventArgs e)
        {
            Libro libroDaCercare = RicercaPerTitolo(txt.Ricerca.Text);
            lst_Ricerche.Items.Add(libroDaCercare);
        }

        private void btn_RicercaPerAutore_Click(object sender, RoutedEventArgs e)
        {
            libri = RicercaPerAutore(txt_ricercaAutore.Text);
            foreach(Libro l in libri)
            {
                lst_Ricerche.Items.Add(l);
            }
        }
    }
}
