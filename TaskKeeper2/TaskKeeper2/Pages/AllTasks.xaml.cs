using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskKeeper2.Helpers;
using TaskKeeper2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskKeeper2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllTasks : ContentPage
    {
        public AllTasks()
        {
            InitializeComponent();
        }

        async private void AddTask_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddTask());
        }

        async private void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushModalAsync(new ReadTask
                {
                    BindingContext = e.SelectedItem as TaskItemModel
                });
            }
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Get all Tasks from DB and assign to the ListView
            TaskList.ItemsSource = await App.Database.GetAllAsync(); 
        }
    }
}