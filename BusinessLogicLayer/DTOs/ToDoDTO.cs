﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class ToDoDTO
    {
        public int Id { get; set; }
        public string ToDoName { get; set; }
        public bool IsComplete { get; set; }
    }
}
