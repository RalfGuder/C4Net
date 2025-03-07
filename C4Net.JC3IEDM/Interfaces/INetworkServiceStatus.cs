using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity NetworkServiceStatus that represents the table NETWRK_SERVICE_STAT
	/// 
	/// A record of the perceived condition of a specific NETWORK-SERVICE as determined by the reporting organisation.
    /// </summary>
	[EntId(10000307)]
    [EntName("NETWORK-SERVICE-STATUS")]
    [EntTableName("NETWRK_SERVICE_STAT")]
    [EntDepth(5)]
    public interface INetworkServiceStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("network-id")]
		[AttrColumnName("netwrk_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal NetworkId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_service_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-SERVICE for a specific NETWORK and to distinguish it from all other NETWORK-SERVICEs for that NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_service_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("network-service-index")]
		[AttrColumnName("netwrk_service_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal NetworkServiceIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_service_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-SERVICE-STATUS for a specific NETWORK-SERVICE and to distinguish it from all other NETWORK-SERVICE-STATUSs for that NETWORK-SERVICE.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_service_stat_ix
        /// </value>
        [AttrIx(100003)]
		[AttrName("network-service-status-index")]
		[AttrColumnName("netwrk_service_stat_ix")]
        [AttrSeqnr(3)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ind_code
		///
		/// The specific value that denotes whether the specific NETWORK-SERVICE is active.
        /// </summary>
        /// <value>
        /// Value of the column ind_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("network-service-status-indicator-code")]
		[AttrColumnName("ind_code")]
        [AttrSeqnr(4)]
        [DomId(100004253)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkServiceStatusIndicatorEnum? Indicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
        [AttrIx(100005)]
		[AttrName("reporting-data-id")]
		[AttrColumnName("rptd_id")]
        [AttrSeqnr(5)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000912)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100006)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(6)]
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
        [AttrIx(100007)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(7)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
