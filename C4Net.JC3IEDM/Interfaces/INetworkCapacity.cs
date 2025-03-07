using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity NetworkCapacity that represents the table NETWRK_CAP
	/// 
	/// An identification of the specific capacities of a NETWORK.
    /// </summary>
	[EntId(10000250)]
    [EntName("NETWORK-CAPACITY")]
    [EntTableName("NETWRK_CAP")]
    [EntDepth(4)]
    public interface INetworkCapacity
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
        /// Gets or sets the value of the column netwrk_cap_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-CAPACITY for a specific NETWORK and to distinguish it from all other NETWORK-CAPACITYs for that NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_cap_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("network-capacity-index")]
		[AttrColumnName("netwrk_cap_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column bandwidth_code
		///
		/// The specific value that represents a bandwidth capacity that is supported by a NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column bandwidth_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("network-capacity-bandwidth-code")]
		[AttrColumnName("bandwidth_code")]
        [AttrSeqnr(3)]
        [DomId(100004149)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkCapacityBandwidthEnum? Bandwidth { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column protocol_code
		///
		/// The specific value that represents an application-level (OSI model level 3 to 7) protocol governing the information transfer in a NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column protocol_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("network-capacity-protocol-code")]
		[AttrColumnName("protocol_code")]
        [AttrSeqnr(4)]
        [DomId(100004140)]
        [DataLength(6)]
        [DataDecimals(0)]
        NetworkCapacityProtocolEnum? Protocol { get; set; }
		
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
