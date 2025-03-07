using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-FUNCTIONAL-ASSOCIATION that represents the table ACT_FUNCTL_ASSOC.
	///
	/// A relationship of an ACTION as a subject with another ACTION as an object in order to specify functional dependence.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionFunctionalAssociation", "C4Net.JC3IEDM.Definitions.ActionFunctionalAssociation.definition.xml")]
    public class ActionFunctionalAssociation : IEntity, IActionFunctionalAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionFunctionalAssociationExpression _ = new ActionFunctionalAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subj_act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column subj_act_id
        /// </value>
		public decimal SubjectActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column obj_act_id
        /// </value>
		public decimal ObjectActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_functl_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-FUNCTIONAL-ASSOCIATION for a specific subject ACTION and a specific object ACTION and to distinguish it from all other ACTION-FUNCTIONAL-ASSOCIATIONs for those ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_functl_assoc_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of relationship of subject ACTION to object ACTION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionFunctionalAssociationCategoryEnum ActionFunctionalAssociationCategory { get; set; }
		
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
