using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity Ellipse that represents the table ELPS
	/// 
	/// A planar SURFACE in the form of an ellipse.
    /// </summary>
	[EntId(10000215)]
    [EntName("ELLIPSE")]
    [EntTableName("ELPS")]
    [EntDepth(2)]
    public interface IEllipse
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column elps_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column elps_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("ellipse-id")]
		[AttrColumnName("elps_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column elps_centre_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column elps_centre_point_id
        /// </value>
        [AttrIx(100002)]
		[AttrName("ellipse-centre-point-id")]
		[AttrColumnName("elps_centre_point_id")]
        [AttrSeqnr(2)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal CentrePointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column elps_first_cnjg_diam_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column elps_first_cnjg_diam_point_id
        /// </value>
        [AttrIx(100003)]
		[AttrName("ellipse-first-conjugate-diameter-point-id")]
		[AttrColumnName("elps_first_cnjg_diam_point_id")]
        [AttrSeqnr(3)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal FirstConjugateDiameterPointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column elps_scnd_cnjg_diam_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column elps_scnd_cnjg_diam_point_id
        /// </value>
        [AttrIx(100004)]
		[AttrName("ellipse-second-conjugate-diameter-point-id")]
		[AttrColumnName("elps_scnd_cnjg_diam_point_id")]
        [AttrSeqnr(4)]
        [ForeignKey]
        [Mandatory]
        [DomId(100000904)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal SecondConjugateDiameterPointId { get; set; }
		
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
