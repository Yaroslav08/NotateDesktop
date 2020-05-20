using NotateDesktop.ViewModels.Windows;
using NotateDesktop.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
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
            gridResult.Children.Clear();
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Effect = new BlurEffect();
            HelpWindow help = new HelpWindow();
            help.content.Children.Add(new Setting());
            var res = help.ShowDialog();
            if (!Convert.ToBoolean(res))
                this.Effect = null;
        }
    }
}
