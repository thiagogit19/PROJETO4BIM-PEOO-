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
            ModAdm x = new ModAdm();
            NegUsuario y = new NegUsuario();
            y.InsertUsuario(x);
        }

        public string Usuario { get => usuariotxt.Text; }
        public string Senha { get => txtSenha.Password; }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            ModUsuario m = new ModUsuario();
            m.Email = usuariotxt.Text;
            m.Senha = txtSenha.Password;
            m.Operacao = int.Parse(op.Text);
            NegUsuario n = new NegUsuario();

            if (n.VerificarSenha(m.Email, m.Senha) == true)
            {
                if (m.Operacao == 1) // Adm
                {
                    MessageBox.Show("Login efetuado com sucesso");
                    MenuAdiminstrador x = new MenuAdiminstrador();
                    Close();
                    x.Show();
                }

                else if (m.Operacao == 2) // jog
                {
                    MessageBox.Show("Login efetuado com sucesso");
                    MenuJogador x = new MenuJogador();
                    Close();
                    x.Show();
                }

                else if (m.Operacao == 3) // pre
                {
                    MessageBox.Show("Login efetuado com sucesso");
                    MenuPresidente x = new MenuPresidente();
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
