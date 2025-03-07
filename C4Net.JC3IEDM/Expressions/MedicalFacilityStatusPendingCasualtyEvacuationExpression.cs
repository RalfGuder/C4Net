using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity MedicalFacilityStatusPendingCasualtyEvacuation.
    /// </summary>
    public class MedicalFacilityStatusPendingCasualtyEvacuationExpression : BaseEntityExpression<MedicalFacilityStatusPendingCasualtyEvacuationExpression>
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
        /// Expression for the property Index that represents the column mfs_cas_evac_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column mfs_cas_evac_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property Destination that represents the column dest_code.
        /// </summary>
        /// <value>
        /// The value of the property Destination that represents the column dest_code.
        /// </value>
        public ColumnExpression Destination 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SittingCount that represents the column sitting_cnt.
        /// </summary>
        /// <value>
        /// The value of the property SittingCount that represents the column sitting_cnt.
        /// </value>
        public ColumnExpression SittingCount 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property StretcherCount that represents the column stretcher_cnt.
        /// </summary>
        /// <value>
        /// The value of the property StretcherCount that represents the column stretcher_cnt.
        /// </value>
        public ColumnExpression StretcherCount 
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
        /// Initializes a new instance of the <see cref="MedicalFacilityStatusPendingCasualtyEvacuationExpression"/> class.
        /// </summary>
        public MedicalFacilityStatusPendingCasualtyEvacuationExpression()
            : base("MedicalFacilityStatusPendingCasualtyEvacuation", typeof(IMedicalFacilityStatusPendingCasualtyEvacuation))
        {
        }

        #endregion
    }
}
