using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DagZaf.ViewModel;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using DagZaf.Views.ViewRestaurante;


namespace DagZaf.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        #region Attributes

        private string email;
        private string password;

        #endregion

        #region Properties

        public string EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string PasswordTxt
        { 
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        #endregion

        #region Commands

        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
            set
            {

            }
        }
        #endregion

        #region Methods

        private void Login()
        {
            if(EmailTxt.ToString() == "Email@gmail.com" && PasswordTxt.ToString() == "1234")
            {
                Application.Current.MainPage.DisplayAlert("Correcto", "Logrado", "ok");

            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Incorrecto", "No fue logrado", "ok");
            }
        }

        #endregion

        #region Constructor

        #endregion
    }
}
