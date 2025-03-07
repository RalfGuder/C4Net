using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity PLAN-ORDER-HEADER-CONTENT that represents the table PLN_ORDR_HDR_CNTNT.
	///
	/// Introductory subject matter that applies to the entirety of a specific PLAN-ORDER.
    /// </summary>
    [Serializable]
    [DefinitionName("PlanOrderHeaderContent", "C4Net.JC3IEDM.Definitions.PlanOrderHeaderContent.definition.xml")]
    public class PlanOrderHeaderContent : IEntity, IPlanOrderHeaderContent
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly PlanOrderHeaderContentExpression _ = new PlanOrderHeaderContentExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pln_ordr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDERs.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_id
        /// </value>
		public decimal PlanOrderId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pln_ordr_hdr_cntnt_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific PLAN-ORDER-HEADER-CONTENT for a specific PLAN-ORDER and to distinguish it from all other PLAN-ORDER-HEADER-CONTENTs for that PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column pln_ordr_hdr_cntnt_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
		public string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column nickname_txt
		///
		/// The character string assigned to represent an alternative name for a specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column nickname_txt
        /// </value>
		public string NicknameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column serial_no_txt
		///
		/// The character string assigned to represent a sequential numerical identification of a specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column serial_no_txt
        /// </value>
		public string SerialNumberText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sponsor_type_txt
		///
		/// The character string assigned to represent the type of force, such as combined, joint, army, navy, marine, air force, or other functional command, to which a specific PLAN-ORDER applies.
        /// </summary>
        /// <value>
        /// Value of the column sponsor_type_txt
        /// </value>
		public string SponsorTypeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column time_zone_code
		///
		/// The specific value assigned to represent divisions of the Earth's surface in which standard time is kept as it applies to the specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column time_zone_code
        /// </value>
		public PlanOrderHeaderContentTimeZoneEnum? TimeZone { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dttm
		///
		/// The character string representing the point in time when the PLAN-ORDER-HEADER-CONTENT is defined.
        /// </summary>
        /// <value>
        /// Value of the column dttm
        /// </value>
		public string Datetime { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column msg_ref_no_txt
		///
		/// The character string assigned for use in acknowledging a specific PLAN-ORDER in the clear.
        /// </summary>
        /// <value>
        /// Value of the column msg_ref_no_txt
        /// </value>
		public string MessageReferenceNumberText { get; set; }
		
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
        /// Gets or sets the value of the column place_of_issue_txt
		///
		/// The character string assigned to represent the place of issue, which may be in code, for a specific PLAN-ORDER.
        /// </summary>
        /// <value>
        /// Value of the column place_of_issue_txt
        /// </value>
		public string PlaceOfIssueText { get; set; }
		
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
