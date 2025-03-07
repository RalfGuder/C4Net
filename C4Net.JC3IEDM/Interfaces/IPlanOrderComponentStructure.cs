using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PlanOrderComponentStructure that represents the table POC_STRUCT
	/// 
	/// A relationship of a PLAN-ORDER-COMPONENT as a subject and a PLAN-ORDER-COMPONENT as an object to allow multilayer relationships among elements of the same or different instances of a PLAN-ORDER.
    /// </summary>
	[EntId(10000351)]
    [EntName("PLAN-ORDER-COMPONENT-STRUCTURE")]
    [EntTableName("POC_STRUCT")]
    [EntDepth(2)]
    public interface IPlanOrderComponentStructure
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column poc_struct_subj_pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column poc_struct_subj_pln_ordr_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("plan-order-component-structure-subject-plan-order-id")]
		[AttrColumnName("poc_struct_subj_pln_ordr_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000933)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SubjectPlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_struct_subj_poc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT for a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDER-COMPONENTs for that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column poc_struct_subj_poc_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("plan-order-component-structure-subject-plan-order-component-index")]
		[AttrColumnName("poc_struct_subj_poc_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SubjectPlanOrderComponentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_struct_obj_pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column poc_struct_obj_pln_ordr_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("plan-order-component-structure-object-plan-order-id")]
		[AttrColumnName("poc_struct_obj_pln_ordr_id")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000933)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectPlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_struct_obj_poc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT for a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDER-COMPONENTs for that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column poc_struct_obj_poc_ix
        /// </value>
        [AttrIx(100004)]
		[AttrName("plan-order-component-structure-object-plan-order-component-index")]
		[AttrColumnName("poc_struct_obj_poc_ix")]
        [AttrSeqnr(4)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectPlanOrderComponentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_struct_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT-STRUCTURE for a specific PLAN-ORDER-COMPONENT and to distinguish it from all other PLAN-ORDER-COMPONENT-STRUCTUREs for that PLAN-ORDER-COMPONENT.
        /// </summary>
        /// <value>
        /// Value of the column poc_struct_ix
        /// </value>
        [AttrIx(100005)]
		[AttrName("plan-order-component-structure-index")]
		[AttrColumnName("poc_struct_ix")]
        [AttrSeqnr(5)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of relationship between a subject PLAN-ORDER-COMPONENT and an object PLAN-ORDER-COMPONENT in a specific PLAN-ORDER-COMPONENT-STRUCTURE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("plan-order-component-structure-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100004389)]
        [DataLength(6)]
        [DataDecimals(0)]
        PlanOrderComponentStructureCategoryEnum PlanOrderComponentStructureCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when a PLAN-ORDER-COMPONENT-STRUCTURE is defined.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
        [AttrIx(100007)]
		[AttrName("plan-order-component-structure-datetime")]
		[AttrColumnName("dttm")]
        [AttrSeqnr(7)]
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
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
