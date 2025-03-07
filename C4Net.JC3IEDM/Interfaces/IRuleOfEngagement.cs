using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity RuleOfEngagement that represents the table ROE
	/// 
	/// A specification of mandatory guidance for the way a given activity is to be executed.
    /// </summary>
	[EntId(10000116)]
    [EntName("RULE-OF-ENGAGEMENT")]
    [EntTableName("ROE")]
    [EntDepth(2)]
    public interface IRuleOfEngagement
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column roe_id
		///
		/// The unique value, or set of characters, assigned to represent a specific RULE-OF-ENGAGEMENT and to distinguish it from all other RULE-OF-ENGAGEMENTs.
        /// </summary>
        /// <value>
        /// Value of the column roe_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("rule-of-engagement-id")]
		[AttrColumnName("roe_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000907)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent the name of a specific RULE-OF-ENGAGEMENT.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        [AttrIx(100002)]
		[AttrName("rule-of-engagement-name-text")]
		[AttrColumnName("name_txt")]
        [AttrSeqnr(2)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column descr_txt
		///
		/// The character string assigned to describe a specific RULE-OF-ENGAGEMENT.
        /// </summary>
        /// <value>
        /// Value of the column descr_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("rule-of-engagement-description-text")]
		[AttrColumnName("descr_txt")]
        [AttrSeqnr(3)]
        [Mandatory]
        [DomId(100001500)]
        [DataLength(255)]
        [DataDecimals(0)]
        string DescriptionText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column owning_org_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column owning_org_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("owning-organisation-id")]
		[AttrColumnName("owning_org_id")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? OwningOrganisationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(5)]
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
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(6)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
