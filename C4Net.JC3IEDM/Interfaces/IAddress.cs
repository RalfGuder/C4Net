using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Address that represents the table ADDR
	/// 
	/// Precise information on the basis of which a physical or electronic destination may be accessed.
    /// </summary>
	[EntId(10000240)]
    [EntName("ADDRESS")]
    [EntTableName("ADDR")]
    [EntDepth(0)]
    public interface IAddress
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column addr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ADDRESS and to distinguish it from all other ADDRESSs.
        /// </summary>
        /// <value>
        /// Value of the column addr_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("address-id")]
		[AttrColumnName("addr_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [Mandatory]
        [DomId(100000917)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ADDRESS. It serves as a discriminator that partitions ADDRESS into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("address-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004138)]
        [DataLength(6)]
        [DataDecimals(0)]
        AddressCategoryEnum AddressCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column place_name_txt
		///
		/// The character string assigned to represent the name of the place related to the subject address.
        /// </summary>
        /// <value>
        /// Value of the column place_name_txt
        /// </value>
        [AttrIx(100003)]
		[AttrName("address-place-name-text")]
		[AttrColumnName("place_name_txt")]
        [AttrSeqnr(3)]
        [DomId(100001500)]
        [DataLength(100)]
        [DataDecimals(0)]
        string PlaceNameText { get; set; }
		
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
