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
using NAdministrador;

namespace Login
{
    /// <summary>
    /// Lógica interna para JogadorMostrarAtualizar.xaml
    /// </summary>
    public partial class JogadorMostrarAtualizar : Window
    {
        public JogadorMostrarAtualizar()
        {
            InitializeComponent();
            NegJogador m = new NegJogador();
            Listajogador.ItemsSource = null;
            Listajogador.ItemsSource = m.SelectJogador();
        }
        private void SelectClick(object sender, RoutedEventArgs e)
        {
            NegJogador m = new NegJogador();
            Listajogador.ItemsSource = null;
            Listajogador.ItemsSource = m.SelectJogador();
        }

        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Atualizar(object sender, RoutedEventArgs e)
        {
            ModJogador x = new ModJogador();
            x.Nome = nometxt.Text;
            x.Nascimento = DateTime.Parse(nasctxt.Text);
            x.Fone = fonetxt.Text;
            x.Posicao = posicaotxt.Text;
            x.NumCamisa = int.Parse(numcatxt.Text);
            x.Email = emailtxt.Text;
            x.Id = int.Parse(idjog.Text);

            NegJogador y = new NegJogador();
            y.UpdateJogador(x);

            nometxt.Text = "";
            emailtxt.Text = "";
            fonetxt.Text = "";
            idjog.Text = "";
            nasctxt.Text = "";
            posicaotxt.Text = "";
            numcatxt.Text = "";

            SelectClick(sender, e);

        }

        private void Button_Listar(object sender, RoutedEventArgs e)
        {
            NegJogador x = new NegJogador();
            Listajogador.ItemsSource = null;
            Listajogador.ItemsSource = x.SelectJogador();
        }
    }
}
