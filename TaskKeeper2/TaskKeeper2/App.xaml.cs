using System;
using System.IO;
using TaskKeeper2.Data;
using TaskKeeper2.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskKeeper2
{
    public partial class App : Application
    {
        static TaskDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new AllTasks();
        }
        public static TaskDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TaskDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TaskSQLite.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
