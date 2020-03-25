using AutoMapper;
using BusinessLogicLayer.DTOs;
using DataAccessLayer1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListApp.Automapper.Profiles
{
    public class ToDoItemProfile : Profile
    {
        public ToDoItemProfile()
        {
            CreateMap<ToDoItem, ToDoDTO>().ForMember(d => d.ToDoName, opt => opt.MapFrom(src => src.Name)).ReverseMap();


        }
    }
}
