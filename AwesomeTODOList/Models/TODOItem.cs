using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AwesomeTODOList.Models
{
    public class TODOItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        [Display(Name = "Due date")]
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}