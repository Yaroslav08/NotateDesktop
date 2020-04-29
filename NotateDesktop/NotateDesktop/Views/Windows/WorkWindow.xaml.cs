using NotateDesktop.ViewModels.Windows;
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
using System.Windows.Shapes;

namespace NotateDesktop.Views.Windows
{
    /// <summary>
    /// Interaction logic for WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        public WorkWindow()
        {
            InitializeComponent();
            this.DataContext = new WorkWindowViewModel();
        }
    }
}
