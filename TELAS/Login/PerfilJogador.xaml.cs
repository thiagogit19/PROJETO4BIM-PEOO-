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
    /// Lógica interna para PerfilJogador.xaml
    /// </summary>
    public partial class PerfilJogador : Window
    {
        ModJogador j;
        public PerfilJogador(ModUsuario m)
        {
            InitializeComponent();
            j = m as ModJogador;
            nomejog.Text = j.Nome;
            emailjog.Text = j.Email;
            fonejog.Text = j.Fone;
            nascjog.Text = j.Nascimento.ToString();
            //apeljog.Text = j.Apelido;
            numcjog.Text = j.NumCamisa.ToString();
            posjog.Text = j.Posicao;
        }
        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
