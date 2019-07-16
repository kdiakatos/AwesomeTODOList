using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwesomeTODOList.Models
{
    public static class TODOList
    {
        public static List<TODOItem> Items { get; set; }

        static TODOList()
        {
            Items = new List<TODOItem>();
            Items.Add(new TODOItem
            {
                Title = "Task 1",
                Description = "Task 1 Description",
                DueDate = new DateTime(2019, 6, 30),
                IsCompleted = false
            });
            Items.Add(new TODOItem
            {
                Title = "Task 2",
                Description = "Task 2 Description",
                DueDate = new DateTime(2019, 7, 10),
                IsCompleted = true
            });
        }
    }
}