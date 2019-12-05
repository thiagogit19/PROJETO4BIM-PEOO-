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
using Modelo;

namespace Login
{
    /// <summary>
    /// Lógica interna para MenuPresidente.xaml
    /// </summary>
    public partial class MenuPresidente : Window
    {
        ModPresidente p;
        public MenuPresidente(ModUsuario m)
        {
            InitializeComponent();
            p = m as ModPresidente;
        }

        public bool pre = false;


        private void Button_Perfil(object sender, RoutedEventArgs e)
        {
            PerfilPresidente x = new PerfilPresidente(p);
            Close();
            x.Show();
        }

        private void Button_Torneio(object sender, RoutedEventArgs e)
        {
            TorneioMostrar x = new TorneioMostrar();
            Close();
            x.Show();
        }

        private void Button_Equipes(object sender, RoutedEventArgs e)
        {
            EquipesMostrar x = new EquipesMostrar();
            Close();
            x.Show();
        }

        private void Button_Partidas(object sender, RoutedEventArgs e)
        {
            PartidasMostrar x = new PartidasMostrar();
            Close();
            x.Show();
        }

        private void Button_Jog(object sender, RoutedEventArgs e)
        {
            JogadorMostrarAtualizar x = new JogadorMostrarAtualizar();
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
