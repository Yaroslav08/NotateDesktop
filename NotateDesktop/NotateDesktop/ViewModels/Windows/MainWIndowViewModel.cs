using DevExpress.Mvvm;
using NotateAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace NotateDesktop.ViewModels.Windows
{
    public class MainWindowViewModel
    {
        private NotateClient client = NotateClient.Instance();
        private string login;
        private string password;
        public MainWindowViewModel() { }

        public string LogIn
        {
            get => login;
            set
            {
                if (value.Length > 10)
                {
                    login = value;
                    OnPropertyChanged("LogIn");
                }
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (value.Length > 4 && value.Length < 24)
                {
                    password = value; 
                    OnPropertyChanged("Password");
                }
            }
        }

        public ICommand Close
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Application.Current.Shutdown();
                });
            }
        }

        public ICommand MaxStn
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (Application.Current.MainWindow.WindowState == WindowState.Normal)
                    {
                        Application.Current.MainWindow.WindowState = WindowState.Maximized;
                        return;
                    }
                    if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                    {
                        Application.Current.MainWindow.WindowState = WindowState.Normal;
                        return;
                    }
                });
            }
        }

        public ICommand Hide
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Application.Current.MainWindow.WindowState = WindowState.Minimized;
                });
            }
        }

        public ICommand Login
        {
            get
            {
                return new DelegateCommand(async() =>
                {
                    try
                    {
                        await client.AuthAsync(login, password);
                        if (client.IsAuthorize) MessageBox.Show("Success", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                        else MessageBox.Show("Fuck", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch(Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
                });
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}