using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskKeeper2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskKeeper2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReadTask : ContentPage
    {
        public ReadTask()
        {
            InitializeComponent();
        }
        async private void GoBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        async private void Update_Clicked(object sender, EventArgs e)
        {
            //parse ID from page, and get the relevant task.
            int taskId = int.Parse(Id.Text);

            var task = await App.Database.GetTaskAsync(taskId);
            if (task == null)
            {
                return;
            }
            // Update Task
            task.Complete = Complete.IsToggled;
            await App.Database.SaveOrUpdateTaskAsync(task);

            // Pop window, and go to previous.
            await Navigation.PopModalAsync();
        }
        async private void Delete_Clicked(object sender, EventArgs e)
        {
            //parse ID from page, and get the relevant task.
            int taskId = int.Parse(Id.Text);

            var task = await App.Database.GetTaskAsync(taskId);
            if (task == null)
            {
                return;
            }

            // Delete Task
            await App.Database.DeleteTaskAsync(task);

            // Pop window, and go to previous.
            await Navigation.PopModalAsync();
        }
    }
}