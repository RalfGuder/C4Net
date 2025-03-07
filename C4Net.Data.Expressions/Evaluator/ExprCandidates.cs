using System.Collections.Generic;
using System.Linq.Expressions;

namespace C4Net.Data.Expressions.Evaluator
{
    /// <summary>
    /// Search the candidate expressions from an expression tree.
    /// </summary>
    public class ExprCandidates : ExprReviewer
    {
        #region - Fields -

        /// <summary>
        /// The candidate list.
        /// </summary>
        private HashSet<Expression> candidates = new HashSet<Expression>();

        #endregion

        #region - Methods -

        /// <summary>
        /// Gets the candidate list from an expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        public static HashSet<Expression> GetCandidates(Expression expression)
        {
            ExprCandidates instance = new ExprCandidates();
            instance.Review(expression);
            return instance.candidates;
        }

        /// <summary>
        /// Determines whether the specified expression is evaluable.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>
        ///   <c>true</c> if the specified expression is evaluable; otherwise, <c>false</c>.
        /// </returns>
        protected virtual bool IsEvaluable(Expression expression)
        {
            return expression.NodeType != ExpressionType.Parameter;
        }

        /// <summary>
        /// Reviews the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        protected override Expression Review(Expression expression)
        {
            if (expression == null)
            {
                return null;
            }
            base.Review(expression);
            if (this.IsEvaluable(expression))
            {
                this.candidates.Add(expression);
            }
            return expression;
        }

        #endregion
    }
}
