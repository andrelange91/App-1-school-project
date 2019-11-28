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
    public partial class AddTask : ContentPage
    {
        public AddTask()
        {
            InitializeComponent();

        }
        async private void GoBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        async private void Save_Clicked(object sender, EventArgs e)
        {
            var taskItem = new TaskItemModel()
            {
                Heading = Heading.Text,
                Text = Text.Text,
                Complete = Complete.IsToggled,
            };

            await App.Database.SaveOrUpdateTaskAsync(taskItem);

            await Navigation.PopModalAsync();
        }
    }
}