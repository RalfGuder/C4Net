using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity EngineeringCapability.
    /// </summary>
    public class EngineeringCapabilityExpression : BaseEntityExpression<EngineeringCapabilityExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column eng_capab_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column eng_capab_id.
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
        /// Expression for the property Descriptor that represents the column dscpt_code.
        /// </summary>
        /// <value>
        /// The value of the property Descriptor that represents the column dscpt_code.
        /// </value>
        public ColumnExpression Descriptor 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property FacilityHeightDimension that represents the column fac_height_dim.
        /// </summary>
        /// <value>
        /// The value of the property FacilityHeightDimension that represents the column fac_height_dim.
        /// </value>
        public ColumnExpression FacilityHeightDimension 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property FacilityLengthDimension that represents the column fac_length_dim.
        /// </summary>
        /// <value>
        /// The value of the property FacilityLengthDimension that represents the column fac_length_dim.
        /// </value>
        public ColumnExpression FacilityLengthDimension 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property FacilityWidthDimension that represents the column fac_width_dim.
        /// </summary>
        /// <value>
        /// The value of the property FacilityWidthDimension that represents the column fac_width_dim.
        /// </value>
        public ColumnExpression FacilityWidthDimension 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property FacilityTypeId that represents the column fac_type_id.
        /// </summary>
        /// <value>
        /// The value of the property FacilityTypeId that represents the column fac_type_id.
        /// </value>
        public ColumnExpression FacilityTypeId 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[8]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="EngineeringCapabilityExpression"/> class.
        /// </summary>
        public EngineeringCapabilityExpression()
            : base("EngineeringCapability", typeof(IEngineeringCapability))
        {
        }

        #endregion
    }
}
