using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskKeeper2.Data;
using TaskKeeper2.Models;

namespace TaskKeeper2.Helpers
{
    public class DataHelper
    {
        private readonly DataStore _dataStore;
        public DataHelper()
        {
            this._dataStore = new DataStore();
        }
        public void SetDummyData()
        {
            foreach (var item in _dataStore.GetAll())
            {
                _dataStore.TaskItems.Add(item);
            }
            //just get all and set it to the dummy data variable.
        }
        public ObservableCollection<TaskItemModel> GetAll()
        {
            return _dataStore.TaskItems;
        }
        public TaskItemModel GetTask(int id)
        {
            return _dataStore.TaskItems.FirstOrDefault(x => x.Id == id);
        }
        public int InsertTask(TaskItemModel data)
        {
            _dataStore.TaskItems.Add(data);
            return _dataStore.TaskItems.Last().Id; // returns the ID of the newly inserted.
        }
    }
}
