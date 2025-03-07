using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Facility that represents the table FAC
	/// 
	/// An OBJECT-ITEM that is built, installed or established to serve some particular purpose and is identified by the service it provides rather than by its content.
    /// </summary>
	[EntId(10000043)]
    [EntName("FACILITY")]
    [EntTableName("FAC")]
    [EntDepth(2)]
    public interface IFacility
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column fac_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column fac_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("facility-id")]
		[AttrColumnName("fac_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of FACILITY. It serves as a discriminator that partitions FACILITY into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("facility-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000192)]
        [DataLength(6)]
        [DataDecimals(0)]
        FacilityCategoryEnum FacilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prim_const_matrl_code
		///
		/// The specific value that represents the major material used in building the specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column prim_const_matrl_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("facility-primary-construction-material-code")]
		[AttrColumnName("prim_const_matrl_code")]
        [AttrSeqnr(3)]
        [DomId(100004119)]
        [DataLength(6)]
        [DataDecimals(0)]
        FacilityPrimaryConstructionMaterialEnum? PrimaryConstructionMaterial { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column base_identific_code_txt
		///
		/// The character string assigned to represent a designation of the common additional reference given to a specific military base/facility.
        /// </summary>
        /// <value>
        /// Value of the column base_identific_code_txt
        /// </value>
        [AttrIx(100004)]
		[AttrName("facility-base-identification-code-text")]
		[AttrColumnName("base_identific_code_txt")]
        [AttrSeqnr(4)]
        [DomId(100001500)]
        [DataLength(15)]
        [DataDecimals(0)]
        string BaseIdentificationCodeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column height_dim
		///
		/// The one-dimensional linear distance representing the height of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column height_dim
        /// </value>
        [AttrIx(100005)]
		[AttrName("facility-height-dimension")]
		[AttrColumnName("height_dim")]
        [AttrSeqnr(5)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? HeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column length_dim
		///
		/// The one-dimensional linear distance representing the length of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column length_dim
        /// </value>
        [AttrIx(100006)]
		[AttrName("facility-length-dimension")]
		[AttrColumnName("length_dim")]
        [AttrSeqnr(6)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? LengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column width_dim
		///
		/// The one-dimensional linear distance representing the width of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column width_dim
        /// </value>
        [AttrIx(100007)]
		[AttrName("facility-width-dimension")]
		[AttrColumnName("width_dim")]
        [AttrSeqnr(7)]
        [DomId(100000600)]
        [DataLength(12)]
        [DataDecimals(3)]
        double? WidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fac_major_building_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column fac_major_building_type_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("facility-major-building-type-id")]
		[AttrColumnName("fac_major_building_type_id")]
        [AttrSeqnr(8)]
        [ForeignKey]
        [DomId(100000906)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal? MajorBuildingTypeId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(9)]
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
        [AttrIx(100010)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(10)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
