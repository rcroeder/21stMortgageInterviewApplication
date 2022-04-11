// ***********************************************************************
// Assembly         : 21stMortgageInterviewApplication
// Author           : RC Roeder
// Created          : 04-08-2022
//
// Last Modified By : RC Roeder
// Last Modified On : 04-08-2022
// ***********************************************************************
// <copyright file="ViewModel.cs" company="21stMortgageInterviewApplication">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _21stMortgageInterviewApplication.ViewModels
{
    /// <summary>
    /// Class ViewModel.
    /// Implements the <see cref="System.ComponentModel.INotifyPropertyChanged" />
    /// </summary>
    /// <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Occurs when [property changed].
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Called when [property changed].
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        public virtual void Dispose()
        {
        }
    }
}
