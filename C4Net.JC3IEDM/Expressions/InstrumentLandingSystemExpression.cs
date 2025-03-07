using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity InstrumentLandingSystem.
    /// </summary>
    public class InstrumentLandingSystemExpression : BaseEntityExpression<InstrumentLandingSystemExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column inst_lndg_sys_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column inst_lndg_sys_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property BeamWidthDimension that represents the column beam_width_dim.
        /// </summary>
        /// <value>
        /// The value of the property BeamWidthDimension that represents the column beam_width_dim.
        /// </value>
        public ColumnExpression BeamWidthDimension 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property GlidePathAngle that represents the column glide_path_angle.
        /// </summary>
        /// <value>
        /// The value of the property GlidePathAngle that represents the column glide_path_angle.
        /// </value>
        public ColumnExpression GlidePathAngle 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MagneticVariationAngle that represents the column magn_varn_angle.
        /// </summary>
        /// <value>
        /// The value of the property MagneticVariationAngle that represents the column magn_varn_angle.
        /// </value>
        public ColumnExpression MagneticVariationAngle 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SlavedVariationAngle that represents the column slaved_varn_angle.
        /// </summary>
        /// <value>
        /// The value of the property SlavedVariationAngle that represents the column slaved_varn_angle.
        /// </value>
        public ColumnExpression SlavedVariationAngle 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property BearingAngle that represents the column brng_angle.
        /// </summary>
        /// <value>
        /// The value of the property BearingAngle that represents the column brng_angle.
        /// </value>
        public ColumnExpression BearingAngle 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property ThresholdCrossingHeightDimension that represents the column thrsh_crsn_height_dim.
        /// </summary>
        /// <value>
        /// The value of the property ThresholdCrossingHeightDimension that represents the column thrsh_crsn_height_dim.
        /// </value>
        public ColumnExpression ThresholdCrossingHeightDimension 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property LocaliserDistanceDimension that represents the column localizer_dist_dim.
        /// </summary>
        /// <value>
        /// The value of the property LocaliserDistanceDimension that represents the column localizer_dist_dim.
        /// </value>
        public ColumnExpression LocaliserDistanceDimension 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property DistanceMeasuringEquipmentDistanceDimension that represents the column dist_mesn_eqpt_dist_dim.
        /// </summary>
        /// <value>
        /// The value of the property DistanceMeasuringEquipmentDistanceDimension that represents the column dist_mesn_eqpt_dist_dim.
        /// </value>
        public ColumnExpression DistanceMeasuringEquipmentDistanceDimension 
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
        /// Initializes a new instance of the <see cref="InstrumentLandingSystemExpression"/> class.
        /// </summary>
        public InstrumentLandingSystemExpression()
            : base("InstrumentLandingSystem", typeof(IInstrumentLandingSystem))
        {
        }

        #endregion
    }
}
