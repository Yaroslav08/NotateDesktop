using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace NotateDesktop.ViewModels.Windows
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel() { }

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
    }
}