using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity CbrnEvent that represents the table CBRN_EVENT
	/// 
	/// An ACTION-EVENT that involves chemical, biological, radiological or nuclear materiel individually or in combination.
    /// </summary>
	[EntId(10000195)]
    [EntName("CBRN-EVENT")]
    [EntTableName("CBRN_EVENT")]
    [EntDepth(2)]
    public interface ICbrnEvent
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cbrn_event_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column cbrn_event_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("cbrn-event-id")]
		[AttrColumnName("cbrn_event_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000909)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of CBRN-EVENT. It serves as a discriminator that partitions CBRN-EVENT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("cbrn-event-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000356)]
        [DataLength(6)]
        [DataDecimals(0)]
        CbrnEventCategoryEnum CbrnEventCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class or nature of activity prescribed by CBRN-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("cbrn-event-subcategory-code")]
		[AttrColumnName("subcat_code")]
        [AttrSeqnr(3)]
        [DomId(100000357)]
        [DataLength(6)]
        [DataDecimals(0)]
        CbrnEventSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column alarm_result_ind_code
		///
		/// The specific value that denotes whether a detector has indicated the presence of a CBRN-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column alarm_result_ind_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("cbrn-event-alarm-result-indicator-code")]
		[AttrColumnName("alarm_result_ind_code")]
        [AttrSeqnr(4)]
        [DomId(100000358)]
        [DataLength(6)]
        [DataDecimals(0)]
        CbrnEventAlarmResultIndicatorEnum? AlarmResultIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column conf_test_ind_code
		///
		/// The specific value that denotes whether a test confirms the presence of a CBRN-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column conf_test_ind_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("cbrn-event-confirmation-test-indicator-code")]
		[AttrColumnName("conf_test_ind_code")]
        [AttrSeqnr(5)]
        [DomId(100000359)]
        [DataLength(6)]
        [DataDecimals(0)]
        CbrnEventConfirmationTestIndicatorEnum? ConfirmationTestIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mat_cntr_type_code
		///
		/// The specific value that represents the type of container that stores the materiel (agent) involved in a specific CBRN-EVENT and characterised in ATP-45.
        /// </summary>
        /// <value>
        /// Value of the column mat_cntr_type_code
        /// </value>
        [AttrIx(100006)]
		[AttrName("cbrn-event-materiel-container-type-code")]
		[AttrColumnName("mat_cntr_type_code")]
        [AttrSeqnr(6)]
        [DomId(100004269)]
        [DataLength(6)]
        [DataDecimals(0)]
        CbrnEventMaterielContainerTypeEnum? MaterielContainerType { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mat_cntr_total_cnt
		///
		/// The integer value representing the number of [materiel] agent containers involved in a specific CBRN-EVENT and characterised in ATP-45.
        /// </summary>
        /// <value>
        /// Value of the column mat_cntr_total_cnt
        /// </value>
        [AttrIx(100007)]
		[AttrName("cbrn-event-materiel-container-total-count")]
		[AttrColumnName("mat_cntr_total_cnt")]
        [AttrSeqnr(7)]
        [DomId(100001800)]
        [DataLength(4)]
        [DataDecimals(0)]
        short? MaterielContainerTotalCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
