﻿using System.Collections;

namespace C4Net.Core.Accessor
{
    /// <summary>
    /// Interface for an object creator that allows to create instances or collections.
    /// </summary>
    public interface IObjectCreator
    {
        #region - Methods -

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <returns></returns>
        object CreateObject();

        /// <summary>
        /// Creates a new collection.
        /// </summary>
        /// <returns></returns>
        IList CreateList();

        #endregion
    }
}
