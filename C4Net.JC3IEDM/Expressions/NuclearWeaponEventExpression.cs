using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity NuclearWeaponEvent.
    /// </summary>
    public class NuclearWeaponEventExpression : BaseEntityExpression<NuclearWeaponEventExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column nuc_weapon_event_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column nuc_weapon_event_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property FlashToBangDuration that represents the column flash_to_bang_dur.
        /// </summary>
        /// <value>
        /// The value of the property FlashToBangDuration that represents the column flash_to_bang_dur.
        /// </value>
        public ColumnExpression FlashToBangDuration 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property CraterPresence that represents the column crater_prsnc_code.
        /// </summary>
        /// <value>
        /// The value of the property CraterPresence that represents the column crater_prsnc_code.
        /// </value>
        public ColumnExpression CraterPresence 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CraterWidthDimension that represents the column crater_width_dim.
        /// </summary>
        /// <value>
        /// The value of the property CraterWidthDimension that represents the column crater_width_dim.
        /// </value>
        public ColumnExpression CraterWidthDimension 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property YieldGroup that represents the column yield_group_code.
        /// </summary>
        /// <value>
        /// The value of the property YieldGroup that represents the column yield_group_code.
        /// </value>
        public ColumnExpression YieldGroup 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property YieldQuantity that represents the column yield_qty.
        /// </summary>
        /// <value>
        /// The value of the property YieldQuantity that represents the column yield_qty.
        /// </value>
        public ColumnExpression YieldQuantity 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[7]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="NuclearWeaponEventExpression"/> class.
        /// </summary>
        public NuclearWeaponEventExpression()
            : base("NuclearWeaponEvent", typeof(INuclearWeaponEvent))
        {
        }

        #endregion
    }
}
