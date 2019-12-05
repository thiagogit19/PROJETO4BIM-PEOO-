using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica interna para JogadorAdm.xaml
    /// </summary>
    public partial class JogadorAdm : Window
    {
        public JogadorAdm()
        {
            InitializeComponent();
            NegEquipe n = new NegEquipe();
            list.ItemsSource = null;
            list.ItemsSource = n.SelectEquipe();
        }

        private string foto = string.Empty;

        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuAdiminstrador x = new MenuAdiminstrador();
            Close();
            x.Show();
        }

        private void Button_Inserir(object sender, RoutedEventArgs e)
        {
            if (senhatxt.Password == confsenhatxt.Password)
            {
                ModJogador x = new ModJogador();
                x.Nome = nometxt.Text;
                x.Email = emailtxt.Text;
                x.Fone = fonetxt.Text;
                x.Senha = senhatxt.Password;
                x.Nascimento = DateTime.Parse(nasctxt.Text);
                x.NumCamisa = int.Parse(numcatxt.Text);
                x.IdEquipe = int.Parse(idtimetxt.Text);
                x.Posicao = posicaotxt.Text;
                NegJogador y = new NegJogador();
                y.InsertJogador(x);
                nometxt.Text = "";
                emailtxt.Text = "";
                fonetxt.Text = "";
                senhatxt.Password = "";
                posicaotxt.Text = "";
                numcatxt.Text = "";
                confsenhatxt.Password = "";
                foto = string.Empty;
                idtimetxt.Text = "";
                nasctxt.Text = "";
            }
            else
            {
                MessageBox.Show("Senhas diferentes");
            }
        }



        private void FotoClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog w = new OpenFileDialog();
            w.Filter = "Arquivos Jpg|*.jpg";
            if (w.ShowDialog().Value)
            {
                byte[] b = File.ReadAllBytes(w.FileName);
                foto = Convert.ToBase64String(b);

                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(b);
                bi.EndInit();

                image.Source = bi;
            }
        }

        private void Button_SelectClick(object sender, RoutedEventArgs e)
        {
            NegJogador m = new NegJogador();
            listapre.ItemsSource = null;
            listapre.ItemsSource = m.SelectJogador();
        }

        private void Button_Deletar(object sender, RoutedEventArgs e)
        {
            ModJogador c = new ModJogador();
            c.Id = int.Parse(idjogtxt.Text);
            NegJogador n = new NegJogador();
            n.DeleteJogador(c);
            listapre.ItemsSource = null;
            listapre.ItemsSource = n.SelectJogador();

            nometxt.Text = "";
            emailtxt.Text = "";
            fonetxt.Text = "";
            senhatxt.Password = "";
            posicaotxt.Text = "";
            numcatxt.Text = "";
            confsenhatxt.Password = "";
            foto = string.Empty;
            idjogtxt.Text = "";
            nasctxt.Text = "";
        }

        private void Button_Atualizar(object sender, RoutedEventArgs e)
        {
            ModJogador x = new ModJogador();
            x.Id = int.Parse(idjogtxt2.Text);
            x.Nome = nometxt.Text;
            x.Fone = fonetxt.Text;
            x.Email = emailtxt.Text;
            x.NumCamisa = int.Parse(numcatxt.Text);
            x.Fone = fonetxt.Text;
            x.Nascimento = DateTime.Parse(nasctxt.Text);
            NegJogador n = new NegJogador();
            n.UpdateJogador(x);
            nometxt.Text = "";
            emailtxt.Text = "";
            fonetxt.Text = "";
            senhatxt.Password = "";
            posicaotxt.Text = "";
            numcatxt.Text = "";
            confsenhatxt.Password = "";
            foto = string.Empty;
            idjogtxt2.Text = "";
            nasctxt.Text = "";
        }
    }
}
