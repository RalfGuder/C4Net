using System.Linq.Expressions;
using C4Net.Data.Expressions.Evaluator;

namespace C4Net.Data.Expressions.Builder
{
    // TODO : Command builder using an expression reviewer.
    public class ExpressionCommandBuilder : ExprReviewer
    {
        #region - Fields -
        #endregion

        #region - Properties -

        public Expression Expression { get; private set; }

        #endregion

        #region - Constructors -

        public ExpressionCommandBuilder(Expression expression)
            : base()
        {
            this.Expression = expression;
        }

        #endregion

        #region - Methods -


        #endregion
    }
}
