using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-ITEM-ASSOCIATION-STATUS that represents the table OBJ_ITEM_ASSOC_STAT.
	///
	/// A record of the perceived condition of a specific OBJECT-ITEM-ASSOCIATION as determined by the reporting organisation.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectItemAssociationStatus", "C4Net.JC3IEDM.Definitions.ObjectItemAssociationStatus.definition.xml")]
    public class ObjectItemAssociationStatus : IEntity, IObjectItemAssociationStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectItemAssociationStatusExpression _ = new ObjectItemAssociationStatusExpression();

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
		public decimal ObjectItemAssociationSubjectObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_obj_item_id
        /// </value>
		public decimal ObjectItemAssociationObjectObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_assoc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-ASSOCIATION for a subject OBJECT-ITEM and an object OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-ASSOCIATIONs for those OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_assoc_ix
        /// </value>
		public decimal ObjectItemAssociationIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_assoc_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-ASSOCIATION-STATUS for a specific OBJECT-ITEM-ASSOCIATION and to distinguish it from all other OBJECT-ITEM-ASSOCIATION-STATUSs for that OBJECT-ITEM-ASSOCIATION.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_assoc_stat_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that indicates if the status of a specific OBJECT-ITEM-ASSOCIATION-STATUS refers to the beginning or termination of the association.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public AssociationStatusCategoryEnum ObjectItemAssociationStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
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
