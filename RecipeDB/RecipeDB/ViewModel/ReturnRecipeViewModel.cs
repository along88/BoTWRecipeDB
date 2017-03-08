using RecipeDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data;
using RecipeDB.Commands;

namespace RecipeDB.ViewModel
{
    class ReturnRecipeViewModel
    {
        private ReturnRecipeModel returnRecipeModel;
        private string message;
        DataTable recipeList;

        public ReturnRecipeViewModel()
        {
            returnRecipeModel = new ReturnRecipeModel();
            ReturnRecipeBind = new ReturnRecipeCmd(this);
        }

        

        public void RecipeRequested()
        {

            recipeList = returnRecipeModel.RecipeList;

            
        }

        public bool UpdateList
        {
            get
            {
                if (returnRecipeModel == null)
                {
                    return false;
                }
                RecipeRequested();
                return true;
            }
            

        }
        public ICommand ReturnRecipeBind
        {
            get;
            private set;
        }

    }
}
