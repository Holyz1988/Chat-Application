using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasseto.Word.Core
{
    /// <summary>
    /// The application state as a View Model
    /// </summary>
    public class ApplicationViewModel
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;
    }
}
