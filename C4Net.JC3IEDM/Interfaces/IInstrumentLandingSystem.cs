using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity InstrumentLandingSystem that represents the table INST_LNDG_SYS
	/// 
	/// A MATERIEL that provides aircraft with horizontal and vertical guidance just before landing and during landing, and at certain fixed points, indicates the distance to the reference point of landing.
    /// </summary>
	[EntId(10000325)]
    [EntName("INSTRUMENT-LANDING-SYSTEM")]
    [EntTableName("INST_LNDG_SYS")]
    [EntDepth(2)]
    public interface IInstrumentLandingSystem
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column inst_lndg_sys_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column inst_lndg_sys_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("instrument-landing-system-id")]
		[AttrColumnName("inst_lndg_sys_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column beam_width_dim
		///
		/// The one-dimensional linear distance representing the extreme horizontal distance measured from side to side and perpendicular to the central axis of the main beam coil of a specific localiser.
        /// </summary>
        /// <value>
        /// Value of the column beam_width_dim
        /// </value>
        [AttrIx(100002)]
		[AttrName("instrument-landing-system-beam-width-dimension")]
		[AttrColumnName("beam_width_dim")]
        [AttrSeqnr(2)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? BeamWidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column glide_path_angle
		///
		/// The rotational measurement from the horizontal plane to the glide path, where the positive angle is vertically upward.
        /// </summary>
        /// <value>
        /// Value of the column glide_path_angle
        /// </value>
        [AttrIx(100003)]
		[AttrName("instrument-landing-system-glide-path-angle")]
		[AttrColumnName("glide_path_angle")]
        [AttrSeqnr(3)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? GlidePathAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column magn_varn_angle
		///
		/// The rotational measurement of the angular difference between true north and magnetic north.
        /// </summary>
        /// <value>
        /// Value of the column magn_varn_angle
        /// </value>
        [AttrIx(100004)]
		[AttrName("instrument-landing-system-magnetic-variation-angle")]
		[AttrColumnName("magn_varn_angle")]
        [AttrSeqnr(4)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? MagneticVariationAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column slaved_varn_angle
		///
		/// The rotational measurement of the fixed value of magnetic variation applied to true direction to obtain the magnetic values for radials, courses and headings.
        /// </summary>
        /// <value>
        /// Value of the column slaved_varn_angle
        /// </value>
        [AttrIx(100005)]
		[AttrName("instrument-landing-system-slaved-variation-angle")]
		[AttrColumnName("slaved_varn_angle")]
        [AttrSeqnr(5)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? SlavedVariationAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column brng_angle
		///
		/// The rotational measurement clockwise from true North to the localiser used for final approach guidance.
        /// </summary>
        /// <value>
        /// Value of the column brng_angle
        /// </value>
        [AttrIx(100006)]
		[AttrName("instrument-landing-system-bearing-angle")]
		[AttrColumnName("brng_angle")]
        [AttrSeqnr(6)]
        [DomId(100000000)]
        [DataLength(7)]
        [DataDecimals(4)]
        double? BearingAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column thrsh_crsn_height_dim
		///
		/// The one-dimensional linear distance representing the height above the landing threshold on a normal glide path.
        /// </summary>
        /// <value>
        /// Value of the column thrsh_crsn_height_dim
        /// </value>
        [AttrIx(100007)]
		[AttrName("instrument-landing-system-threshold-crossing-height-dimension")]
		[AttrColumnName("thrsh_crsn_height_dim")]
        [AttrSeqnr(7)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? ThresholdCrossingHeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column localizer_dist_dim
		///
		/// The one-dimensional linear distance representing the extreme horizontal distance measured perpendicular from the end of the runway to the localiser antenna position.
        /// </summary>
        /// <value>
        /// Value of the column localizer_dist_dim
        /// </value>
        [AttrIx(100008)]
		[AttrName("instrument-landing-system-localiser-distance-dimension")]
		[AttrColumnName("localizer_dist_dim")]
        [AttrSeqnr(8)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? LocaliserDistanceDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dist_mesn_eqpt_dist_dim
		///
		/// The one-dimensional linear distance representing the distance between the distance measuring equipment and the associated landing threshold.
        /// </summary>
        /// <value>
        /// Value of the column dist_mesn_eqpt_dist_dim
        /// </value>
        [AttrIx(100009)]
		[AttrName("instrument-landing-system-distance-measuring-equipment-distance-dimension")]
		[AttrColumnName("dist_mesn_eqpt_dist_dim")]
        [AttrSeqnr(9)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? DistanceMeasuringEquipmentDistanceDimension { get; set; }
		
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
