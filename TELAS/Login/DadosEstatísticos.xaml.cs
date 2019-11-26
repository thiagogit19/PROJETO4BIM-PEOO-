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
    /// Lógica interna para DadosEstatísticos.xaml
    /// </summary>
    public partial class DadosEstatísticos : Window
    {
        public DadosEstatísticos()
        {
            InitializeComponent();
        }

        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuJogador j = new MenuJogador();
            MenuAdiminstrador a = new MenuAdiminstrador();
            MenuPresidente p = new MenuPresidente();
            if (j.jog == true)
            {
                Close();
                j.Show();
                j.jog = false;
            }
            else if (a.adm == true)
            {
                Close();
                a.Show();
                a.adm = false;
            }
            else if (p.pre == true)
            {
                Close();
                p.Show();
                p.pre = false;
            }
        }
    }
}
