using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoRItems.Models;

namespace RoRItems.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new Item();
            return View(viewModel);
        }
        
        [Route("{id}")]
        public IActionResult Index(string id)
        {
            var viewModel = new Item();
            viewModel.Id = id;
            return View(viewModel);
        }
    }
}