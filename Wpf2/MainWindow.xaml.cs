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

namespace Wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        public MainWindow()
        {
            controller = Controller.GetInstance();
            InitializeComponent();
        }

        private void UpdateWindow() {
            PersonCount.Content = controller.PersonCount;
            Index.Content = controller.PersonIndex;
            textBoxFirstName.Text = controller.GetFirstname();
            textBoxLastName.Text = controller.GetLastName();
            textBoxAge.Text = controller.GetAge();
            textBoxTelephone.Text = controller.GetTelephone();
        }

        private void buttonNew_Click(object sender, RoutedEventArgs e) 
        {
            Window1 win1 = new Window1();
            win1.Show();
            this.Close();
        }
        

        private void buttonDelete_Click(object sender, RoutedEventArgs e) {
            Window3 win3 = new Window3();
            win3.Show();
            this.Close();
        }

        private void buttonUp_Click(object sender, RoutedEventArgs e) {
            controller.PrevPerson();
            UpdateWindow();
        }

        private void buttonDown_Click(object sender, RoutedEventArgs e) {
            controller.NextPerson();
            UpdateWindow();
        }
    }
}
