using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity MedicalFacilityStatusIntervalCasualtyGroup.
    /// </summary>
    public class MedicalFacilityStatusIntervalCasualtyGroupExpression : BaseEntityExpression<MedicalFacilityStatusIntervalCasualtyGroupExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property MedicalFacilityStatusId that represents the column mfs_id.
        /// </summary>
        /// <value>
        /// The value of the property MedicalFacilityStatusId that represents the column mfs_id.
        /// </value>
        public ColumnExpression MedicalFacilityStatusId 
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
        /// Expression for the property Index that represents the column mfs_intvl_cas_group_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column mfs_intvl_cas_group_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MedicalFacilityStatusIntervalCasualtyGroupCode that represents the column code.
        /// </summary>
        /// <value>
        /// The value of the property MedicalFacilityStatusIntervalCasualtyGroupCode that represents the column code.
        /// </value>
        public ColumnExpression MedicalFacilityStatusIntervalCasualtyGroupCode 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property CompletedSurgeryCount that represents the column completed_surgery_cnt.
        /// </summary>
        /// <value>
        /// The value of the property CompletedSurgeryCount that represents the column completed_surgery_cnt.
        /// </value>
        public ColumnExpression CompletedSurgeryCount 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property DeathCount that represents the column death_cnt.
        /// </summary>
        /// <value>
        /// The value of the property DeathCount that represents the column death_cnt.
        /// </value>
        public ColumnExpression DeathCount 
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
        /// Initializes a new instance of the <see cref="MedicalFacilityStatusIntervalCasualtyGroupExpression"/> class.
        /// </summary>
        public MedicalFacilityStatusIntervalCasualtyGroupExpression()
            : base("MedicalFacilityStatusIntervalCasualtyGroup", typeof(IMedicalFacilityStatusIntervalCasualtyGroup))
        {
        }

        #endregion
    }
}
