
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fasseto.Word
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

        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructor

        public LoginViewModel()
        {
            //Create one command
            LoginCommand = new RelayParamCommand(async (parameter) => await Login(parameter));
        }

        /// <summary>
        /// Attemmpts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed from the view for the users password</param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {

            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(5000);

                var email = this.Email;
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
            });
            
        }

        #endregion

        #region Private helpers


        #endregion
    }
}
