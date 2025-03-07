using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity RadioactiveEvent.
    /// </summary>
    public class RadioactiveEventExpression : BaseEntityExpression<RadioactiveEventExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column radact_event_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column radact_event_id.
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
        /// Expression for the property DoseQuantity that represents the column dose_qty.
        /// </summary>
        /// <value>
        /// The value of the property DoseQuantity that represents the column dose_qty.
        /// </value>
        public ColumnExpression DoseQuantity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property DoseRate that represents the column dose_rate.
        /// </summary>
        /// <value>
        /// The value of the property DoseRate that represents the column dose_rate.
        /// </value>
        public ColumnExpression DoseRate 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property DoseRateTrend that represents the column dose_rate_trend_code.
        /// </summary>
        /// <value>
        /// The value of the property DoseRateTrend that represents the column dose_rate_trend_code.
        /// </value>
        public ColumnExpression DoseRateTrend 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property VolumeConcentrationQuantity that represents the column vol_cncntr_qty.
        /// </summary>
        /// <value>
        /// The value of the property VolumeConcentrationQuantity that represents the column vol_cncntr_qty.
        /// </value>
        public ColumnExpression VolumeConcentrationQuantity 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property SurfaceDepositionQuantity that represents the column surf_dep_qty.
        /// </summary>
        /// <value>
        /// The value of the property SurfaceDepositionQuantity that represents the column surf_dep_qty.
        /// </value>
        public ColumnExpression SurfaceDepositionQuantity 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property RelativeDecayRate that represents the column rel_decay_rate_code.
        /// </summary>
        /// <value>
        /// The value of the property RelativeDecayRate that represents the column rel_decay_rate_code.
        /// </value>
        public ColumnExpression RelativeDecayRate 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[9]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioactiveEventExpression"/> class.
        /// </summary>
        public RadioactiveEventExpression()
            : base("RadioactiveEvent", typeof(IRadioactiveEvent))
        {
        }

        #endregion
    }
}
