
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repository<T> where T : class
    {
        private RecipesEntities recipes = new RecipesEntities();

        public IEnumerable<T> GetAll()
        {
            return recipes.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return recipes.Set<T>().Find(id);
        }
        
    }
}
