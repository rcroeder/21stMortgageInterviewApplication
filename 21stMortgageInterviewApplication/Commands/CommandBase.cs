// ***********************************************************************
// Assembly         : 21stMortgageInterviewApplication
// Author           : RC Roeder
// Created          : 04-08-2022
//
// Last Modified By : RC Roeder
// Last Modified On : 04-08-2022
// ***********************************************************************
// <copyright file="CommandBase.cs" company="21stMortgageInterviewApplication">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _21stMortgageInterviewApplication.Commands
{

    /// <summary>
    /// Class CommandBase.
    /// Implements the <see cref="System.Windows.Input.ICommand" />
    /// </summary>
    /// <seealso cref="System.Windows.Input.ICommand" />
    public abstract class CommandBase : ICommand
    {
        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged;


        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to <see langword="null" />.</param>
        /// <returns><see langword="true" /> if this command can be executed; otherwise, <see langword="false" />.</returns>
        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to <see langword="null" />.</param>
        public abstract void Execute(object parameter);

        /// <summary>
        /// Called when [can executed changed].
        /// </summary>
        protected void OnCanExecutedChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }

}
