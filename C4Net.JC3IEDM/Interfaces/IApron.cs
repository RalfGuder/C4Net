using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Apron that represents the table APRON
	/// 
	/// A FACILITY that is an area intended for parking, loading, unloading and/or servicing.
    /// </summary>
	[EntId(10000312)]
    [EntName("APRON")]
    [EntTableName("APRON")]
    [EntDepth(3)]
    public interface IApron
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column apron_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column apron_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("apron-id")]
		[AttrColumnName("apron_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column wt_brng_cap_qty
		///
		/// The numeric value that denotes the maximum gravitational force exerted on the surface of a specific APRON. The unit of measure is kilograms per square centimetre.
        /// </summary>
        /// <value>
        /// Value of the column wt_brng_cap_qty
        /// </value>
        [AttrIx(100002)]
		[AttrName("apron-weight-bearing-capacity-quantity")]
		[AttrColumnName("wt_brng_cap_qty")]
        [AttrSeqnr(2)]
        [DomId(100001200)]
        [DataLength(8)]
        [DataDecimals(4)]
        double? WeightBearingCapacityQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(3)]
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
        [AttrIx(100004)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(4)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
