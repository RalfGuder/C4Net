using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PlanOrderHeaderContent.
    /// </summary>
    public class PlanOrderHeaderContentExpression : BaseEntityExpression<PlanOrderHeaderContentExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property PlanOrderId that represents the column pln_ordr_id.
        /// </summary>
        /// <value>
        /// The value of the property PlanOrderId that represents the column pln_ordr_id.
        /// </value>
        public ColumnExpression PlanOrderId 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Index that represents the column pln_ordr_hdr_cntnt_ix.
        /// </summary>
        /// <value>
        /// The value of the property Index that represents the column pln_ordr_hdr_cntnt_ix.
        /// </value>
        public ColumnExpression Index 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property NameText that represents the column name_txt.
        /// </summary>
        /// <value>
        /// The value of the property NameText that represents the column name_txt.
        /// </value>
        public ColumnExpression NameText 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property NicknameText that represents the column nickname_txt.
        /// </summary>
        /// <value>
        /// The value of the property NicknameText that represents the column nickname_txt.
        /// </value>
        public ColumnExpression NicknameText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property SerialNumberText that represents the column serial_no_txt.
        /// </summary>
        /// <value>
        /// The value of the property SerialNumberText that represents the column serial_no_txt.
        /// </value>
        public ColumnExpression SerialNumberText 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property SponsorTypeText that represents the column sponsor_type_txt.
        /// </summary>
        /// <value>
        /// The value of the property SponsorTypeText that represents the column sponsor_type_txt.
        /// </value>
        public ColumnExpression SponsorTypeText 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property TimeZone that represents the column time_zone_code.
        /// </summary>
        /// <value>
        /// The value of the property TimeZone that represents the column time_zone_code.
        /// </value>
        public ColumnExpression TimeZone 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property Datetime that represents the column dttm.
        /// </summary>
        /// <value>
        /// The value of the property Datetime that represents the column dttm.
        /// </value>
        public ColumnExpression Datetime 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property MessageReferenceNumberText that represents the column msg_ref_no_txt.
        /// </summary>
        /// <value>
        /// The value of the property MessageReferenceNumberText that represents the column msg_ref_no_txt.
        /// </value>
        public ColumnExpression MessageReferenceNumberText 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property SecurityClassificationId that represents the column security_clsfc_id.
        /// </summary>
        /// <value>
        /// The value of the property SecurityClassificationId that represents the column security_clsfc_id.
        /// </value>
        public ColumnExpression SecurityClassificationId 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property PlaceOfIssueText that represents the column place_of_issue_txt.
        /// </summary>
        /// <value>
        /// The value of the property PlaceOfIssueText that represents the column place_of_issue_txt.
        /// </value>
        public ColumnExpression PlaceOfIssueText 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[12]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanOrderHeaderContentExpression"/> class.
        /// </summary>
        public PlanOrderHeaderContentExpression()
            : base("PlanOrderHeaderContent", typeof(IPlanOrderHeaderContent))
        {
        }

        #endregion
    }
}
