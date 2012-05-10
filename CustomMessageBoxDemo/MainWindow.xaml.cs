﻿using System;
using System.Collections.Generic;
using System.Linq;
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
using WPFCustomMessageBox;

namespace CustomMessageBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void button_StandardMessage_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!\nHello World\nHello World!\nHello World\nHello World!\nHello World\nHello World!\nHello World\nHello World!\nHello World\nHello World!\nHello World\n");
        }

        private void button_StandardMessageNew_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBox.Show("Hello World!\nHello World\nHello World!\nHello World\nHello World!\nHello World\nHello World!\nHello World\nHello World!\nHello World\nHello World!\nHello World\n");
        }

        private void button_MessageWithCaption_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!", "Hello World the title.");
        }

        private void button_MessageWithCaptionNew_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBox.Show("Hello world!", "Hello World the title.");
        }

        private void button_MessageWithCaptionAndButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!", "Hello World the title.", MessageBoxButton.OKCancel);
        }

        private void button_MessageWithCaptionAndButtonNew_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBox.Show("Hello World!", "Hello World the title.", MessageBoxButton.OKCancel);
        }

        private void button_MessageWithCaptionButtonImage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_MessageWithCaptionButtonImageNew_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBox.ShowYesNo("Hi", "bye", "hello", "goodbye", MessageBoxImage.Asterisk);
        }
    }
}
