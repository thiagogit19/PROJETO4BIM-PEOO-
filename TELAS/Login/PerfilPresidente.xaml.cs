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
    /// Lógica interna para PerfilPresidente.xaml
    /// </summary>
    public partial class PerfilPresidente : Window
    {
        ModPresidente p;
        public PerfilPresidente(ModUsuario m)
        {
            InitializeComponent();
            p = m as ModPresidente;
            nometxt.Text = p.Nome;
            fonetxt.Text = p.Fone;
            emailtxt.Text = p.Email;
            nasctxt.Text = p.Nascimento.ToString();
        }
        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuPresidente x = new MenuPresidente(p);
            Close();
            x.Show();
        }
    }
}
