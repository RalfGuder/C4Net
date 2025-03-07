using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity ChemicalBiologicalEvent.
    /// </summary>
    public class ChemicalBiologicalEventExpression : BaseEntityExpression<ChemicalBiologicalEventExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column chm_bio_event_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column chm_bio_event_id.
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
        /// Expression for the property ReleaseCategory that represents the column release_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property ReleaseCategory that represents the column release_cat_code.
        /// </value>
        public ColumnExpression ReleaseCategory 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property SpillSize that represents the column spill_size_code.
        /// </summary>
        /// <value>
        /// The value of the property SpillSize that represents the column spill_size_code.
        /// </value>
        public ColumnExpression SpillSize 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ReleaseHeightDimension that represents the column release_height_dim.
        /// </summary>
        /// <value>
        /// The value of the property ReleaseHeightDimension that represents the column release_height_dim.
        /// </value>
        public ColumnExpression ReleaseHeightDimension 
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
        /// Expression for the property AtmosphericParticleConcentrationQuantity that represents the column atmspc_prtcl_cncntr_qty.
        /// </summary>
        /// <value>
        /// The value of the property AtmosphericParticleConcentrationQuantity that represents the column atmspc_prtcl_cncntr_qty.
        /// </value>
        public ColumnExpression AtmosphericParticleConcentrationQuantity 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property MassFractionConcentrationQuantity that represents the column mass_frac_cncntr_qty.
        /// </summary>
        /// <value>
        /// The value of the property MassFractionConcentrationQuantity that represents the column mass_frac_cncntr_qty.
        /// </value>
        public ColumnExpression MassFractionConcentrationQuantity 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[10]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ChemicalBiologicalEventExpression"/> class.
        /// </summary>
        public ChemicalBiologicalEventExpression()
            : base("ChemicalBiologicalEvent", typeof(IChemicalBiologicalEvent))
        {
        }

        #endregion
    }
}
