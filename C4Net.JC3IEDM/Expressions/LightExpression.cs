using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Light.
    /// </summary>
    public class LightExpression : BaseEntityExpression<LightExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column light_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column light_id.
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
        /// Expression for the property UpDatetime that represents the column up_dttm.
        /// </summary>
        /// <value>
        /// The value of the property UpDatetime that represents the column up_dttm.
        /// </value>
        public ColumnExpression UpDatetime 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property DownDatetime that represents the column down_dttm.
        /// </summary>
        /// <value>
        /// The value of the property DownDatetime that represents the column down_dttm.
        /// </value>
        public ColumnExpression DownDatetime 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property MoonPhase that represents the column moon_phase_code.
        /// </summary>
        /// <value>
        /// The value of the property MoonPhase that represents the column moon_phase_code.
        /// </value>
        public ColumnExpression MoonPhase 
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
        /// Initializes a new instance of the <see cref="LightExpression"/> class.
        /// </summary>
        public LightExpression()
            : base("Light", typeof(ILight))
        {
        }

        #endregion
    }
}
