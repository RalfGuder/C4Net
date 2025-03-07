using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ObjectReference that represents the table OBJ_REF
	/// 
	/// A RELATIVE-COORDINATE-SYSTEM that has its frame of reference defined by using the position and orientation of a specific OBJECT-ITEM at a given point in time.
    /// </summary>
	[EntId(10000228)]
    [EntName("OBJECT-REFERENCE")]
    [EntTableName("OBJ_REF")]
    [EntDepth(4)]
    public interface IObjectReference
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column rel_coord_sys_id
		///
		/// The unique value, or set of characters, assigned to represent a specific RELATIVE-COORDINATE-SYSTEM and to distinguish it from all other RELATIVE-COORDINATE-SYSTEMs.
        /// </summary>
        /// <value>
        /// Value of the column rel_coord_sys_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("relative-coordinate-system-id")]
		[AttrColumnName("rel_coord_sys_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000916)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal RelativeCoordinateSystemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ref_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_ref_obj_item_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-reference-object-item-id")]
		[AttrColumnName("obj_ref_obj_item_id")]
        [AttrSeqnr(2)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ref_loc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column obj_ref_loc_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("object-reference-location-id")]
		[AttrColumnName("obj_ref_loc_id")]
        [AttrSeqnr(3)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal LocationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ref_obj_item_loc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-LOCATION for a specific OBJECT-ITEM and a specific LOCATION and to distinguish it from all other OBJECT-ITEM-LOCATIONs for that OBJECT-ITEM and that LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column obj_ref_obj_item_loc_ix
        /// </value>
        [AttrIx(100004)]
		[AttrName("object-reference-object-item-location-index")]
		[AttrColumnName("obj_ref_obj_item_loc_ix")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemLocationIndex { get; set; }
		
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
