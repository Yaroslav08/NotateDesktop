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
    public class ConfirmViewModel
    {
        public ConfirmViewModel() { }
        public ConfirmViewModel(string Login) { this.Login = Login; }
        private NotateClient client = NotateClient.Instance();
        private string login;
        private string code;

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
        public string Code
        {
            get => code;
            set
            {
                if (value != code)
                {
                    code = value;
                    OnPropertyChanged("Code");
                }
            }
        }

        public ICommand Confirm
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    await client.ConfirmAsync(new NotateAPI.Models.Helpers.UserService.ConfirmModel { Code = Code, Login = Login });
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
