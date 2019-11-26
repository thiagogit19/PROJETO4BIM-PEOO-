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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string Usuario { get => txtNome.Text; }
        public string Senha { get => txtSenha.Password; }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text == "Adm" && txtSenha.Password == "1234")
            {
                MessageBox.Show("Login efetuado com sucesso");
                MenuAdiminstrador x = new MenuAdiminstrador();
                Close();
                x.Show();
            }
            else if (txtNome.Text == "Jog" && txtSenha.Password == "4321")
            {
                MessageBox.Show("Login efetuado com sucesso");
                MenuJogador x = new MenuJogador();
                Close();
                x.Show();
            }
            else if (txtNome.Text == "Pre" && txtSenha.Password == "2314")
            {
                MessageBox.Show("Login efetuado com sucesso");
                MenuPresidente x = new MenuPresidente();
                Close();
                x.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalidados");
            }
        }
    }
}
