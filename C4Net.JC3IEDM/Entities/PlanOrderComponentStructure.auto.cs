using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PLAN-ORDER-COMPONENT-STRUCTURE that represents the table POC_STRUCT.
	///
	/// A relationship of a PLAN-ORDER-COMPONENT as a subject and a PLAN-ORDER-COMPONENT as an object to allow multilayer relationships among elements of the same or different instances of a PLAN-ORDER.
    /// </summary>
    [Serializable]
    [DefinitionName("PlanOrderComponentStructure", "C4Net.JC3IEDM.Definitions.PlanOrderComponentStructure.definition.xml")]
    public class PlanOrderComponentStructure : IEntity, IPlanOrderComponentStructure
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly PlanOrderComponentStructureExpression _ = new PlanOrderComponentStructureExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column poc_struct_subj_pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column poc_struct_subj_pln_ordr_id
        /// </value>
		public decimal SubjectPlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_struct_subj_poc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT for a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDER-COMPONENTs for that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column poc_struct_subj_poc_ix
        /// </value>
		public decimal SubjectPlanOrderComponentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_struct_obj_pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column poc_struct_obj_pln_ordr_id
        /// </value>
		public decimal ObjectPlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_struct_obj_poc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT for a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDER-COMPONENTs for that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column poc_struct_obj_poc_ix
        /// </value>
		public decimal ObjectPlanOrderComponentIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column poc_struct_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-COMPONENT-STRUCTURE for a specific PLAN-ORDER-COMPONENT and to distinguish it from all other PLAN-ORDER-COMPONENT-STRUCTUREs for that PLAN-ORDER-COMPONENT.
        /// </summary>
        /// <value>
        /// Value of the column poc_struct_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of relationship between a subject PLAN-ORDER-COMPONENT and an object PLAN-ORDER-COMPONENT in a specific PLAN-ORDER-COMPONENT-STRUCTURE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public PlanOrderComponentStructureCategoryEnum PlanOrderComponentStructureCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when a PLAN-ORDER-COMPONENT-STRUCTURE is defined.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
		public string Datetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}
