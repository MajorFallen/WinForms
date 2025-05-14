﻿using Potter.API;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiNIPotter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new BooksViewModel(new BooksRepository());
        }

        private async void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BooksViewModel vm)
            {
                await vm.LoadBooksAsync();
            }
        }
    }
}