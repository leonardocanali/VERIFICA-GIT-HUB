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
    /// Logica di interazione per WindowLibro.xaml
    /// </summary>
    public partial class WindowLibro : Window
    {
        private List<Libro> libri;
        private Biblioteca biblioteca;
        public WindowLibro(Biblioteca b)
        {
            InitializeComponent();
            libri = new List<Libro>();
            biblioteca = b;
        }

        private void btn_Aggiungi_Click(object sender, RoutedEventArgs e)
        {
            Libro l = new Libro(txt_Autore, txt_Titolo, DateTime.Parse(txt_Data.Text), txt_Editore, int.Parse(txt_pag.Text));
            libri = biblioteca.AggiungiLibro(l);
            StampaLibri();
            
        }

        private void StampaLibri()
        {
            foreach(Libro l in libri)
            {
                lst_Libri.Items.Add(l);
            }
        }

        private void btn_ReadingText_Click(object sender, RoutedEventArgs e)
        {
            Libro l = lst_Libri.SelectedItem as Libro;
            string tempoLettura = biblioteca.ReadingTime(l);
            lbl_Output.Content = " " + tempoLettura;
        }
    }
}
