using RecipeDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data;
using RecipeDB.Commands;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using DAL;

namespace RecipeDB.ViewModels
{
    class RecipeViewModel : ObservableCollection
    {

      

        public ObservableCollection<RecipeModel> RecipeList { get; private set; }
        public ButtonCommand SubmitButton { get; private set; }
        public string RecipeName { get; private set; }
        public string RecipeEffect { get; private set; }

        public RecipeViewModel()
        {


            RecipeList = new ObservableCollection<RecipeModel>();
            SubmitButton = new ButtonCommand(SetRecipes);


        }

        private void SetRecipes(object message)
        {
            Repository<RecipesEntities> recipes = new Repository<RecipesEntities>();
            var recipe = recipes.GetAll();
            MessageBox.Show(recipe.ToString());
            
           
           
        }
       


    }
}
            
            

