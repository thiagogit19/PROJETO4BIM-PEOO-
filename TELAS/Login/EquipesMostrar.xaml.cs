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

namespace Login
{
    /// <summary>
    /// Lógica interna para EquipesMostrar.xaml
    /// </summary>
    public partial class EquipesMostrar : Window
    {
        public EquipesMostrar()
        {
            InitializeComponent();
        }

        private void Button_Voltar(object sender, RoutedEventArgs e)
        {
            MenuPresidente x = new MenuPresidente();
            Close();
            x.Show();
        }
    }
}
