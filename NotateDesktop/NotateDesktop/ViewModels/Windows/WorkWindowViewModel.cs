using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace NotateDesktop.ViewModels.Windows
{
    public class WorkWindowViewModel
    {
        public WorkWindowViewModel() { }



        public ICommand CloseWindow
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Application.Current.Shutdown();
                });
            }
        }

        public ICommand HideWindow
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Application.Current.MainWindow.WindowState = WindowState.Minimized;
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
                    if(Application.Current.MainWindow.WindowState == WindowState.Maximized)
                    {
                        Application.Current.MainWindow.WindowState = WindowState.Normal;
                        return;
                    }
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
