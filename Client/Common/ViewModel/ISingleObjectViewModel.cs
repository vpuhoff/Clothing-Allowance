﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using Client.Common.Utils;
using Client.Common.DataModel;

namespace Client.Common.ViewModel
{
    /// <summary>
    /// The base interface for view models representing a single entity.
    /// </summary>
    /// <typeparam name="TEntity">An entity type.</typeparam>
    /// <typeparam name="TPrimaryKey">An entity primary key type.</typeparam>
    public interface ISingleObjectViewModel<TEntity, TPrimaryKey>
    {

        /// <summary>
        /// The entity represented by a view model.
        /// </summary>
        TEntity Entity { get; }

        /// <summary>
        /// The entity primary key value.
        /// </summary>
        TPrimaryKey PrimaryKey { get; }
    }
}