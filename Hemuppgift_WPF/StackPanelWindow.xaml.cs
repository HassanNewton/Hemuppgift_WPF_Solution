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

namespace Hemuppgift_WPF
{
    /// <summary>
    /// Interaction logic for StackPanelWindow.xaml
    /// </summary>
    public partial class StackPanelWindow : Window
    {
        public StackPanelWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).Content.ToString() == "Horizontal")
            {
                MainWrapPanel.Orientation = Orientation.Horizontal;
            }
            else
            {
                MainWrapPanel.Orientation = Orientation.Vertical;
            }
        }
    }
}
