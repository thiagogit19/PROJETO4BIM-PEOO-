﻿using System;
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
using NAdministrador;

namespace Login
{
    /// <summary>
    /// Lógica interna para PartidasMostrar.xaml
    /// </summary>
    public partial class PartidasMostrar : Window
    {
        public PartidasMostrar()
        {
            InitializeComponent();
            NegPartidas p = new NegPartidas();
            grid.ItemsSource = null;
            grid.ItemsSource = p.SelectPartida();
            
        }
        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
