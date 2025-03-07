using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Target that represents the table TARGET
	/// 
	/// An ACTION-OBJECTIVE-ITEM that is subject to capture, destruction or intelligence operations.
    /// </summary>
	[EntId(10000123)]
    [EntName("TARGET")]
    [EntTableName("TARGET")]
    [EntDepth(7)]
    public interface ITarget
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("action-id")]
		[AttrColumnName("act_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_objve_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE for a specific ACTION and to distinguish it from all other ACTION-OBJECTIVEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("action-objective-index")]
		[AttrColumnName("act_objve_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ActionObjectiveIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column engage_authy_code
		///
		/// The specific value that represents the type of employment authorised for a specific TARGET.
        /// </summary>
        /// <value>
        /// Value of the column engage_authy_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("target-engagement-authority-code")]
		[AttrColumnName("engage_authy_code")]
        [AttrSeqnr(3)]
        [DomId(100000220)]
        [DataLength(6)]
        [DataDecimals(0)]
        TargetEngagementAuthorityEnum? EngagementAuthority { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column id_txt
		///
		/// The character string assigned to represent the common additional reference assigned to the target by an organisation.
        /// </summary>
        /// <value>
        /// Value of the column id_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("target-identifier-text")]
		[AttrColumnName("id_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string IdentifierText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column persistence_dur
		///
		/// The numeric value that represents a quantity of time in milliseconds that a specific TARGET is expected to remain available as a target.
        /// </summary>
        /// <value>
        /// Value of the column persistence_dur
        /// </value>
        [AttrIx(100005)]
		[AttrName("target-persistence-duration")]
		[AttrColumnName("persistence_dur")]
        [AttrSeqnr(5)]
        [DomId(100000700)]
        [DataLength(19)]
        [DataDecimals(0)]
        decimal? PersistenceDuration { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column descr_txt
		///
		/// The character string assigned to represent the common additional reference assigned to the TARGET.
        /// </summary>
        /// <value>
        /// Value of the column descr_txt
        /// </value>
        [AttrIx(100006)]
		[AttrName("target-description-text")]
		[AttrColumnName("descr_txt")]
        [AttrSeqnr(6)]
        [DomId(100001500)]
        [DataLength(20)]
        [DataDecimals(0)]
        string DescriptionText { get; set; }
		
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
