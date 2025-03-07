using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity ControlFeatureType that represents the table CTRL_FEAT_TYPE
	/// 
	/// A non-tangible FEATURE-TYPE of military interest that may be represented as a geometric figure and is associated with the conduct of military operations.
    /// </summary>
	[EntId(10000035)]
    [EntName("CONTROL-FEATURE-TYPE")]
    [EntTableName("CTRL_FEAT_TYPE")]
    [EntDepth(2)]
    public interface IControlFeatureType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ctrl_feat_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column ctrl_feat_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("control-feature-type-id")]
		[AttrColumnName("ctrl_feat_type_id")]
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
		/// The specific value that represents the class of CONTROL-FEATURE-TYPE. It serves as a discriminator that partitions CONTROL-FEATURE-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("control-feature-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000128)]
        [DataLength(6)]
        [DataDecimals(0)]
        ControlFeatureTypeCategoryEnum ControlFeatureTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column echln_code
		///
		/// The specific value that represents the echelon level of an organisation that is to be associated with a specific CONTROL-FEATURE-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column echln_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("control-feature-type-echelon-code")]
		[AttrColumnName("echln_code")]
        [AttrSeqnr(3)]
        [DomId(100000166)]
        [DataLength(6)]
        [DataDecimals(0)]
        EchelonSizeEnum? Echelon { get; set; }
		
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
        [AttrIx(100004)]
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
