using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity EquipmentType.
    /// </summary>
    public class EquipmentTypeExpression : BaseEntityExpression<EquipmentTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column eqpt_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column eqpt_type_id.
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
        /// Expression for the property LoadedWeightQuantity that represents the column loaded_wt_qty.
        /// </summary>
        /// <value>
        /// The value of the property LoadedWeightQuantity that represents the column loaded_wt_qty.
        /// </value>
        public ColumnExpression LoadedWeightQuantity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property UnloadedWeightQuantity that represents the column unloaded_wt_qty.
        /// </summary>
        /// <value>
        /// The value of the property UnloadedWeightQuantity that represents the column unloaded_wt_qty.
        /// </value>
        public ColumnExpression UnloadedWeightQuantity 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumHeightDimension that represents the column max_height_dim.
        /// </summary>
        /// <value>
        /// The value of the property MaximumHeightDimension that represents the column max_height_dim.
        /// </value>
        public ColumnExpression MaximumHeightDimension 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumLengthDimension that represents the column max_length_dim.
        /// </summary>
        /// <value>
        /// The value of the property MaximumLengthDimension that represents the column max_length_dim.
        /// </value>
        public ColumnExpression MaximumLengthDimension 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property MaximumWidthDimension that represents the column max_width_dim.
        /// </summary>
        /// <value>
        /// The value of the property MaximumWidthDimension that represents the column max_width_dim.
        /// </value>
        public ColumnExpression MaximumWidthDimension 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property FuelCapacityQuantity that represents the column fuel_cap_qty.
        /// </summary>
        /// <value>
        /// The value of the property FuelCapacityQuantity that represents the column fuel_cap_qty.
        /// </value>
        public ColumnExpression FuelCapacityQuantity 
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
        /// Initializes a new instance of the <see cref="EquipmentTypeExpression"/> class.
        /// </summary>
        public EquipmentTypeExpression()
            : base("EquipmentType", typeof(IEquipmentType))
        {
        }

        #endregion
    }
}
