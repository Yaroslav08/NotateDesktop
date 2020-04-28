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
        public MainWindowViewModel() { login = "yaroslav@gmail.com";password = "Yarik08"; }

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
                    await client.AuthAsync(login, password);
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