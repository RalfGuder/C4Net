using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PersonStatus.
    /// </summary>
    public class PersonStatusExpression : BaseEntityExpression<PersonStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column pers_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column pers_stat_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ObjectItemStatusIndex that represents the column obj_item_stat_ix.
        /// </summary>
        /// <value>
        /// The value of the property ObjectItemStatusIndex that represents the column obj_item_stat_ix.
        /// </value>
        public ColumnExpression ObjectItemStatusIndex 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property DutyStatus that represents the column duty_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property DutyStatus that represents the column duty_stat_code.
        /// </value>
        public ColumnExpression DutyStatus 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property PhysicalStatus that represents the column physcl_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property PhysicalStatus that represents the column physcl_stat_code.
        /// </value>
        public ColumnExpression PhysicalStatus 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property PhysicalStatusQualifier that represents the column physcl_stat_qual_code.
        /// </summary>
        /// <value>
        /// The value of the property PhysicalStatusQualifier that represents the column physcl_stat_qual_code.
        /// </value>
        public ColumnExpression PhysicalStatusQualifier 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property RadiationDoseQuantity that represents the column rad_dose_qty.
        /// </summary>
        /// <value>
        /// The value of the property RadiationDoseQuantity that represents the column rad_dose_qty.
        /// </value>
        public ColumnExpression RadiationDoseQuantity 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property ReserveIndicator that represents the column reserve_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property ReserveIndicator that represents the column reserve_ind_code.
        /// </value>
        public ColumnExpression ReserveIndicator 
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
        /// Initializes a new instance of the <see cref="PersonStatusExpression"/> class.
        /// </summary>
        public PersonStatusExpression()
            : base("PersonStatus", typeof(IPersonStatus))
        {
        }

        #endregion
    }
}
