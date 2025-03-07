using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity FireCapability.
    /// </summary>
    public class FireCapabilityExpression : BaseEntityExpression<FireCapabilityExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column fire_capab_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column fire_capab_id.
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
        /// Expression for the property WeaponType that represents the column weapon_type_code.
        /// </summary>
        /// <value>
        /// The value of the property WeaponType that represents the column weapon_type_code.
        /// </value>
        public ColumnExpression WeaponType 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property AmmunitionTypeId that represents the column ammo_type_id.
        /// </summary>
        /// <value>
        /// The value of the property AmmunitionTypeId that represents the column ammo_type_id.
        /// </value>
        public ColumnExpression AmmunitionTypeId 
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
        /// Initializes a new instance of the <see cref="FireCapabilityExpression"/> class.
        /// </summary>
        public FireCapabilityExpression()
            : base("FireCapability", typeof(IFireCapability))
        {
        }

        #endregion
    }
}
