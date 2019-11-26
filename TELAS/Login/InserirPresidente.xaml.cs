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
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Lógica interna para InserirPresidente.xaml
    /// </summary>
    public partial class InserirPresidente : Window
    {
        public InserirPresidente()
        {
            InitializeComponent();
        }

        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuAdiminstrador x = new MenuAdiminstrador();
            Close();
            x.Show();
        }

        NegPresidente
        private void Insert_Presidente(object sender, RoutedEventArgs e)
        {

        }
    }
}
