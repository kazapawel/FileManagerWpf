using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FileManagerTwo
{
    /// <summary>
    /// Custom ICommand implementation.
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region PRIVATE MEMBERS

        /// <summary>
        /// Action delagate which is going to be executed
        /// </summary>
        readonly Action<object> _execute;

        /// <summary>
        /// Predicate if action can be executed
        /// </summary>
        readonly Func<object, bool> _canExecute;

        #endregion

        #region ICOMMAND IMPLEMENTATION

        /// <summary>
        /// Event
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Can action be executed. If predicate is null returns true;
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
            
        }

        /// <summary>
        /// Fires action.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Constructor with predicate
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            //Checks if action is null
            if (execute == null) throw new ArgumentNullException(nameof(execute));
            else
                _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Constructor with null predicate
        /// </summary>
        /// <param name="execute"></param>
        public RelayCommand(Action<object> execute)
        {
            if (execute == null) throw new ArgumentNullException(nameof(execute));
            else
                _execute = execute;
            _canExecute = null;
        }

        #endregion
    }
}
