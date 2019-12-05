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
using Microsoft.Win32;
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
        private void SelectClick(object sender, RoutedEventArgs e)
        {
            NegPresidente m = new NegPresidente();
            listapre.ItemsSource = null;
            listapre.ItemsSource = m.SelectPresidente();
        }

        private void Insert_Presidente(object sender, RoutedEventArgs e)
        {
            if(senha.Password == confsenha.Password)
            {
                ModPresidente x = new ModPresidente();
                x.Nome = nomepretxt.Text;
                x.Email = emailpretxt.Text;
                x.Fone = fonepretxt.Text;
                x.Senha = senha.Password;
                x.Nascimento = DateTime.Parse(nascpretxt.Text);
                NegPresidente y = new NegPresidente();
                y.InsertPresidente(x);
                nomepretxt.Text = "";
                emailpretxt.Text = "";
                fonepretxt.Text = "";
                senha.Password = "";
                confsenha.Password = "";
                foto = string.Empty;
                idpretxt.Text = "";
                nascpretxt.Text = "";
                NegUsuario Nu = new NegUsuario();
                Nu.InsertUsuario(x);

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

        private void Button_Listar(object sender, RoutedEventArgs e)
        {
            NegPresidente x = new NegPresidente();
            listapre.ItemsSource = null;
            listapre.ItemsSource = x.SelectPresidente();
        }

        private void Button_Atualizar(object sender, RoutedEventArgs e)
        {
            ModPresidente x = new ModPresidente();
            x.Id = int.Parse(idpretxt2.Text);
            x.Nome = nomepretxt.Text;
            x.Fone = fonepretxt.Text;
            x.Email = emailpretxt.Text;
            x.Nascimento = DateTime.Parse(nascpretxt.Text);

            NegPresidente n = new NegPresidente();
            n.UpdatePresidente(x);

            nomepretxt.Text = "";
            emailpretxt.Text = "";
            fonepretxt.Text = "";
            senha.Password = "";
            confsenha.Password = "";
            foto = string.Empty;
            idpretxt.Text = "";
            nascpretxt.Text = "";

            SelectClick(sender, e);
        }

        private void Button_Deletar(object sender, RoutedEventArgs e)
        {
            ModPresidente c = new ModPresidente();
            c.Id = int.Parse(idpretxt.Text);
            NegPresidente n = new NegPresidente();
            n.DeletePresidente(c);
            listapre.ItemsSource = null;
            listapre.ItemsSource = n.SelectPresidente();

            nomepretxt.Text = "";
            emailpretxt.Text = "";
            fonepretxt.Text = "";
            senha.Password = "";
            confsenha.Password = "";
            foto = string.Empty;
            idpretxt.Text = "";
            nascpretxt.Text = "";
        }

    }
}
