using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BusinessLogicLayer.DTOs;
using DataAccessLayer1.Models;

namespace BusinessLogicLayer
{
    public class ToDoService : IServiceToDo
    {
        public ToDoService(IMapper mapper)
        {
            Mapper = mapper;
        }

        public IMapper Mapper { get; }

        public ToDoDTO Get(int id)
        {
            ToDoItem t = new ToDoItem
            {
                Id = 1,
                Name = "Example"
            };
            ToDoDTO dto = Mapper.Map<ToDoDTO>(t);
            return dto;
            
        }
    }
}
