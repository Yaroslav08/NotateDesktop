using NotateDesktop.Models;
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
        private List<NoteViewModel> noteViews = new List<NoteViewModel>
        {
            new NoteViewModel { Date = "20.05.2020", Header = "My first note in this system", Text = "erthyujgerst5yujgfbdser4t5yu6kjghfdsew3r4t5yujfgdsdwe3r4" },
            new NoteViewModel { Date = "21.05.2020", Header = "Second note in this system", Text = ":)" },
            new NoteViewModel { Date = "21.05.2020", Header = "Second note in this system", Text = "rejifoerkopaeisugresithureosseiaojguiserohgosruighvnsemoveiosvmesgresuigevmsgreuhimui" }
        };
        public WorkWindow()
        {
            InitializeComponent();
            this.DataContext = new WorkWindowViewModel();
            gridResult.Children.Clear();
            gridResult.Children.Add(new MyNotes(noteViews));
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Effect = new BlurEffect();
            HelpWindow help = new HelpWindow();
            help.content.Children.Add(new FindUser());
            var res = help.ShowDialog();
            if (!Convert.ToBoolean(res))
                this.Effect = null;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Effect = new BlurEffect();
            HelpWindow help = new HelpWindow();
            help.content.Children.Add(new CreateNote());
            var res = help.ShowDialog();
            if (!Convert.ToBoolean(res))
                this.Effect = null;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                gridResult.Children.Clear();
                gridResult.Children.Add(new MyNotes(noteViews));
            }
        }
    }
}
