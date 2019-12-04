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
        int m = 0;
        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuAdiminstrador x = new MenuAdiminstrador();
            Close();
            x.Show();
        }

        private void Button_Inserir(object sender, RoutedEventArgs e)
        {
            if (m == 0)
            {
                ModTorneio x = new ModTorneio();
                x.Pais = paistxt.Text;
                x.Temporada = temporadatxt.Text;

                NegTorneio y = new NegTorneio();
                y.InsertTorneio(x);

                paistxt.Text = "";
                temporadatxt.Text = "";
                m++;
            }
            else
            {
                MessageBox.Show("Torneio ja cadastrado");
            }
        }
    }
}
