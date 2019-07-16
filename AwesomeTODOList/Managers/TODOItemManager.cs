using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AwesomeTODOList.Models;
namespace AwesomeTODOList.Managers
{
    public class TODOItemManager
    {
        public void Insert(TODOItem item)
        {
            using (TODOContext db = new TODOContext())
            {
                db.Todos.Add(item);
                db.SaveChanges();
            }
        }

        public IEnumerable<TODOItem> GetAllTasks()
        {
            IEnumerable<TODOItem> todos;

            using (TODOContext db = new TODOContext())
            {
                //todos = (from todo in db.Todos
                //         select todo).ToList();

                //todos = db.Todos.Select(i => i).ToList();

                todos = db.Todos.ToList();
            }

            return todos;
        }

        public TODOItem GetItemById(int id)
        {
            TODOItem todo;

            using (TODOContext db = new TODOContext())
            {
                todo = db.Todos.Find(id);
            }

            return todo;
        }

        public void Update(TODOItem todo)
        {
            using (TODOContext db = new TODOContext())
            {
                db.Todos.Attach(todo);
                db.Entry(todo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}