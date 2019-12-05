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
        ModAdm a;
        ModPresidente p;
        ModTorneio z;

        public TorneioAdm()
        {
            InitializeComponent();
            z = new ModTorneio();
            paistxt.Text = z.Pais;
            temporadatxt.Text = z.Temporada;
        }

        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuAdiminstrador x = new MenuAdiminstrador();
            Close();
            x.Show();
        }
    }
}
