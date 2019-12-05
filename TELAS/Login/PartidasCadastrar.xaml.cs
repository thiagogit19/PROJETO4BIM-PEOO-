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
    /// Lógica interna para PartidasCadastrar.xaml
    /// </summary>
    public partial class PartidasCadastrar : Window
    {
        public PartidasCadastrar()
        {
            InitializeComponent();
            NegEquipe e = new NegEquipe();
            listarequipes.ItemsSource = e.SelectEquipe();
        }
        private void SelectClick(object sender, RoutedEventArgs e)
        {
            NegPartidas m = new NegPartidas();
            listarpartidas.ItemsSource = null;
            listarpartidas.ItemsSource = m.SelectPartida();
        }
        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuAdiminstrador x = new MenuAdiminstrador();
            Close();
            x.Show();
        }

        private void Button_Inserir(object sender, RoutedEventArgs e)
        {
            ModJogo x = new ModJogo();
            NegEquipe eq = new NegEquipe();
            

            x.Gol1 = int.Parse(gol1txt.Text);
            x.Gol2 = int.Parse(gol2txt.Text);
            x.Local = localtxt.Text;

            NegPartidas y = new NegPartidas();
            y.InsertPartida(x);

            id1txt.Text = "";
            id2txt.Text = "";
            gol1txt.Text = "";
            gol2txt.Text = "";
            localtxt.Text = "";
        }

        private void Button_Listar(object sender, RoutedEventArgs e)
        {
            NegPartidas x = new NegPartidas();
            listarpartidas.ItemsSource = null;
            listarpartidas.ItemsSource = x.SelectPartida();
        }

        private void Button_Atualizar(object sender, RoutedEventArgs e)
        {
            ModJogo x = new ModJogo();
            x.IdEquipe1 = int.Parse(id1txt.Text);
            x.IdEquipe2 = int.Parse(id2txt.Text);
            x.Gol1 = int.Parse(gol1txt.Text);
            x.Gol2 = int.Parse(gol2txt.Text);
            x.Local = localtxt.Text;

            NegPartidas n = new NegPartidas();
            n.UpdatePartida(x);

            id1txt.Text = "";
            id2txt.Text = "";
            gol1txt.Text = "";
            gol2txt.Text = "";
            localtxt.Text = "";
            SelectClick(sender, e);
        }

        private void Button_Deletar(object sender, RoutedEventArgs e)
        {
            ModJogo c = new ModJogo();
            c.IdPartida = int.Parse(idpartxt.Text);
            NegPartidas n = new NegPartidas();
            n.DeletePartida(c);
            listarpartidas.ItemsSource = null;
            listarpartidas.ItemsSource = n.SelectPartida();

            id1txt.Text = "";
            id2txt.Text = "";
            gol1txt.Text = "";
            gol2txt.Text = "";
            localtxt.Text = "";
            
        }

    }
}
