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

namespace Client
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

        Conector connector = new Conector();
        string name;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            name = textBox2.Text;
            if (textBox2.Text == null)
            {
                global::System.Windows.MessageBox.Show("Please enter your nick  name");
            }
            else
            {

                if (textBox1 == null)
                {
                    global::System.Windows.MessageBox.Show("no message entered");
                }
                else
                {
                    richTextBox1.AppendText(connector.sender(textBox1.Text, name));
                }

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
