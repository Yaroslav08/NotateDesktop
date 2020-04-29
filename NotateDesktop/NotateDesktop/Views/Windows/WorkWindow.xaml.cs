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
using System.Windows.Media.Effects;
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

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnMenuOpen_Click(object sender, RoutedEventArgs e)
        {
            gridMenu.Margin = new Thickness(0, 0, 0, 0);
        }

        private void btnMenuClose_Click(object sender, RoutedEventArgs e)
        {
            gridMenu.Margin = new Thickness(-250, 0, 0, 0);
        }
    }
}
