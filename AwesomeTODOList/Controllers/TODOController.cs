using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AwesomeTODOList.Managers;
using AwesomeTODOList.Models;

namespace AwesomeTODOList.Controllers
{
    public class TODOController : Controller
    {
        private TODOItemManager _dbManager = new TODOItemManager();

        // GET: TODO
        public ActionResult GetAllTasks()
        {
            var items = _dbManager.GetAllTasks();
            return View(items);
        }

        public ActionResult GetCompleted(bool completed)
        {
            //List<TODOItem> items = new List<TODOItem>();

            //foreach (var item in TODOList.Items)
            //{
            //    if(item.IsCompleted == completed)
            //    {
            //        items.Add(item);
            //    }
            //}

            var items = TODOList.Items.Where(i => i.IsCompleted == completed).ToList();

            return View("GetAllTasks", items);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TODOItem todo)
        {
            if(!ModelState.IsValid)
            {
                return View(todo);
            }

            _dbManager.Insert(todo);

            TempData["Message"] = "Task created!";
            return RedirectToAction("GetAllTasks");
        }
        
        public ActionResult Edit(int id)
        {
            var todo = _dbManager.GetItemById(id);
            return View(todo);
        }
        
        [HttpPost]
        public ActionResult Edit(TODOItem todo)
        {
            if(!ModelState.IsValid)
            {
                return View(todo);
            }

            // Update database
            _dbManager.Update(todo);

            return RedirectToAction("GetAllTasks");
        }
    }
}