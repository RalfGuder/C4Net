using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity MeteorologicFeature.
    /// </summary>
    public class MeteorologicFeatureExpression : BaseEntityExpression<MeteorologicFeatureExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column met_feat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column met_feat_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Interpretation that represents the column interpretation_code.
        /// </summary>
        /// <value>
        /// The value of the property Interpretation that represents the column interpretation_code.
        /// </value>
        public ColumnExpression Interpretation 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ProbabilityRatio that represents the column prob_rat.
        /// </summary>
        /// <value>
        /// The value of the property ProbabilityRatio that represents the column prob_rat.
        /// </value>
        public ColumnExpression ProbabilityRatio 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Source that represents the column source_code.
        /// </summary>
        /// <value>
        /// The value of the property Source that represents the column source_code.
        /// </value>
        public ColumnExpression Source 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[6]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="MeteorologicFeatureExpression"/> class.
        /// </summary>
        public MeteorologicFeatureExpression()
            : base("MeteorologicFeature", typeof(IMeteorologicFeature))
        {
        }

        #endregion
    }
}
