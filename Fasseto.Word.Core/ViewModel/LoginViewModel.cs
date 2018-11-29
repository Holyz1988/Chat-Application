using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasseto.Word.Core
{
    /// <summary>
    /// The View Model for a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running  
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register for a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor

        public LoginViewModel()
        {
            //Create one command
            LoginCommand = new RelayParamCommand(async (parameter) => await LoginAsync(parameter));
            RegisterCommand = new RelayCommand(async () => await RegisterAsync());
        }

        /// <summary>
        /// Attemmpts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed from the view for the users password</param>
        /// <returns></returns>
        public async Task LoginAsync(object parameter)
        {

            await RunCommandAsync(() => LoginIsRunning, async () =>
            {
                await Task.Delay(5000);

                var email = Email;
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
            });
            
        }

        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed from the view for the users password</param>
        /// <returns></returns>
        public async Task RegisterAsync()
        {
            //TODO: Go to register page?
            //((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Register;

            await Task.Delay(1);
        }

        #endregion

        #region Private helpers


        #endregion
    }
}
