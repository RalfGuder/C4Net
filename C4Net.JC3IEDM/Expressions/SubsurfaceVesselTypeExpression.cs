using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity SubsurfaceVesselType.
    /// </summary>
    public class SubsurfaceVesselTypeExpression : BaseEntityExpression<SubsurfaceVesselTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column subsurf_vessel_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column subsurf_vessel_type_id.
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
        /// Expression for the property DivedDisplacementQuantity that represents the column dived_displ_qty.
        /// </summary>
        /// <value>
        /// The value of the property DivedDisplacementQuantity that represents the column dived_displ_qty.
        /// </value>
        public ColumnExpression DivedDisplacementQuantity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property SpeedCavitationQuantity that represents the column speed_cavitation_qty.
        /// </summary>
        /// <value>
        /// The value of the property SpeedCavitationQuantity that represents the column speed_cavitation_qty.
        /// </value>
        public ColumnExpression SpeedCavitationQuantity 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property TorpedoLoadingGearIndicator that represents the column torpedo_loading_gear_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property TorpedoLoadingGearIndicator that represents the column torpedo_loading_gear_ind_code.
        /// </value>
        public ColumnExpression TorpedoLoadingGearIndicator 
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
        /// Initializes a new instance of the <see cref="SubsurfaceVesselTypeExpression"/> class.
        /// </summary>
        public SubsurfaceVesselTypeExpression()
            : base("SubsurfaceVesselType", typeof(ISubsurfaceVesselType))
        {
        }

        #endregion
    }
}
