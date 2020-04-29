using DevExpress.Mvvm;
using NotateAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace NotateDesktop.ViewModels.UserControls
{
    public class RegisterViewModel
    {
        public RegisterViewModel() { }
        private NotateClient client = NotateClient.Instance();
        private string fullname;
        private string login;
        private string password;

        public string Fullname
        {
            get => fullname;
            set
            {
                if (value != fullname)
                {
                    fullname = value;
                    OnPropertyChanged("Fullname");
                }
            }
        }
        public string Login
        {
            get => login;
            set
            {
                if (value != login)
                {
                    login = value;
                    OnPropertyChanged("Login");
                }
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value != password)
                {
                    password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public ICommand Register
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    var res = await client.RegisterAsync(fullname, login, password);
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
