using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskKeeper2.Models
{
    public class TaskItemModel
    {
		[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Text { get; set; }
        public bool Complete { get; set; }
    }
}
