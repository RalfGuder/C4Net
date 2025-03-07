using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity SurfaceVesselType that represents the table SURF_VESSEL_TYPE
	/// 
	/// A vessel principally designed to operate on the water surface.
    /// </summary>
	[EntId(10000322)]
    [EntName("SURFACE-VESSEL-TYPE")]
    [EntTableName("SURF_VESSEL_TYPE")]
    [EntDepth(4)]
    public interface ISurfaceVesselType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column surf_vessel_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column surf_vessel_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("surface-vessel-type-id")]
		[AttrColumnName("surf_vessel_type_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of surface vessel.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("surface-vessel-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004284)]
        [DataLength(6)]
        [DataDecimals(0)]
        SurfaceVesselTypeCategoryEnum SurfaceVesselTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column displ_qty
		///
		/// The numeric value that represents the maximum volume of water moved by the vessel when it is fully loaded. The unit of measure is cubic metre.
        /// </summary>
        /// <value>
        /// Value of the column displ_qty
        /// </value>
        [AttrIx(100003)]
		[AttrName("surface-vessel-type-displacement-quantity")]
		[AttrColumnName("displ_qty")]
        [AttrSeqnr(3)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? DisplacementQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_deck_load_qty
		///
		/// The numeric value that represents the Ship's maximum allowable deck load. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column max_deck_load_qty
        /// </value>
        [AttrIx(100004)]
		[AttrName("surface-vessel-type-maximum-deck-load-quantity")]
		[AttrColumnName("max_deck_load_qty")]
        [AttrSeqnr(4)]
        [DomId(100001200)]
        [DataLength(9)]
        [DataDecimals(0)]
        int? MaximumDeckLoadQuantity { get; set; }
		
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
