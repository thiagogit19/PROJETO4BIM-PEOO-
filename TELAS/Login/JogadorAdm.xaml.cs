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
    /// Lógica interna para JogadorAdm.xaml
    /// </summary>
    public partial class JogadorAdm : Window
    {
        public JogadorAdm()
        {
            InitializeComponent();
        }

        ModJogador j;

        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuAdiminstrador x = new MenuAdiminstrador();
            Close();
            x.Show();
        }

        private void Button_Inserir(object sender, RoutedEventArgs e)
        {
            j = new ModJogador(nometxt, emailtxt, fonetxt, nasctxt, numcatxt, posicaotxt, );

        }
    }
}
