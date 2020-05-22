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
            new NoteViewModel { Date = "20.05.2020", Header = "First note", Text = "This note is a first note in this system now" },
            new NoteViewModel { Date = "21.05.2020", Header = "Second note", Text = "This is note created for view in common access" },
            new NoteViewModel { Date = "22.05.2020", Header = "Private note", Text = "I hate German Viktorovich and them faculty" }
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
            help.Height = 310;
            help.Width = 300;
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
                gridHelp2.Children.Clear();
                gridHelp2.Children.Add(new ListNotes(noteViews));
            }
        }
    }
}
