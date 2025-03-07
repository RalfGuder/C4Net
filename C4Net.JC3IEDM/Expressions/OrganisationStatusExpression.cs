using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity OrganisationStatus.
    /// </summary>
    public class OrganisationStatusExpression : BaseEntityExpression<OrganisationStatusExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column org_stat_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column org_stat_id.
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
        /// Expression for the property OperationalStatus that represents the column operat_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property OperationalStatus that represents the column operat_stat_code.
        /// </value>
        public ColumnExpression OperationalStatus 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property OperationalStatusQualifier that represents the column operat_stat_qual_code.
        /// </summary>
        /// <value>
        /// The value of the property OperationalStatusQualifier that represents the column operat_stat_qual_code.
        /// </value>
        public ColumnExpression OperationalStatusQualifier 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property Availability that represents the column avlbty_code.
        /// </summary>
        /// <value>
        /// The value of the property Availability that represents the column avlbty_code.
        /// </value>
        public ColumnExpression Availability 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property CommandAndControlRole that represents the column cmd_and_ctrl_role_code.
        /// </summary>
        /// <value>
        /// The value of the property CommandAndControlRole that represents the column cmd_and_ctrl_role_code.
        /// </value>
        public ColumnExpression CommandAndControlRole 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property CommitmentStatus that represents the column cmtmnt_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property CommitmentStatus that represents the column cmtmnt_stat_code.
        /// </value>
        public ColumnExpression CommitmentStatus 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property FireMode that represents the column fire_mode_code.
        /// </summary>
        /// <value>
        /// The value of the property FireMode that represents the column fire_mode_code.
        /// </value>
        public ColumnExpression FireMode 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property CbrnDressState that represents the column cbrn_dress_state_code.
        /// </summary>
        /// <value>
        /// The value of the property CbrnDressState that represents the column cbrn_dress_state_code.
        /// </value>
        public ColumnExpression CbrnDressState 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property RadiationDoseQuantity that represents the column rad_dose_qty.
        /// </summary>
        /// <value>
        /// The value of the property RadiationDoseQuantity that represents the column rad_dose_qty.
        /// </value>
        public ColumnExpression RadiationDoseQuantity 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property Readiness that represents the column rdns_code.
        /// </summary>
        /// <value>
        /// The value of the property Readiness that represents the column rdns_code.
        /// </value>
        public ColumnExpression Readiness 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property ReadinessDuration that represents the column rdns_dur.
        /// </summary>
        /// <value>
        /// The value of the property ReadinessDuration that represents the column rdns_dur.
        /// </value>
        public ColumnExpression ReadinessDuration 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property Reinforcement that represents the column reinforce_code.
        /// </summary>
        /// <value>
        /// The value of the property Reinforcement that represents the column reinforce_code.
        /// </value>
        public ColumnExpression Reinforcement 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property ReserveIndicator that represents the column reserve_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property ReserveIndicator that represents the column reserve_ind_code.
        /// </value>
        public ColumnExpression ReserveIndicator 
        { 
            get { return this.columns[13]; } 
        }
		
        /// <summary>
        /// Expression for the property Training that represents the column training_code.
        /// </summary>
        /// <value>
        /// The value of the property Training that represents the column training_code.
        /// </value>
        public ColumnExpression Training 
        { 
            get { return this.columns[14]; } 
        }
		
        /// <summary>
        /// Expression for the property UsageStatus that represents the column usage_stat_code.
        /// </summary>
        /// <value>
        /// The value of the property UsageStatus that represents the column usage_stat_code.
        /// </value>
        public ColumnExpression UsageStatus 
        { 
            get { return this.columns[15]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[16]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[17]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationStatusExpression"/> class.
        /// </summary>
        public OrganisationStatusExpression()
            : base("OrganisationStatus", typeof(IOrganisationStatus))
        {
        }

        #endregion
    }
}
