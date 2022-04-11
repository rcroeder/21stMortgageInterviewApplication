// ***********************************************************************
// Assembly         : 21stMortgageInterviewApplication
// Author           : RC Roeder
// Created          : 04-08-2022
//
// Last Modified By : RC Roeder
// Last Modified On : 04-08-2022
// ***********************************************************************
// <copyright file="FindSumOfOddNumbersCommand.cs" company="21stMortgageInterviewApplication">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using _21stMortgageInterviewApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using static _21stMortgageInterviewApplication.ViewModels.WPFTestViewModel;
namespace _21stMortgageInterviewApplication.Commands
{
    /// <summary>
    /// Class FindSumOfOddNumbersCommand.
    /// Implements the <see cref="_21stMortgageInterviewApplication.Commands.CommandBase" />
    /// </summary>
    /// <seealso cref="_21stMortgageInterviewApplication.Commands.CommandBase" />
    public class FindSumOfOddNumbersCommand : CommandBase
    {
        /// <summary>
        /// The view model
        /// </summary>
        private WPFTestViewModel ViewModel;
        /// <summary>
        /// Initializes a new instance of the <see cref="FindSumOfOddNumbersCommand" /> class.
        /// </summary>
        /// <param name="_ViewModel">The view model.</param>
        public FindSumOfOddNumbersCommand(WPFTestViewModel _ViewModel)
        {
            ViewModel = _ViewModel;
        }
        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to <see langword="null" />.</param>
        public override void Execute(object parameter)
        {
            var values = ViewModel.UserInput;

            string[] members = values.Split(',');
            var sumOfNumber = 0;

            for (var x = 0; x < members.Length; x++)
            {
                if (Convert.ToInt32(members[x]) % 2 != 0)
                {
                    sumOfNumber += Convert.ToInt32(members[x]);
                }
            }

            ViewModel.Results = sumOfNumber.ToString();
        }
    }
}
