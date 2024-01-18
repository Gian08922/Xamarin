using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Runtime.CompilerServices;

namespace DagZaf.Model
{
    public class TodoModel
    {
        [PrimaryKey, AutoIncrement, NotNull]
        public int TaskTodoID { get; set; }
        [MaxLength(60), NotNull]
        public string TaskName { get; set; }
        public DateTime Date { get; set; }
    }
}
