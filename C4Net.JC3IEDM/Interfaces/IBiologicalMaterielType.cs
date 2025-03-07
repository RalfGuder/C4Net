using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity BiologicalMaterielType that represents the table BIO_MAT_TYPE
	/// 
	/// A CONSUMABLE-MATERIEL-TYPE that is either a microorganism that causes disease in man, plants, or animals or causes the deterioration of materiel; or a toxin, produced by an animal, plant, or microorganism, which may kill, seriously injure, or incapacitate personnel through its physiological effects.
    /// </summary>
	[EntId(10000193)]
    [EntName("BIOLOGICAL-MATERIEL-TYPE")]
    [EntTableName("BIO_MAT_TYPE")]
    [EntDepth(3)]
    public interface IBiologicalMaterielType
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column bio_mat_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column bio_mat_type_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("biological-materiel-type-id")]
		[AttrColumnName("bio_mat_type_id")]
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
		/// The specific value that represents the class of BIOLOGICAL-MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
        [AttrIx(100002)]
		[AttrName("biological-materiel-type-category-code")]
		[AttrColumnName("cat_code")]
        [AttrSeqnr(2)]
        [Mandatory]
        [DomId(100000351)]
        [DataLength(6)]
        [DataDecimals(0)]
        BiologicalMaterielTypeCategoryEnum BiologicalMaterielTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of a specific BIOLOGICAL-MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("biological-materiel-type-subcategory-code")]
		[AttrColumnName("subcat_code")]
        [AttrSeqnr(3)]
        [DomId(100000352)]
        [DataLength(6)]
        [DataDecimals(0)]
        BiologicalMaterielTypeSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column persist_code
		///
		/// The specific value that represents the temporal variation of the effectiveness of a BIOLOGICAL-MATERIEL-TYPE under determined conditions after its dispersal.
        /// </summary>
        /// <value>
        /// Value of the column persist_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("biological-materiel-type-persistency-code")]
		[AttrColumnName("persist_code")]
        [AttrSeqnr(4)]
        [DomId(100000353)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersistencyEnum? Persistency { get; set; }
		
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
