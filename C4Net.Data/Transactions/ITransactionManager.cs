using System.Data;

namespace C4Net.Data.Transactions
{
    /// <summary>
    /// Interface for a transaction manager
    /// </summary>
    public interface ITransactionManager
    {
        #region - Methods -

        /// <summary>
        /// Begins the transaction.
        /// </summary>
        /// <returns></returns>
        string BeginTransaction();

        /// <summary>
        /// Begins the transaction.
        /// </summary>
        /// <param name="isolationLevel">The isolation level.</param>
        /// <returns></returns>
        string BeginTransaction(IsolationLevel isolationLevel);

        /// <summary>
        /// Commits the transaction.
        /// </summary>
        /// <param name="transactionID">The transaction ID.</param>
        void CommitTransaction(string transactionID = null);

        /// <summary>
        /// Rollbacks the transaction.
        /// </summary>
        /// <param name="transactionID">The transaction ID.</param>
        void RollbackTransaction(string transactionID = null);

        /// <summary>
        /// Gets a transaction by its ID.
        /// </summary>
        /// <param name="transactionID">The transaction ID.</param>
        /// <returns></returns>
        IDbTransaction GetTransaction(string transactionID = null);

        #endregion
    }
}
