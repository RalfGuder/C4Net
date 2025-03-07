using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PlanOrderAssociation that represents the table POA
	/// 
	/// A relationship of a PLAN-ORDER as a subject with another PLAN-ORDER as an object.
    /// </summary>
	[EntId(10000347)]
    [EntName("PLAN-ORDER-ASSOCIATION")]
    [EntTableName("POA")]
    [EntDepth(1)]
    public interface IPlanOrderAssociation
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column poa_subj_pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column poa_subj_pln_ordr_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("plan-order-association-subject-plan-order-id")]
		[AttrColumnName("poa_subj_pln_ordr_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000933)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SubjectPlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poa_obj_pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column poa_obj_pln_ordr_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("plan-order-association-object-plan-order-id")]
		[AttrColumnName("poa_obj_pln_ordr_id")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000933)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectPlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poa_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-ASSOCIATION for a subject PLAN-ORDER and an object PLAN-ORDER and to distinguish it from all other PLAN-ORDER-ASSOCIATIONs for those PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column poa_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("plan-order-association-index")]
		[AttrColumnName("poa_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of relationship between a subject PLAN-ORDER and an object PLAN-ORDER in a specific PLAN-ORDER-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("plan-order-association-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100004387)]
        [DataLength(6)]
        [DataDecimals(0)]
        PlanOrderAssociationCategoryEnum PlanOrderAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when a specific PLAN-ORDER-ASSOCIATION is established.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
        [AttrIx(100005)]
		[AttrName("plan-order-association-datetime")]
		[AttrColumnName("dttm")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100002000)]
        [DataLength(18)]
        [DataDecimals(0)]
        string Datetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000913)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
