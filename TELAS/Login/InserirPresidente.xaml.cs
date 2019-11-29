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
    /// Lógica interna para InserirPresidente.xaml
    /// </summary>
    public partial class InserirPresidente : Window
    {
        public InserirPresidente()
        {
            InitializeComponent();
        }
        private string foto = string.Empty;

        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuAdiminstrador x = new MenuAdiminstrador();
            Close();
            x.Show();
        }

        private void Insert_Presidente(object sender, RoutedEventArgs e)
        {
            ModPresidente x = new ModPresidente(nomepretxt.Text, emailpretxt.Text, fonepretxt.Text, foto, int.Parse(idpretxt.Text), DateTime.Parse(nascpretxt.Text));

        }
    }
}
