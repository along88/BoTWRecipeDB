using RecipeDB.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecipeDB.Commands
{
    class ReturnRecipeCmd : ICommand
    {
        private ReturnRecipeViewModel returnRecipeViewModel;

        public ReturnRecipeCmd(ReturnRecipeViewModel returnRecipeViewModel)
        {
            this.returnRecipeViewModel = returnRecipeViewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return returnRecipeViewModel.UpdateList;
        }
        public void Execute(object parameter)
        {
            returnRecipeViewModel.RecipeRequested();
        }
    }
}
