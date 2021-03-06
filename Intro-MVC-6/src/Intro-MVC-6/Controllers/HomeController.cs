﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Intro_MVC_6.Data;
using Intro_MVC_6.Models;
using Intro_MVC_6.ViewModels;

namespace Intro_MVC_6.Controllers
{

    public class HomeController : Controller
    {
        private IApplicationRepository _repository;

        public HomeController(IApplicationRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var _todos = _repository.GetAllToDos();
            return View(AutoMapper.Mapper.Map(_todos, new List<ViewModels.ToDoViewModel>()));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost,ExportModelStateToTempData]
        public IActionResult Create(ToDoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (!_repository.AddToDo(AutoMapper.Mapper.Map(viewModel,new ToDo())))
                {
                    ModelState.AddModelError("", "The Data Cannot be saved. Try Again later!");
                }
            }

            return RedirectToAction("Index");
        }
        [HttpPost, ExportModelStateToTempData]
        public IActionResult Update(ViewModels.ToDoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (!_repository.UpdateToDo(AutoMapper.Mapper.Map(viewModel,new ToDo())))
                {
                    ModelState.AddModelError(String.Empty, "There was an unexpected error while saving the ToDo to DB");
                }
            }
            return RedirectToAction("Index");
        }
       
        public IActionResult Error()
        {
            return View();
        }
    }
}
