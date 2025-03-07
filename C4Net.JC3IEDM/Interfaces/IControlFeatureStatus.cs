using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ControlFeatureStatus that represents the table CFEAT_STAT
	/// 
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific CONTROL-FEATURE.
    /// </summary>
	[EntId(10000132)]
    [EntName("CONTROL-FEATURE-STATUS")]
    [EntTableName("CFEAT_STAT")]
    [EntDepth(4)]
    public interface IControlFeatureStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cfeat_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column cfeat_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("control-feature-status-id")]
		[AttrColumnName("cfeat_stat_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-item-status-index")]
		[AttrColumnName("obj_item_stat_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column invstg_stat_code
		///
		/// The specific value that represents the investigation status of the site encompassed by a specific CONTROL-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column invstg_stat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("control-feature-status-investigation-status-code")]
		[AttrColumnName("invstg_stat_code")]
        [AttrSeqnr(3)]
        [DomId(100004103)]
        [DataLength(6)]
        [DataDecimals(0)]
        ControlFeatureStatusInvestigationStatusEnum? InvestigationStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cbrn_thrt_lvl_code
		///
		/// The specific value that represents the assessed CBRN threat level status of a specific CONTROL-FEATURE that defines a given operational area for friendly forces.
        /// </summary>
        /// <value>
        /// Value of the column cbrn_thrt_lvl_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("control-feature-status-cbrn-threat-level-code")]
		[AttrColumnName("cbrn_thrt_lvl_code")]
        [AttrSeqnr(4)]
        [DomId(100004189)]
        [DataLength(6)]
        [DataDecimals(0)]
        ControlFeatureStatusCbrnThreatLevelEnum? CbrnThreatLevel { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column security_stat_code
		///
		/// The specific value that represents the protection status of the site encompassed by a specific CONTROL-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column security_stat_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("control-feature-status-security-status-code")]
		[AttrColumnName("security_stat_code")]
        [AttrSeqnr(5)]
        [DomId(100004104)]
        [DataLength(6)]
        [DataDecimals(0)]
        ControlFeatureStatusSecurityStatusEnum? SecurityStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column usage_stat_code
		///
		/// The specific value that represents the usage of a specific CONTROL-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column usage_stat_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("control-feature-status-usage-status-code")]
		[AttrColumnName("usage_stat_code")]
        [AttrSeqnr(6)]
        [DomId(100004225)]
        [DataLength(6)]
        [DataDecimals(0)]
        UsageStatusEnum? UsageStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(7)]
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
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(8)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
