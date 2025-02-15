using Prism.Mvvm;
using System.Collections;
using System.ComponentModel;
using System.Windows.Input;

namespace Zip.Sample.ViewModels
{
    public class MainWindowViewModel : BindableBase, INotifyDataErrorInfo
    {
		private string _username;
		private string _password;
        private ICommand _submitCommand;
        private ErrorsContainer<string> _errorsContainer;

        public string UserName
		{
			get => _username;
			set => SetProperty(ref _username, value);
		}

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public ICommand SubmitCommand
        {
            get => _submitCommand ?? (_submitCommand = new DelegateCommand(Submit));
        }

        public MainWindowViewModel()
        {
            _errorsContainer = new ErrorsContainer<string>(OnErrorsChanged);
        }

        private void Submit()
        {
            if (string.IsNullOrEmpty(UserName))
            {
                _errorsContainer.SetErrors(() => UserName, new string[] { "用户名不能为空" });
            }
            else
            {
                _errorsContainer.ClearErrors(() => UserName);
            }
        }

        public bool HasErrors => _errorsContainer.HasErrors;

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public IEnumerable GetErrors(string? propertyName)
        {
            return _errorsContainer.GetErrors(propertyName);
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}