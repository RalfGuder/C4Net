using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity COMPONENT-HEADER-CONTENT that represents the table CMPNT_HDR_CNTNT.
	///
	/// Introductory subject matter intended to identify an element of a plan or order.
    /// </summary>
    [Serializable]
    [DefinitionName("ComponentHeaderContent", "C4Net.JC3IEDM.Definitions.ComponentHeaderContent.definition.xml")]
    public class ComponentHeaderContent : IEntity, IComponentHeaderContent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ComponentHeaderContentExpression _ = new ComponentHeaderContentExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cmpnt_hdr_cntnt_id
		///
		/// The unique value, or set of characters, assigned to represent a specific COMPONENT-HEADER-CONTENT and to distinguish it from all other COMPONENT-HEADER-CONTENTs.
        /// </summary>
        /// <value>
        /// Value of the column cmpnt_hdr_cntnt_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column topic_heading_txt
		///
		/// The character string assigned to represent a user-defined topic in a specific COMPONENT-HEADER-CONTENT.
        /// </summary>
        /// <value>
        /// Value of the column topic_heading_txt
        /// </value>
		public string TopicHeadingText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_clsfc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific SECURITY-CLASSIFICATION and to distinguish it from all other SECURITY-CLASSIFICATIONs.
        /// </summary>
        /// <value>
        /// Value of the column security_clsfc_id
        /// </value>
		public decimal? SecurityClassificationId { get; set; }
		
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
