using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity RadiologicalEvent.
    /// </summary>
    public class RadiologicalEventExpression : BaseEntityExpression<RadiologicalEventExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column radlgc_event_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column radlgc_event_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ReleaseCategory that represents the column release_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property ReleaseCategory that represents the column release_cat_code.
        /// </value>
        public ColumnExpression ReleaseCategory 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property IsotopeConcentrationRatio that represents the column isotope_cncntr_rat.
        /// </summary>
        /// <value>
        /// The value of the property IsotopeConcentrationRatio that represents the column isotope_cncntr_rat.
        /// </value>
        public ColumnExpression IsotopeConcentrationRatio 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[4]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="RadiologicalEventExpression"/> class.
        /// </summary>
        public RadiologicalEventExpression()
            : base("RadiologicalEvent", typeof(IRadiologicalEvent))
        {
        }

        #endregion
    }
}
