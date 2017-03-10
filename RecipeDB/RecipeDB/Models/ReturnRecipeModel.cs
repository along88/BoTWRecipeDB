using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RecipeDB.ViewModels;


namespace RecipeDB.Models
{
    public class ReturnRecipeModel : ObservableCollection
    {
        private string recipeName;
        DataView recipeList;
        
        public string RecipeName
        {
            get => recipeName;
            set
            {
                recipeName = value;
                OnPropertyChanged("RecipeName");
            }
        }
        public DataView RecipeList
        {
            get
            {

                DataSet recipeData = new DataSet();
                    recipeData.Tables.Add("Recipes");
                    recipeData.Tables[0].Columns.Add("Recipe");
                    recipeData.Tables[0].Columns.Add("Type");
                    recipeData.Tables[0].Columns.Add("Effect");
                    recipeData.Tables[0].Columns.Add("Description");
                    



                DataRow dr = recipeData.Tables[0].NewRow();
                dr["Recipe"] = recipeName;
                dr["Type"] = "Dish";
                dr["Effect"] = "restores three quarters of a heart";
                dr["Description"] = "Direct heat has softened and sweetened this Apple. Eat it to restore three quarters of a heart.";

                recipeData.Tables[0].Rows.Add(dr);
                return recipeData.Tables[0].DefaultView;
            }
            set
            {
                recipeList = value;
                OnPropertyChanged("RecipeList");
            }
                
        }

        public ReturnRecipeModel()
        {
            recipeName = "Baked Apple";
        }

       
    }
}
