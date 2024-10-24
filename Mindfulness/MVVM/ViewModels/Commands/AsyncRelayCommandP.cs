using System.Windows.Input;

namespace Mindfulness.MVVM.ViewModels.Commands
{
    public class AsyncRelayCommandP(Func<object, Task> execute, Func<object, bool> canExecute = null)
        : ICommand
    {
        private readonly Func<object, Task> _execute = execute ?? throw new ArgumentNullException(nameof(execute));

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public async void Execute(object parameter)
        {
            if (CanExecute(parameter))
            {
                await _execute(parameter);
            }
        }
    }
}