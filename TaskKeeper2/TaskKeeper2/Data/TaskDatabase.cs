using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskKeeper2.Models;

namespace TaskKeeper2.Data
{
    public class TaskDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public TaskDatabase(string path)
        {
            _database = new SQLiteAsyncConnection(path);
            _database.CreateTableAsync<TaskItemModel>().Wait(); // Create Table if it doesn't exist.
        }

        public Task<List<TaskItemModel>> GetAllAsync()
        {
            return _database.Table<TaskItemModel>().ToListAsync();
        }
        
        public Task<TaskItemModel> GetTaskAsync(int id)
        {
            return _database.Table<TaskItemModel>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        
        public Task<int> SaveOrUpdateTaskAsync(TaskItemModel data)
        {
            if (data.Id != 0)
            {
                return _database.UpdateAsync(data);
            }
            else
            {
                return _database.InsertAsync(data);
            }
        }
        public Task<int> DeleteTaskAsync(TaskItemModel data)
        {
            var status = _database.DeleteAsync(data);
            
            return status;
        }
    }
}