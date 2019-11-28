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
    /// Lógica interna para TorneioAdm.xaml
    /// </summary>
    public partial class TorneioAdm : Window
    {
        public TorneioAdm()
        {
            InitializeComponent();
        }
        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuAdiminstrador x = new MenuAdiminstrador();
            Close();
            x.Show();
        }

        private void Button_Inserir(object sender, RoutedEventArgs e)
        {
            ModAdm m = new ModAdm("Carlos", "Carlos@email.com", "87432164", "cara.jpeg", 123, DateTime.Parse("01/01/1997"));
            ModTorneio x = new ModTorneio(m.GetId(), 20, paistxt.Text, temporadatxt.Text);
            NegTorneio y = new NegTorneio();
            y.InsertTorneio(x);
        }
    }
}
