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

namespace Biblioteca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca b;
        public MainWindow()
        {
            InitializeComponent();
            b = new Biblioteca("MALATESTIANA", "VIA E,TARANTELLI", "08:00", "18:00");
        }

        private void btn_Libri_Click(object sender, RoutedEventArgs e)
        {
            WindowLibro wl = new WindowLibro(Biblioteca B);
            wl.ShowDialog();
        }

        private void btn_Biblioteca_Click(object sender, RoutedEventArgs e)
        {
            WindowBiblioteca wb = new WindowBiblioteca(Biblioteca B);
            wb.ShowDialog();
        }
    }
}
