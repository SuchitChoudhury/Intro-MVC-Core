using Intro_MVC_6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro_MVC_6.Models
{
    public class ApplicationRepository:IApplicationRepository
    {

        private ApplicationDbContext _dbcontext;

        public ApplicationRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<ToDo> GetAllToDos()
        {
            return _dbcontext.ToDos.ToList();
        }
    }

    public interface IApplicationRepository
    {
         List<ToDo> GetAllToDos();
    }
}
