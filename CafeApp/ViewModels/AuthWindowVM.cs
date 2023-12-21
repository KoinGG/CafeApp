using Avalonia.Controls;
using CafeApp.Desktop;
using CafeApp.Sourses;
using CafeApp.Views;
using ReactiveUI;
using System.Linq;
using System.Reactive;

namespace CafeApp.ViewModels
{
    public class AuthWindowVM : ViewModelBase
    {
        #region [Private Fields]

        private string _username;
        private string _password;

        #endregion

        public AuthWindowVM()
        {
            SignInAcceptCommand = ReactiveCommand.Create<Window>(SignInAcceptCommandImpl);
        }

        #region [Properties]

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref _username, value);
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref _password, value);
            }
        }

        #region [Commands Declaration]

        public ReactiveCommand<Window, Unit> SignInAcceptCommand { get; }

        #endregion

        #endregion

        #region [Methods]

        private void SignInAcceptCommandImpl(Window window)
        {
            User? user = DbContextProvider.GetContext().Users.FirstOrDefault(x => x.Username == Username && x.Password == Password);

            if (user != null)
            {
                if (user.EmploymentStatusId != 2)
                {
                    if (user.RoleId == 1) // Официант
                    {
                        var waiterWindow = new WaiterWindow();
                        try
                        {
                            waiterWindow.Show();
                            //window.Close();
                        }
                        catch
                        {
                            ErrorMessage.ShowErrorMessage("Ошибка авторизации");
                        }
                    }
                    else if (user.RoleId == 2) // Повар
                    {
                        var cookWindow = new CookWindow();
                        try
                        {
                            cookWindow.Show();
                            //window.Close();
                        }
                        catch
                        {
                            ErrorMessage.ShowErrorMessage("Ошибка авторизации");
                        }
                    }
                    else if (user.RoleId == 3) // Администратор
                    {
                        var adminWindow = new AdminWindow();
                        try
                        {
                            adminWindow.Show();
                            //window.Close();
                        }
                        catch
                        {
                            ErrorMessage.ShowErrorMessage("Ошибка авторизации");
                        }
                    }

                }
                else
                {
                    ErrorMessage.ShowErrorMessage("Вы уволены");
                }

            }
        }

        #endregion
    }
}
