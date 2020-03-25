using BusinessLogicLayer.DTOs;
using DataAccessLayer1.Models;
using System;

namespace BusinessLogicLayer
{
    public interface IServiceToDo
    {
        ToDoDTO Get(int id);
    }
}
