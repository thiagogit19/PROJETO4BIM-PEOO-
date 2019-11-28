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
    /// Lógica interna para PerfilAdministrador.xaml
    /// </summary>
    public partial class PerfilAdministrador : Window
    {

        private string foto = string.Empty;

        public PerfilAdministrador()
        {
            InitializeComponent();
            ModAdm x = new ModAdm("Carlos", "Carlos@email.com", "87432164", "cara.jpeg", 123, DateTime.Parse("01/01/1997"));
            nomeadmtxt.Text = x.GetNome().ToString();
            emailadmtxt.Text = x.GetEmail().ToString();
            foneadmtxt.Text = x.GetFone().ToString();
            foto = x.GetFoto();
            idadmtxt.Text = x.GetId().ToString();
            nascadmtxt.Text = x.GetNascimento().ToString();
        }

        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuAdiminstrador x = new MenuAdiminstrador();
            Close();
            x.Show();
            
        }
    }
}
