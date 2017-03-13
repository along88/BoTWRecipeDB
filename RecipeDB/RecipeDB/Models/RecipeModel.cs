using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RecipeDB.ViewModels;
using System.Collections.ObjectModel;

namespace RecipeDB.Models
{
    public class RecipeModel : ObservableCollection
    {
        public string RecipeName {get; set;}
        public string RecipeEffect { get; set; }
        public string RecipeType { get; set; }
        public string RecipeDescription{ get; set; }
        



    }
}
