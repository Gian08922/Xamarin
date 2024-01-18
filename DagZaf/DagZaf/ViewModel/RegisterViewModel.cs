using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using DagZaf.Model;
using Xamarin.Forms;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace DagZaf.ViewModel
{
    public class RegisterViewModel : BaseViewModel
    {
        #region Attributes

        private string email;
        private string password;
        private string firstName;
        private string lastName;
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

        public string FirstNameTxt
        {
            get { return this.firstName; }
            set { SetValue(ref this.firstName, value); }
        }
        public string LastNameTxt
        {
            get { return this.lastName; }
            set { SetValue(ref this.lastName, value); }
        }



        #endregion

        #region Commands

        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(RegisterMethod);
            }
        }
        #endregion

        #region Methods

        private async void RegisterMethod()
        {
            if (string.IsNullOrEmpty(this.EmailTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Tiene que ser un email", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(this.PasswordTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Tiene que ser una contraseña", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(this.FirstNameTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Tiene que ser un nombre", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(this.LastNameTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Tiene que ser un apellido", "Ok");
                return;
            }

            var user = new User
            {
                Email = EmailTxt.ToLower(),
                Password = PasswordTxt.ToLower(),
                FirstName = FirstNameTxt.ToLower(),
                LastName = LastNameTxt.ToLower(),
                Creation_Date = DateTime.UtcNow.Date
            };

            await App.Database.SaveUserAsync(user);

        }

        #endregion

        #region Constructor

        #endregion
    }
}
