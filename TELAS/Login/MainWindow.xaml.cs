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
using Modelo;
using NAdministrador;

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

        public string Usuario { get => usuariotxt.Text; }
        public string Senha { get => txtSenha.Password; }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            ModUsuario m = new ModUsuario();
            m.Email = usuariotxt.Text;
            m.Senha = txtSenha.Password;
            NegUsuario n = new NegUsuario();
            m = n.VerificarSenha(m.Email, m.Senha);

            if (usuariotxt.Text == "mavmtx" && txtSenha.Password == "12345") // Adm
            {
                MessageBox.Show("Login efetuado com sucesso");
                MenuAdiminstrador x = new MenuAdiminstrador();
                Close();
                x.Show();
            } else
            if (m != null)
            {
                if (m is ModAdm) // Adm
                {
                    MessageBox.Show("Login efetuado com sucesso");
                    MenuAdiminstrador x = new MenuAdiminstrador();
                    Close();
                    x.Show();
                }

                else if (m is ModJogador) // jog
                {
                    MessageBox.Show("Login efetuado com sucesso");
                    MenuJogador x = new MenuJogador(m);
                    PerfilJogador p = new PerfilJogador(m);
                    Close();
                    x.Show();
                }

                else if (m is ModPresidente) // pre
                {
                    MessageBox.Show("Login efetuado com sucesso");
                    MenuPresidente x = new MenuPresidente(m);
                    PerfilPresidente p = new PerfilPresidente(m);
                    Close();
                    x.Show();
                }

            }

            else
            {
                MessageBox.Show("Usuário ou senha invalidados");
            }   
        }
    }
}
