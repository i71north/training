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

namespace wpfPractice1
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

        private void Action_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("How are you today?");
            string words = txtBox1.Text;
            //txtBox1.Text = "Yeah!";

            lblText.Content = words;



        }

        private void txtBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSecond_Click(object sender, RoutedEventArgs e)
        {
            second sec = new second();
            sec.ShowDialog();
        }
    
        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            winThree trey = new winThree();
            trey.ShowDialog();
        }
    }
}
