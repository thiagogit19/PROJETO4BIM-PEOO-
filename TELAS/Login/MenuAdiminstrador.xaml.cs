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
    /// Lógica interna para MenuAdiminstrador.xaml
    /// </summary>
    public partial class MenuAdiminstrador : Window
    {
        public MenuAdiminstrador()
        {
            InitializeComponent();
        }

        private void Button_PerfilAdm(object sender, RoutedEventArgs e)
        {
            PerfilAdministrador x = new PerfilAdministrador();
            Close();
            x.Show();
        }
        private void Button_Torneio(object sender, RoutedEventArgs e)
        {
            TorneioAdm x = new TorneioAdm();
            Close();
            x.Show();
        }

        private void Button_Partidas(object sender, RoutedEventArgs e)
        {
            PartidasCadastrar x = new PartidasCadastrar();
            Close();
            x.Show();
        }

        private void Button_Logout(object sender, RoutedEventArgs e)
        {
            MainWindow x = new MainWindow();
            Close();
            x.Show();
        }

        private void Button_DadosEstatisticos(object sender, RoutedEventArgs e)
        {
            adm = true;
            DadosEstatísticos x = new DadosEstatísticos();
            Close();
            x.Show();
        }

        private void Button_Equipes(object sender, RoutedEventArgs e)
        {
            EquipesAdm x = new EquipesAdm();
            Close();
            x.Show();
        }

        private void Button_Presidentes(object sender, RoutedEventArgs e)
        {
            InserirPresidente x = new InserirPresidente();
            Close();
            x.Show();
        }

        private void Button_Jog(object sender, RoutedEventArgs e)
        {
            JogadorAdm x = new JogadorAdm();
            Close();
            x.Show();
        }
    }
}
