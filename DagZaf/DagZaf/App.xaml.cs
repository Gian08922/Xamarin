using DagZaf.View.ViewAcceso;
using DagZaf.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DagZaf.Model;
using SQLite;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace DagZaf
{
    public partial class App : Application
    {
        static DatabaseQuery database;
        public static DatabaseQuery Database
        {
            get
            {
                if(database == null)
                {
                    database = new DatabaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TestName.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new StartPage());
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {
        }
    }
}
