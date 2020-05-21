using NotateDesktop.Views.Windows;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for Setting.xaml
    /// </summary>
    public partial class Setting : UserControl
    {
        private HelpWindow hw;
        public Setting()
        {
            InitializeComponent();
            hw = new HelpWindow();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            hw.Close();
        }
    }
}
