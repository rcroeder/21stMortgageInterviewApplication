// ***********************************************************************
// Assembly         : 21stMortgageInterviewApplication
// Author           : RC Roeder
// Created          : 04-08-2022
//
// Last Modified By : RC Roeder
// Last Modified On : 04-08-2022
// ***********************************************************************
// <copyright file="FindLargestValueCommand.cs" company="21stMortgageInterviewApplication">
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
    /// Class FindLargestValueCommand.
    /// Implements the <see cref="_21stMortgageInterviewApplication.Commands.CommandBase" />
    /// </summary>
    /// <seealso cref="_21stMortgageInterviewApplication.Commands.CommandBase" />
    public class FindLargestValueCommand :CommandBase
    {
        /// <summary>
        /// The view model
        /// </summary>
        private WPFTestViewModel ViewModel;
        /// <summary>
        /// Initializes a new instance of the <see cref="FindLargestValueCommand" /> class.
        /// </summary>
        /// <param name="_viewModel">The view model.</param>
        public FindLargestValueCommand(WPFTestViewModel _viewModel)
        {
            ViewModel = _viewModel;
        }
        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to <see langword="null" />.</param>
        public override void Execute(object parameter)
        {
            var values = ViewModel.UserInput;

            string[] members = values.Split(',');
            var largest = -20000;

            for (var x = 0; x < members.Length; x++)
            {
                if (Convert.ToInt32(members[x]) > largest)
                {
                    largest = Convert.ToInt32(members[x]);

                }
            }

            ViewModel.Results = largest.ToString();
        }
    }
}
