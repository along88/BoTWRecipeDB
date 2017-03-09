using RecipeDB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecipeDB.Commands
{
    public class ButtonCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        public ButtonCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if(execute == null)
            {
                throw new Exception("Cannot Execute Method");
            }
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public ButtonCommand(Action<object> execute) : this(execute,null)
        {

        }


        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            if(canExecute == null)
            {
                return true;
            }
            return canExecute(parameter);
        }
        public void Execute(object parameter)
        {
            execute.Invoke(parameter);
        }

    }
}
