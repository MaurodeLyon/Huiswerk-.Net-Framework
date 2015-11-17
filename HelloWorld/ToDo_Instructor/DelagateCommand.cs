using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDo_Instructor
{
    class DelagateCommand : ICommand
    {
        private Action _commandHandler;
        public event EventHandler CanExecuteChanged;

        public DelagateCommand(Action commandHandler)
        {
            _commandHandler = commandHandler;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _commandHandler();
        }
    }
}
