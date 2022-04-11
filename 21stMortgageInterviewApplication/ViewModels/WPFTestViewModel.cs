// ***********************************************************************
// Assembly         : 21stMortgageInterviewApplication
// Author           : RC Roeder
// Created          : 04-08-2022
//
// Last Modified By : RC Roeder
// Last Modified On : 04-08-2022
// ***********************************************************************
// <copyright file="WPFTestViewModel.cs" company="21stMortgageInterviewApplication">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using _21stMortgageInterviewApplication.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Media;

namespace _21stMortgageInterviewApplication.ViewModels
{
    /// <summary>
    /// Class WPFTestViewModel.
    /// Implements the <see cref="_21stMortgageInterviewApplication.ViewModels.ViewModelBase" />
    /// </summary>
    /// <seealso cref="_21stMortgageInterviewApplication.ViewModels.ViewModelBase" />
    public class WPFTestViewModel : ViewModelBase
    {
        /// <summary>
        /// The instancelock
        /// </summary>
        private static readonly object Instancelock = new object();

        /// <summary>
        /// The WPF test view model instance
        /// </summary>
        private static WPFTestViewModel WPFTestViewModelInstance = null;

        /// <summary>
        /// Gets or sets the find sum even numbers command.
        /// </summary>
        /// <value>The find sum even numbers command.</value>
        public ICommand FindSumEvenNumbersCommand { get; set; }
        /// <summary>
        /// Gets or sets the find sum of odd numbers command.
        /// </summary>
        /// <value>The find sum of odd numbers command.</value>
        public ICommand FindSumOfOddNumbersCommand { get; set; }
        /// <summary>
        /// Gets or sets the find largest value command.
        /// </summary>
        /// <value>The find largest value command.</value>
        public ICommand FindLargestValueCommand { get; set; }
        /// <summary>
        /// Prevents a default instance of the <see cref="WPFTestViewModel"/> class from being created.
        /// </summary>
        private WPFTestViewModel()
        {
            FindSumEvenNumbersCommand = new FindSumEvenNumbersCommand(this );
            FindSumOfOddNumbersCommand = new FindSumOfOddNumbersCommand(this);
            FindLargestValueCommand = new FindLargestValueCommand(this);

        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>The get instance.</value>
        public static WPFTestViewModel GetInstance
        {
            get
            {
                if (WPFTestViewModelInstance == null)
                {
                    lock (Instancelock)
                    {
                        if (WPFTestViewModelInstance == null)
                        {
                            WPFTestViewModelInstance = new WPFTestViewModel();
                        }
                    }
                }

                return WPFTestViewModelInstance;
            }
        }

        /// <summary>
        /// The user input
        /// </summary>
        private string _UserInput;

        /// <summary>
        /// Gets or sets the user input.
        /// </summary>
        /// <value>The user input.</value>
        public string UserInput
        {
            get => _UserInput;
            set
            {
                _UserInput = value;
                OnPropertyChanged("UserInput");
            }
        }

        /// <summary>
        /// The results
        /// </summary>
        private string _Results;

        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        /// <value>The results.</value>
        public string Results
        {
            get => _Results;
            set
            {
                _Results = value;
                OnPropertyChanged("Results");
            }
        }


    }
}
