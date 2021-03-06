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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KCKBank
{
    /// <summary>
    /// Interaction logic for Credits.xaml
    /// </summary>
    public partial class Credits : UserControl
    {
        public Credits()
        {
            InitializeComponent();
        }
        private void GoToInsurance(object sender, RoutedEventArgs e)
        {
            MainWindow.mainPanel.Children.Clear();
            MainWindow.mainPanel.Children.Add(new Insurance());
        }


        private void MainPage2(object sender, RoutedEventArgs e)
        {
            MainWindow.mainPanel.Children.Clear();
            MainWindow.mainPanel.Children.Add(new MainPage());
        }

        private void Accounts(object sender, RoutedEventArgs e)
        {
            MainWindow.mainPanel.Children.Clear();
            MainWindow.mainPanel.Children.Add(new Accounts());
        }

        private void Cards(object sender, RoutedEventArgs e)
        {
            MainWindow.mainPanel.Children.Clear();
            MainWindow.mainPanel.Children.Add(new Cards());
        }

        private void Transfers(object sender, RoutedEventArgs e)
        {
            MainWindow.mainPanel.Children.Clear();
            MainWindow.mainPanel.Children.Add(new Transfers());
        }

        private void GetCredit(object sender, RoutedEventArgs e)
        {
            MainWindow.mainPanel.Children.Clear();
            MainWindow.mainPanel.Children.Add(new GetCredit());
        }
    }
}
