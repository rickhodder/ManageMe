﻿using ManageMe.Core;
using ManageMe.Core.Entities;
using ManageMe.SharedKernel.Interfaces;
using ManageMe.Web.ApiModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ManageMe.Web.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IRepository _repository;

        public ToDoController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var items = _repository.List<ToDoItem>()
                            .Select(ToDoItemDTO.FromToDoItem);
            return View(items);
        }

        public IActionResult Populate()
        {
            int recordsAdded = DatabasePopulator.PopulateDatabase(_repository);
            return Ok(recordsAdded);
        }
    }
}
