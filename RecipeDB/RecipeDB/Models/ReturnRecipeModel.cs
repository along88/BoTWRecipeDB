using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RecipeDB.Models
{
    class ReturnRecipeModel : INotifyPropertyChanged
    {
        private string recipeName;
        DataTable recipeList;

        public string RecipeName
        {
            get => recipeName;
            set
            {
                recipeName = value;
                OnPropertyChange(RecipeName);
            }
        }
        public DataTable RecipeList
        {
            get
            {
                return recipeList;
            }
            set
            {
                recipeList = value;
            }
                
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<EventArgs> OnRequest;

        private void OnPropertyChange(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
