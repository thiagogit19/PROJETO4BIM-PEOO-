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
//using Persistência;


namespace Login
{
    /// <summary>
    /// Lógica interna para TorneioMostrar.xaml
    /// </summary>
    public partial class TorneioMostrar : Window
    {
        ModAdm a;
        ModPresidente p;
        ModTorneio z;

        public TorneioMostrar()
        {
            InitializeComponent();
            a = new ModAdm();
            admtxt.Text = a.Nome;
            z = new ModTorneio();
            paistxt.Text = z.Pais;
            temptxt.Text = z.Temporada;

            NegEquipe n = new NegEquipe();
            numctxt.Text = n.RetMax().ToString();
        }
        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuPresidente x = new MenuPresidente(p);
            Close();
            x.Show();
        }
    }
}
