﻿using System;
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

namespace Biblioteca
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

        private void btn_Libri_Click(object sender, RoutedEventArgs e)
        {
            WindowLibro wl = new WindowLibro();
            wl.ShowDialog();
        }

        private void btn_Biblioteca_Click(object sender, RoutedEventArgs e)
        {
            WindowBiblioteca wb = new WindowBiblioteca();
            wb.ShowDialog();
        }
    }
}
