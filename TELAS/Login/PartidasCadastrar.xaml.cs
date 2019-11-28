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
        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuAdiminstrador x = new MenuAdiminstrador();
            Close();
            x.Show();
        }

        private void Button_Inserir(object sender, RoutedEventArgs e)
        {
            ModJogo x = new ModJogo(int.Parse(id1txt.Text), int.Parse(id2txt.Text), 123, int.Parse(gol1txt.Text), int.Parse(gol2txt.Text), localtxt.Text);
            NegPartidas y = new NegPartidas();
            y.InsertPartida(x);
        }

        private void Button_Atualizar(object sender, RoutedEventArgs e)
        {
            NegPartidas y = new NegPartidas();
            listarpartidas.ItemsSource = y.SelectPartida();
            ModJogo x = new ModJogo(int.Parse(id1txt.Text), int.Parse(id2txt.Text), 123, int.Parse(gol1txt.Text), int.Parse(gol2txt.Text), localtxt.Text);
            y.UpdatePartida(x);
        }

        private void Button_Listar(object sender, RoutedEventArgs e)
        {
            NegPartidas y = new NegPartidas();
            listarpartidas.ItemsSource = y.SelectPartida();
        }

        private void Button_Deletar(object sender, RoutedEventArgs e)
        {
            ModJogo x = new ModJogo(int.Parse(id1txt.Text), int.Parse(id2txt.Text), 123, int.Parse(gol1txt.Text), int.Parse(gol2txt.Text), localtxt.Text);
            NegPartidas y = new NegPartidas();
            y.DeletePartida(x);
        }
    }
}
