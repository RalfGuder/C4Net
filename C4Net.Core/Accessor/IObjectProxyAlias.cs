using System;
using System.Collections.Generic;

namespace C4Net.Core.Accessor
{
    /// <summary>
    /// Interface for an object proxy that also haves an alias dictionary.
    /// </summary>
    public interface IObjectProxyAlias : IObjectProxy
    {
        /// <summary>
        /// Gets the aliases dictionary that relates aliases with property names.
        /// </summary>
        /// <value>
        /// The aliases.
        /// </value>
        Dictionary<string, string> Aliases { get; }

        /// <summary>
        /// Adds an alias.
        /// </summary>
        /// <param name="alias">The alias.</param>
        /// <param name="propName">Name of the property.</param>
        void AddAlias(string alias, string propName);

        /// <summary>
        /// Removes an alias.
        /// </summary>
        /// <param name="alias">The alias.</param>
        void RemoveAlias(string alias);

        /// <summary>
        /// Gets the name of the property associated to the alias.
        /// </summary>
        /// <param name="alias">The alias.</param>
        /// <returns></returns>
        string GetAliasPropertyName(string alias);

        /// <summary>
        /// Gets the value of the property associated to the alias in the instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="alias">The alias.</param>
        /// <returns></returns>
        object GetValueAlias(object instance, string alias);

        /// <summary>
        /// Sets the value of the property associated to the alias in the instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="alias">The alias.</param>
        /// <param name="value">The value.</param>
        void SetValueAlias(object instance, string alias, object value);

        /// <summary>
        /// Gets the property type of the property associated to the alias.
        /// </summary>
        /// <param name="alias">The alias.</param>
        /// <returns></returns>
        Type GetPropertyTypeAlias(string alias);
    }
}
