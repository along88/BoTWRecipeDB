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
        private bool isDish;
        private bool isElixar;
        public ObservableCollection<tblRecipe> RecipeList { get; private set; }
        public ButtonCommand SubmitButton { get; private set; }
        public string RecipeName { get; private set; }
        public string RecipeEffect { get; private set; }
        public string RecipeType { get; private set; }
        public string RecipeDescription { get; private set; }
        public bool IsDish
        {
            get { return isDish; }

            set
            {
                isDish = value;
                
                OnPropertyChanged();
            }
        }
        public bool IsElixar
        {
            get { return isElixar; }

            set
            {
                isElixar = value;
                
                OnPropertyChanged();
            }
        }

        public RecipeViewModel()
        {


            RecipeList = new ObservableCollection<tblRecipe>();
            SubmitButton = new ButtonCommand(ParameterSelected);
           


        }

        private void GetAllRecipes()
        {
            Repository<tblRecipe> recipes = new Repository<tblRecipe>();
            var recipe = recipes.GetAll().ToList();
            RecipeList.Clear();
            for (int i = 0; i < recipe.Count; i++)
            {
                RecipeList.Add(recipe[i]);
            }
        }
        private void ParameterSelected(object message)
        {
            if(!isDish)
                GetAllRecipes();

            
        }

    }
}
            
            

