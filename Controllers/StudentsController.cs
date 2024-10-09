using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KTI.Models;
using KTI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KTI.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentRepository _studentRepository;

        public StudentsController(ILogger<StudentsController> logger,
        IStudentRepository studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            ViewData["Tittle"] = "Student List";
            var models = _studentRepository.GetAll();
            return View(models);
        }

        public IActionResult Description()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}