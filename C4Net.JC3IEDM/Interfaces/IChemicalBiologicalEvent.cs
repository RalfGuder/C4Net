using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ChemicalBiologicalEvent that represents the table CHM_BIO_EVENT
	/// 
	/// A CBRN-EVENT involving chemical and/or biological materiel.
    /// </summary>
	[EntId(10000313)]
    [EntName("CHEMICAL-BIOLOGICAL-EVENT")]
    [EntTableName("CHM_BIO_EVENT")]
    [EntDepth(3)]
    public interface IChemicalBiologicalEvent
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column chm_bio_event_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column chm_bio_event_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("chemical-biological-event-id")]
		[AttrColumnName("chm_bio_event_id")]
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
		/// The specific value that represents the class of CHEMICAL-BIOLOGICAL-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("chemical-biological-event-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100004270)]
        [DataLength(6)]
        [DataDecimals(0)]
        ChemicalBiologicalEventCategoryEnum ChemicalBiologicalEventCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column release_cat_code
		///
		/// The specific value that represents the class of release in a CHEMICAL-BIOLOGICAL-EVENT.
        /// </summary>
        /// <value>
        /// Value of the column release_cat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("chemical-biological-event-release-category-code")]
		[AttrColumnName("release_cat_code")]
        [AttrSeqnr(3)]
        [DomId(100000361)]
        [DataLength(6)]
        [DataDecimals(0)]
        ReleaseCategoryEnum? ReleaseCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column spill_size_code
		///
		/// The specific value that represents the mass or the volume of a materiel spilled in a CHEMICAL-BIOLOGICAL-EVENT that is a release other than attack (ROTA).
        /// </summary>
        /// <value>
        /// Value of the column spill_size_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("chemical-biological-event-spill-size-code")]
		[AttrColumnName("spill_size_code")]
        [AttrSeqnr(4)]
        [DomId(100000362)]
        [DataLength(6)]
        [DataDecimals(0)]
        ChemicalBiologicalEventSpillSizeEnum? SpillSize { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column release_height_dim
		///
		/// The one-dimensional linear distance representing the height above ground level at which the chemical or biological agent is released. Release height is frequently referred to as burst height.
        /// </summary>
        /// <value>
        /// Value of the column release_height_dim
        /// </value>
        [AttrIx(100005)]
		[AttrName("chemical-biological-event-release-height-dimension")]
		[AttrColumnName("release_height_dim")]
        [AttrSeqnr(5)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? ReleaseHeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vol_cncntr_qty
		///
		/// The numeric value that represents the level of chemical or biological contamination per unit volume in air or water. The unit of measure is milligrams per cubic metre (MGM3).
        /// </summary>
        /// <value>
        /// Value of the column vol_cncntr_qty
        /// </value>
        [AttrIx(100006)]
		[AttrName("chemical-biological-event-volume-concentration-quantity")]
		[AttrColumnName("vol_cncntr_qty")]
        [AttrSeqnr(6)]
        [DomId(100001200)]
        [DataLength(14)]
        [DataDecimals(6)]
        double? VolumeConcentrationQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_dep_qty
		///
		/// The numeric value that represents the level of chemical or biological contamination per unit area on a surface. The unit of measure is milligrams per square metre (MGM2).
        /// </summary>
        /// <value>
        /// Value of the column surf_dep_qty
        /// </value>
        [AttrIx(100007)]
		[AttrName("chemical-biological-event-surface-deposition-quantity")]
		[AttrColumnName("surf_dep_qty")]
        [AttrSeqnr(7)]
        [DomId(100001200)]
        [DataLength(14)]
        [DataDecimals(6)]
        double? SurfaceDepositionQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column atmspc_prtcl_cncntr_qty
		///
		/// The numeric value that represents the level of chemical or biological atmospheric contamination The unit of measure is Agent Containing Particles Per Litre (ACPL).
        /// </summary>
        /// <value>
        /// Value of the column atmspc_prtcl_cncntr_qty
        /// </value>
        [AttrIx(100008)]
		[AttrName("chemical-biological-event-atmospheric-particle-concentration-quantity")]
		[AttrColumnName("atmspc_prtcl_cncntr_qty")]
        [AttrSeqnr(8)]
        [DomId(100001200)]
        [DataLength(14)]
        [DataDecimals(6)]
        double? AtmosphericParticleConcentrationQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mass_frac_cncntr_qty
		///
		/// The numeric value that represents the number of 'parts' by weight of a biological or chemical substance per million parts of water. The unit of measure is in Parts per Million (PPM).
        /// </summary>
        /// <value>
        /// Value of the column mass_frac_cncntr_qty
        /// </value>
        [AttrIx(100009)]
		[AttrName("chemical-biological-event-mass-fraction-concentration-quantity")]
		[AttrColumnName("mass_frac_cncntr_qty")]
        [AttrSeqnr(9)]
        [DomId(100001200)]
        [DataLength(14)]
        [DataDecimals(6)]
        double? MassFractionConcentrationQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(10)]
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
        [AttrIx(100011)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(11)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
