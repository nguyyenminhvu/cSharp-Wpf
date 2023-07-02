using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace v1BuildCRUD.Command
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action<object> _execute { get; set; }
        private Predicate<object> _predicate { get; set; }

        public RelayCommand(Action<object> action, Predicate<object> predicate )
        {
            _execute= action;
            _predicate= predicate;
        }
        public bool CanExecute(object? parameter)
        {
            return CanExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
