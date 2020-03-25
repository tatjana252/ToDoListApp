using System;
using System.Collections.Generic;

namespace DataAccessLayer1.Models
{
    public partial class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
