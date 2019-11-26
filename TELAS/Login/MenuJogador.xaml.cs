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
    /// Lógica interna para MenuJogador.xaml
    /// </summary>
    public partial class MenuJogador : Window
    {
        public MenuJogador()
        {
            InitializeComponent();
        }


        public bool jog = false;
        
        private void Button_Perfil(object sender, RoutedEventArgs e)
        {
            PerfilJogador x = new PerfilJogador();
            Close();
            x.Show();
        }

        private void Button_DadosEstatisticos(object sender, RoutedEventArgs e)
        {
            jog = true;
            DadosEstatísticos x = new DadosEstatísticos();
            Close();
            x.Show();
        }

        private void Button_Logout(object sender, RoutedEventArgs e)
        {
            MainWindow x = new MainWindow();
            Close();
            x.Show();
        }
    }
}
