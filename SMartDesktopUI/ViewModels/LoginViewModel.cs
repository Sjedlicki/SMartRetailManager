using Caliburn.Micro;
using SMartDesktopUI.Helpers;
using System;
using System.Threading.Tasks;

namespace SMartDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;
        private string _errorMessage;

        private IAPIHelper _apiHelper;

        public LoginViewModel(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogin);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogin);
            }
        }

        public bool IsErrorVisible
        {
            get 
            {
                bool output = false;
                
                if(ErrorMessage?.Length > 0)
                {
                    output = true;
                }
                
                return output; 
            }

            set { }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set 
            { 

                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisible);
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }

        public bool CanLogin
        {
            get
            {
                bool output = false;

                // ? is a Null Check
                // If UserName is not Null else fails
                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
        }

        public async Task Login()
        {
            try
            {
                ErrorMessage = "";
                var result = await _apiHelper.Authenticate(UserName, Password);
            }
            catch(Exception ex)
            {
                ErrorMessage = ex.Message;
            }            
        }
    }
}
