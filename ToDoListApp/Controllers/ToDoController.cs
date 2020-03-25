using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogicLayer;
using BusinessLogicLayer.DTOs;
using DataAccessLayer1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ToDoListApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : Controller
    {
        private readonly IServiceToDo service;

        public ToDoController(IServiceToDo service)
        {
            this.service = service;
        }

        [Route("I")]
        [HttpPost]
        [Produces("application/json")]
        public IActionResult Index(ToDoItem item)
        {
            throw new Exception();
            return CreatedAtAction("Get", new { id = item.Id }, item);
        }

        [HttpGet]
        [Route("Get/{id:int}")]
        public ToDoItem Get(int id)
        {
            ToDoDTO r = service.Get(1);
            return new ToDoItem { Id = id };
        }
    }
}