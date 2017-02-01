using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Intro_MVC_6.Data;
using Intro_MVC_6.Models;

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
            return View(AutoMapper.Mapper.Map(_todos,new List<ViewModels.ToDoViewModel>()));
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
