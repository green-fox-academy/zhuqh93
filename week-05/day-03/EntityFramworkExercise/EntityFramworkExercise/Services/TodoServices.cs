using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramworkExercise.Models;

namespace EntityFramworkExercise.Services
{
    public class TodoServices : ITodoServices
    {
        public readonly ApplicationContext ApplicationContext;

        public TodoServices(ApplicationContext applicationContext)
        {
            this.ApplicationContext = applicationContext;
        }

        public void Add(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
