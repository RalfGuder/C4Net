using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-ITEM-ASSOCIATION that represents the table OBJ_ITEM_ASSOC.
	///
	/// A relationship of an OBJECT-ITEM as a subject with another OBJECT-ITEM as an object.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectItemAssociation", "C4Net.JC3IEDM.Definitions.ObjectItemAssociation.definition.xml")]
    public class ObjectItemAssociation : IEntity, IObjectItemAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectItemAssociationExpression _ = new ObjectItemAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column subj_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column subj_obj_item_id
        /// </value>
		public decimal SubjectObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_obj_item_id
        /// </value>
		public decimal ObjectObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-ASSOCIATION for a subject OBJECT-ITEM and an object OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-ASSOCIATIONs for those OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_assoc_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the type of relationship between the subject OBJECT-ITEM and the object OBJECT-ITEM in a specific OBJECT-ITEM-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ObjectItemAssociationCategoryEnum ObjectItemAssociationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed type of relationship between the subject OBJECT-ITEM that is an ORGANISATION and the object OBJECT-ITEM that is an ORGANISATION in a specific OBJECT-ITEM-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public ObjectItemAssociationSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_task_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_task_id
        /// </value>
		public decimal? ActionTaskId { get; set; }
		
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
