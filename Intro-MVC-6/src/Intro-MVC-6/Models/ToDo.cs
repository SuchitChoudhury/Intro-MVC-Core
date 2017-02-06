using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC_6.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ToDo
    {   [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
    }
}
