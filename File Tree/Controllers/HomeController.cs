using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.Interfaces;
using File_Tree.Mappers;
using File_Tree.Models;

namespace File_Tree.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDirectoryManager _manager;
        public HomeController(IDirectoryManager manager)
        {
            _manager = manager;
        }
        public ActionResult Index()
        {
            var toReturn = new DNode().Map(_manager.GetLargeDirectoryStructure());
            return View(toReturn);
        }
    }
}