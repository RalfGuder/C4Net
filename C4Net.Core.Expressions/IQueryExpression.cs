
namespace C4Net.Core.Expressions
{
    /// <summary>
    /// Interface for the query expression
    /// </summary>
    public interface IQueryExpression
    {

        #region - Properties -

        /// <summary>
        /// Gets the table.
        /// </summary>
        /// <value>The table.</value>
        TableExpression Table { get; }

        /// <summary>
        /// Gets the condition.
        /// </summary>
        /// <value>The condition.</value>
        ConditionExpression Condition { get; }

        /// <summary>
        /// Gets the columns.
        /// </summary>
        /// <value>The columns.</value>
        ColumnExpressionList Columns { get; }

        #endregion

    }
}
