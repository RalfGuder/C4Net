using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity AircraftType.
    /// </summary>
    public class AircraftTypeExpression : BaseEntityExpression<AircraftTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column acft_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column acft_type_id.
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
        /// Expression for the property AirframeDesign that represents the column airframe_design_code.
        /// </summary>
        /// <value>
        /// The value of the property AirframeDesign that represents the column airframe_design_code.
        /// </value>
        public ColumnExpression AirframeDesign 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Model that represents the column model_code.
        /// </summary>
        /// <value>
        /// The value of the property Model that represents the column model_code.
        /// </value>
        public ColumnExpression Model 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Manning that represents the column manning_code.
        /// </summary>
        /// <value>
        /// The value of the property Manning that represents the column manning_code.
        /// </value>
        public ColumnExpression Manning 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MilitaryCivilian that represents the column mil_civ_code.
        /// </summary>
        /// <value>
        /// The value of the property MilitaryCivilian that represents the column mil_civ_code.
        /// </value>
        public ColumnExpression MilitaryCivilian 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property MainPurpose that represents the column main_purpose_code.
        /// </summary>
        /// <value>
        /// The value of the property MainPurpose that represents the column main_purpose_code.
        /// </value>
        public ColumnExpression MainPurpose 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property DesignRole that represents the column design_role_code.
        /// </summary>
        /// <value>
        /// The value of the property DesignRole that represents the column design_role_code.
        /// </value>
        public ColumnExpression DesignRole 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property DesignRange that represents the column design_range_code.
        /// </summary>
        /// <value>
        /// The value of the property DesignRange that represents the column design_range_code.
        /// </value>
        public ColumnExpression DesignRange 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property WeatherQualifier that represents the column weather_qual_code.
        /// </summary>
        /// <value>
        /// The value of the property WeatherQualifier that represents the column weather_qual_code.
        /// </value>
        public ColumnExpression WeatherQualifier 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property TrainingCategory that represents the column training_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property TrainingCategory that represents the column training_cat_code.
        /// </value>
        public ColumnExpression TrainingCategory 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property LoadCategory that represents the column load_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property LoadCategory that represents the column load_cat_code.
        /// </value>
        public ColumnExpression LoadCategory 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property TakeoffAndLanding that represents the column takeoff_and_lndg_code.
        /// </summary>
        /// <value>
        /// The value of the property TakeoffAndLanding that represents the column takeoff_and_lndg_code.
        /// </value>
        public ColumnExpression TakeoffAndLanding 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property WingSpanDimension that represents the column wing_span_dim.
        /// </summary>
        /// <value>
        /// The value of the property WingSpanDimension that represents the column wing_span_dim.
        /// </value>
        public ColumnExpression WingSpanDimension 
        { 
            get { return this.columns[13]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[14]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[15]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AircraftTypeExpression"/> class.
        /// </summary>
        public AircraftTypeExpression()
            : base("AircraftType", typeof(IAircraftType))
        {
        }

        #endregion
    }
}
