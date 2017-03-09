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

namespace RecipeDB.ViewModels
{
    public class ReturnRecipeViewModel : ObservableCollection
    {
        
        private ReturnRecipeModel returnRecipeModel;

        
        public ReturnRecipeModel ReturnRecipeModel
        {
            get => returnRecipeModel;
           
        }
        public ButtonCommand SubmitButton { get; private set; }
        public DataView dataGridView { get; private set; }
       
        
        public ReturnRecipeViewModel()
        {
            returnRecipeModel = new ReturnRecipeModel();
            GetModelsData();
            SubmitButton = new ButtonCommand(PopulateRecipes);
            

        }
        public void GetModelsData()
        {
            dataGridView = returnRecipeModel.RecipeList;

        }

        public void PopulateRecipes(object message)
        {

            
            
        }


        
             
    }
}
