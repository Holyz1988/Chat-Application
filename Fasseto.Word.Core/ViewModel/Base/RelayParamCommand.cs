﻿using System;
using System.Windows.Input;

namespace Fasseto.Word.Core
{
    /// <summary>
    /// a basic command that runs an action
    /// </summary>
    public class RelayParamCommand : ICommand
    {
        #region Private Members

        /// <summary>
        /// The action to run
        /// </summary>
        private readonly Action<object> _action;

        #endregion

        #region Public events

        /// <summary>
        /// The event thats fired when the <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public RelayParamCommand(Action<object> action)
        {
            _action = action;
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// A relay command can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the command Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _action(parameter);
        }

        #endregion
    }
}
