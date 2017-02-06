using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC_6.ViewModels
{
    public class ToDoViewModel
    {   [Key]
        public int Id { get; set; }
        [Required]      
        public string Description { get; set; }
        public bool Completed { get; set; }
    }
}
