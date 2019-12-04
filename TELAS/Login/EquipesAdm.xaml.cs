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
    /// Lógica interna para EquipesAdm.xaml
    /// </summary>
    public partial class EquipesAdm : Window
    {
        public EquipesAdm()
        {
            InitializeComponent();
        }

        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuAdiminstrador x = new MenuAdiminstrador();
            Close();
            x.Show();
        }

        private void SelectClick(object sender, RoutedEventArgs e)
        {
            NegEquipe m = new NegEquipe();
            listae.ItemsSource = null;
            listae.ItemsSource = m.SelectEquipe();
        }

        private void Button_Inserir(object sender, RoutedEventArgs e)
        {
            ModEquipe x = new ModEquipe();
            x.Nome = nometxt.Text;
            x.Origem = origemtxt.Text;
            x.Fundacao = DateTime.Parse(fundacaotxt.Text);
            NegEquipe y = new NegEquipe();
            y.InsertEquipe(x);
            nometxt.Text = "";
            origemtxt.Text = "";
            idpretxt.Text = "";
            fundacaotxt.Text = "";
        }

        private void Button_Listar(object sender, RoutedEventArgs e)
        {
            NegEquipe m = new NegEquipe();
            listae.ItemsSource = null;
            listae.ItemsSource = m.SelectEquipe();
        }

        private void Button_Atualizar(object sender, RoutedEventArgs e)
        {
            ModEquipe x = new ModEquipe();
            x.Id = int.Parse(idpretxt2.Text);
            x.Nome = nometxt.Text;
            x.Origem = origemtxt.Text;
            x.Fundacao= DateTime.Parse(fundacaotxt.Text);

            NegEquipe n = new NegEquipe();
            n.UpdateEquipe(x);

            nometxt.Text = "";
            origemtxt.Text = "";
            idpretxt2.Text = "";
            fundacaotxt.Text = "";

            SelectClick(sender, e);
        }

        private void Button_Deletar(object sender, RoutedEventArgs e)
        {
            ModEquipe c = new ModEquipe();
            c.Id = int.Parse(idpretxt.Text);
            NegEquipe n = new NegEquipe();
            n.DeleteEquipe(c);
            listae.ItemsSource = null;
            listae.ItemsSource = n.SelectEquipe();

            nometxt.Text = "";
            origemtxt.Text = "";
            idpretxt.Text = "";
            fundacaotxt.Text = "";
        }
    }
}
