﻿using NotateDesktop.ViewModels.UserControls;
using System;
using System.Collections.Generic;
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

namespace NotateDesktop.Views.UserControls
{
    /// <summary>
    /// Interaction logic for Confirm.xaml
    /// </summary>
    public partial class Confirm : UserControl
    {
        public Confirm()
        {
            InitializeComponent();
            this.DataContext = new ConfirmViewModel();
        }
    }
}
