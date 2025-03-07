using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ElectronicAddress that represents the table ELCTRNC_ADDR
	/// 
	/// An ADDRESS that is reached by using the specified NETWORK-SERVICE.
    /// </summary>
	[EntId(10000241)]
    [EntName("ELECTRONIC-ADDRESS")]
    [EntTableName("ELCTRNC_ADDR")]
    [EntDepth(5)]
    public interface IElectronicAddress
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
        [ForeignKey]
        [Mandatory]
        [DomId(100000917)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal AddressId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific ELECTRONIC-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
        [AttrIx(100002)]
		[AttrName("electronic-address-name-text")]
		[AttrColumnName("name_txt")]
        [AttrSeqnr(2)]
        [DomId(100001500)]
        [DataLength(50)]
        [DataDecimals(0)]
        string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("network-id")]
		[AttrColumnName("netwrk_id")]
        [AttrSeqnr(3)]
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
        [AttrIx(100004)]
		[AttrName("network-service-index")]
		[AttrColumnName("netwrk_service_ix")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal NetworkServiceIndex { get; set; }
		
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
