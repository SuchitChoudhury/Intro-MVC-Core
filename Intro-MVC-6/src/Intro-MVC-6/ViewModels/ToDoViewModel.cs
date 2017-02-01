using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC_6.ViewModels
{
    public class ToDoViewModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(10,ErrorMessage ="Too short Description!")]
        public string Description { get; set; }
        public bool Completed { get; set; }
    }
}
