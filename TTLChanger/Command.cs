using System;
using System.Windows.Input;

namespace Windows_off_timer
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action _action1;
        protected Action<object> _action2;
        public Command(Action action1)
        {
            _action1 = action1;
        }
        public Command(Action<object> action2)
        {
            _action2 = action2;
        }
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }
        public virtual void Execute(object parameter)
        {
            _action2.Invoke(parameter);
        }
    }

    public class Command<T> : Command
    {
        private T Parameter;
        private Action myObgParam;
        public Command(Action<T> execution) : base(execution)
        {

        }
        public override void Execute(object parameter)
        {
            if (parameter is T ti)
            {
                base.Execute(ti);
            }
        }
    }
}

