using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Facility.
    /// </summary>
    public class FacilityExpression : BaseEntityExpression<FacilityExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column fac_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column fac_id.
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
        /// Expression for the property PrimaryConstructionMaterial that represents the column prim_const_matrl_code.
        /// </summary>
        /// <value>
        /// The value of the property PrimaryConstructionMaterial that represents the column prim_const_matrl_code.
        /// </value>
        public ColumnExpression PrimaryConstructionMaterial 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property BaseIdentificationCodeText that represents the column base_identific_code_txt.
        /// </summary>
        /// <value>
        /// The value of the property BaseIdentificationCodeText that represents the column base_identific_code_txt.
        /// </value>
        public ColumnExpression BaseIdentificationCodeText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property HeightDimension that represents the column height_dim.
        /// </summary>
        /// <value>
        /// The value of the property HeightDimension that represents the column height_dim.
        /// </value>
        public ColumnExpression HeightDimension 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property LengthDimension that represents the column length_dim.
        /// </summary>
        /// <value>
        /// The value of the property LengthDimension that represents the column length_dim.
        /// </value>
        public ColumnExpression LengthDimension 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property WidthDimension that represents the column width_dim.
        /// </summary>
        /// <value>
        /// The value of the property WidthDimension that represents the column width_dim.
        /// </value>
        public ColumnExpression WidthDimension 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property MajorBuildingTypeId that represents the column fac_major_building_type_id.
        /// </summary>
        /// <value>
        /// The value of the property MajorBuildingTypeId that represents the column fac_major_building_type_id.
        /// </value>
        public ColumnExpression MajorBuildingTypeId 
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
        /// Initializes a new instance of the <see cref="FacilityExpression"/> class.
        /// </summary>
        public FacilityExpression()
            : base("Facility", typeof(IFacility))
        {
        }

        #endregion
    }
}
