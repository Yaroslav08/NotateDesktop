using NotateDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for FindUser.xaml
    /// </summary>
    public partial class FindUser : UserControl
    {
        public FindUser()
        {
            InitializeComponent();
        }
        private ImageBrush br = new ImageBrush();

        private List<UserView> userViews = new List<UserView>
        {
            new UserView {Id=1, Name="Misha Brekhov", Source=new BitmapImage(new Uri(@"D:\Download\Photo_1.jpg")) },
            new UserView {Id=2, Name="Yaroslav Mudryk", Source=new BitmapImage(new Uri(@"D:\Download\Photo.jpg"))},
            new UserView {Id=1, Name="Misha Brekhov", Source=new BitmapImage(new Uri(@"D:\Download\Photo_1.jpg")) },
            new UserView {Id=1, Name="Misha Brekhov", Source=new BitmapImage(new Uri(@"D:\Download\Photo_1.jpg")) },
            new UserView {Id=1, Name="Misha Brekhov", Source=new BitmapImage(new Uri(@"D:\Download\Photo_1.jpg")) },
            new UserView {Id=1, Name="Misha Brekhov", Source=new BitmapImage(new Uri(@"D:\Download\Photo_1.jpg")) },
        };

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                users.Children.Clear();
                users.Children.Add(new UsersResult(userViews.Where(d => d.Name.Contains(tbSearch.Text)).ToList()));
            }
        }
    }
}
