using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskKeeper2.Models;

namespace TaskKeeper2.Data
{
    public class DataStore
    {
        public ObservableCollection<TaskItemModel> TaskItems { get; private set; } // temp location for storing data.
        public DataStore()
        {
            this.TaskItems = new ObservableCollection<TaskItemModel>();
        }
        public IEnumerable<TaskItemModel> GetAll()
        {
            List<TaskItemModel> taskItemList = new List<TaskItemModel>();

            taskItemList.Add(new TaskItemModel()
            {
                Id = 1,
                Heading = "Make the Yuletide Gay",
                Text = "Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.\n\nCras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque.\n\nQuisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.",
                Complete = false
            });
            taskItemList.Add(new TaskItemModel()
            {
                Id = 2,
                Heading = "Little Princess, The",
                Text = "Phasellus in felis. Donec semper sapien a libero. Nam dui.\n\nProin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.\n\nInteger ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.",
                Complete = true
            });
            taskItemList.Add(new TaskItemModel()
            {
                Id = 3,
                Heading = "Infection (Kansen)",
                Text = "In congue. Etiam justo. Etiam pretium iaculis justo.",
                Complete = true
            });
            taskItemList.Add(new TaskItemModel()
            {
                Id = 4,
                Heading = "Val Lewton:  The Man in the Shadows",
                Text = "In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.",
                Complete = true
            });
            taskItemList.Add(new TaskItemModel()
            {
                Id = 5,
                Heading = "Carandiru",
                Text = "In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.\n\nNulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.",
                Complete = true
            });
            taskItemList.Add(new TaskItemModel()
            {
                Id = 6,
                Heading = "Meet the Deedles",
                Text = "Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem.\n\nFusce consequat. Nulla nisl. Nunc nisl.\n\nDuis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.",
                Complete = false
            });
            taskItemList.Add(new TaskItemModel()
            {
                Id = 7,
                Heading = "Tucker & Dale vs Evil",
                Text = "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.\n\nSed ante. Vivamus tortor. Duis mattis egestas metus.\n\nAenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.",
                Complete = false
            });
            taskItemList.Add(new TaskItemModel()
            {
                Id = 8,
                Heading = "Vizontele",
                Text = "In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.\n\nNulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.\n\nCras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque.",
                Complete = false
            });
            taskItemList.Add(new TaskItemModel()
            {
                Id = 9,
                Heading = "School For Scoundrels",
                Text = "Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.\n\nDuis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.",
                Complete = true
            });
            taskItemList.Add(new TaskItemModel()
            {
                Id = 10,
                Heading = "Nightmaster (Watch the Shadows Dance)",
                Text = "Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.\n\nDonec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.",
                Complete = true
            });

            return taskItemList;
        }
    }
}
