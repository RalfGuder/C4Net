﻿
using C4Net.Data.Expressions;
namespace C4Net.Data.Interfaces
{
    /// <summary>
    /// Unit of work patter implementation.
    /// </summary>
    public interface IUnitOfWork
    {
        #region - Properties -

        /// <summary>
        /// Gets or sets the data context.
        /// </summary>
        /// <value>
        /// The context.
        /// </value>
        IDataContext Context { get; set; }

        /// <summary>
        /// Gets the transaction id.
        /// </summary>
        /// <value>
        /// The transaction id.
        /// </value>
        string TransactionId { get; }

        #endregion

        #region - Methods -

        /// <summary>
        /// Gets the repository.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IRepository<T> GetRepository<T>() where T : IEntity;

        /// <summary>
        /// Gets a queryable object for linq queries.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryableObject<T> GetQuery<T>() where T : IEntity;

        /// <summary>
        /// Applies the changes.
        /// </summary>
        void ApplyChanges();

        /// <summary>
        /// Cancels the changes.
        /// </summary>
        void CancelChanges();

        #endregion
    }
}
