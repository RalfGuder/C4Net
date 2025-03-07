using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity RadiologicalEvent that represents the table RADLGC_EVENT
	/// 
	/// A RADIOACTIVE-EVENT involving radioactive materiel(s) but not involving nuclear materiel(s) and/or nuclear detonation.
    /// </summary>
	[EntId(10000317)]
    [EntName("RADIOLOGICAL-EVENT")]
    [EntTableName("RADLGC_EVENT")]
    [EntDepth(4)]
    public interface IRadiologicalEvent
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column radlgc_event_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column radlgc_event_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("radiological-event-id")]
		[AttrColumnName("radlgc_event_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column release_cat_code
		///
		/// The specific value that represents the type of discharge for a contaminant release in a radioactive release other than attack (ROTA) event.
        /// </summary>
        /// <value>
        /// Value of the column release_cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("radiological-event-release-category-code")]
		[AttrColumnName("release_cat_code")]
        [AttrSeqnr(2)]
        [DomId(100000361)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReleaseCategoryEnum? ReleaseCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column isotope_cncntr_rat
		///
		/// The numeric quotient value that represents the proportion by weight of an isotope in a release. The value must be in the range from 0 to 1.
        /// </summary>
        /// <value>
        /// Value of the column isotope_cncntr_rat
        /// </value>
        [AttrIx(100003)]
		[AttrName("radiological-event-isotope-concentration-ratio")]
		[AttrColumnName("isotope_cncntr_rat")]
        [AttrSeqnr(3)]
        [DomId(100001900)]
        [DataLength(6)]
        [DataDecimals(5)]
        double? IsotopeConcentrationRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(4)]
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
        [AttrIx(100005)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(5)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
