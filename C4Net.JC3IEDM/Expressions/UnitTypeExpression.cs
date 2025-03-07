using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity UnitType.
    /// </summary>
    public class UnitTypeExpression : BaseEntityExpression<UnitTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column unit_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column unit_type_id.
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
        /// Expression for the property ArmCategory that represents the column arm_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property ArmCategory that represents the column arm_cat_code.
        /// </value>
        public ColumnExpression ArmCategory 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property ArmSpecialisation that represents the column arm_spclsn_code.
        /// </summary>
        /// <value>
        /// The value of the property ArmSpecialisation that represents the column arm_spclsn_code.
        /// </value>
        public ColumnExpression ArmSpecialisation 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SupplementarySpecialisation that represents the column suppl_spclsn_code.
        /// </summary>
        /// <value>
        /// The value of the property SupplementarySpecialisation that represents the column suppl_spclsn_code.
        /// </value>
        public ColumnExpression SupplementarySpecialisation 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property GeneralMobility that represents the column gen_mob_code.
        /// </summary>
        /// <value>
        /// The value of the property GeneralMobility that represents the column gen_mob_code.
        /// </value>
        public ColumnExpression GeneralMobility 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property Qualifier that represents the column qual_code.
        /// </summary>
        /// <value>
        /// The value of the property Qualifier that represents the column qual_code.
        /// </value>
        public ColumnExpression Qualifier 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property Size that represents the column size_code.
        /// </summary>
        /// <value>
        /// The value of the property Size that represents the column size_code.
        /// </value>
        public ColumnExpression Size 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property PrincipalEquipmentTypeId that represents the column principal_eqpt_type_id.
        /// </summary>
        /// <value>
        /// The value of the property PrincipalEquipmentTypeId that represents the column principal_eqpt_type_id.
        /// </value>
        public ColumnExpression PrincipalEquipmentTypeId 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property SupportedMilitaryOrganisationTypeId that represents the column supported_mil_org_type_id.
        /// </summary>
        /// <value>
        /// The value of the property SupportedMilitaryOrganisationTypeId that represents the column supported_mil_org_type_id.
        /// </value>
        public ColumnExpression SupportedMilitaryOrganisationTypeId 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[11]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTypeExpression"/> class.
        /// </summary>
        public UnitTypeExpression()
            : base("UnitType", typeof(IUnitType))
        {
        }

        #endregion
    }
}
