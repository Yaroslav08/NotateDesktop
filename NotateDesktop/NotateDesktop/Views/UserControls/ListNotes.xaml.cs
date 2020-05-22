using NotateDesktop.Models;
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
    /// Interaction logic for ListNotes.xaml
    /// </summary>
    public partial class ListNotes : UserControl
    {
        public ListNotes(List<NoteViewModel> notes)
        {
            InitializeComponent();
            lvMain.ItemsSource = notes;
        }
    }
}
