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
    /// Interaction logic for Transfers2.xaml
    /// </summary>
    public partial class Transfers2 : UserControl
    {
        public Transfers2()
        {
            InitializeComponent();
        }

        private void GoToInsurance(object sender, RoutedEventArgs e)
        {
            MainWindow.mainPanel.Children.Clear();
            MainWindow.mainPanel.Children.Add(new Insurance());
        }

        private void Credits(object sender, RoutedEventArgs e)
        {
            MainWindow.mainPanel.Children.Clear();
            MainWindow.mainPanel.Children.Add(new Credits());
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

        private void Transfers3(object sender, RoutedEventArgs e)
        {
            MainWindow.mainPanel.Children.Clear();
            MainWindow.mainPanel.Children.Add(new Transfers3());
        }
    }
}
