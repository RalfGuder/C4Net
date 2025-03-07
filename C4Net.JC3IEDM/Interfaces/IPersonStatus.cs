using C4Net.Data.Attributes;
using C4Net.JC3IEDM.Enums;

namespace C4Net.JC3IEDM.Interfaces
{
    /// <summary>
    /// Interface for the entity PersonStatus that represents the table PERS_STAT
	/// 
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific PERSON.
    /// </summary>
	[EntId(10000103)]
    [EntName("PERSON-STATUS")]
    [EntTableName("PERS_STAT")]
    [EntDepth(4)]
    public interface IPersonStatus
    {
        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column pers_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column pers_stat_id
        /// </value>
        [AttrIx(100001)]
		[AttrName("person-status-id")]
		[AttrColumnName("pers_stat_id")]
        [AttrSeqnr(1)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100000905)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
        [AttrIx(100002)]
		[AttrName("object-item-status-index")]
		[AttrColumnName("obj_item_stat_ix")]
        [AttrSeqnr(2)]
        [PrimaryKey]
        [ForeignKey]
        [Mandatory]
        [DomId(100001000)]
        [DataLength(20)]
        [DataDecimals(0)]
        decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column duty_stat_code
		///
		/// The specific value that represents the availability of a specific PERSON for duty at a military or civilian post of employment.
        /// </summary>
        /// <value>
        /// Value of the column duty_stat_code
        /// </value>
        [AttrIx(100003)]
		[AttrName("person-status-duty-status-code")]
		[AttrColumnName("duty_stat_code")]
        [AttrSeqnr(3)]
        [DomId(100000102)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersonStatusDutyStatusEnum? DutyStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column physcl_stat_code
		///
		/// The specific value that represents the general physical status of a specific PERSON.
        /// </summary>
        /// <value>
        /// Value of the column physcl_stat_code
        /// </value>
        [AttrIx(100004)]
		[AttrName("person-status-physical-status-code")]
		[AttrColumnName("physcl_stat_code")]
        [AttrSeqnr(4)]
        [DomId(100000106)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersonStatusPhysicalStatusEnum? PhysicalStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column physcl_stat_qual_code
		///
		/// The specific value that qualifies the health conditions of a specific PERSON at a specific point in time.
        /// </summary>
        /// <value>
        /// Value of the column physcl_stat_qual_code
        /// </value>
        [AttrIx(100005)]
		[AttrName("person-status-physical-status-qualifier-code")]
		[AttrColumnName("physcl_stat_qual_code")]
        [AttrSeqnr(5)]
        [DomId(100000379)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersonStatusPhysicalStatusQualifierEnum? PhysicalStatusQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rad_dose_qty
		///
		/// The numeric value that represents the total radiation dose to which a person has been exposed. The unit of measure is centiGray (cGy).
        /// </summary>
        /// <value>
        /// Value of the column rad_dose_qty
        /// </value>
        [AttrIx(100006)]
		[AttrName("person-status-radiation-dose-quantity")]
		[AttrColumnName("rad_dose_qty")]
        [AttrSeqnr(6)]
        [DomId(100001200)]
        [DataLength(6)]
        [DataDecimals(0)]
        int? RadiationDoseQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reserve_ind_code
		///
		/// The specific value that represents whether a specific PERSON has been placed in reserve.
        /// </summary>
        /// <value>
        /// Value of the column reserve_ind_code
        /// </value>
        [AttrIx(100007)]
		[AttrName("person-status-reserve-indicator-code")]
		[AttrColumnName("reserve_ind_code")]
        [AttrSeqnr(7)]
        [DomId(100000266)]
        [DataLength(6)]
        [DataDecimals(0)]
        PersonStatusReserveIndicatorEnum? ReserveIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
        [AttrIx(100008)]
		[AttrName("physical model only")]
		[AttrColumnName("creator_id")]
        [AttrSeqnr(8)]
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
        [AttrIx(100009)]
		[AttrName("physical model only")]
		[AttrColumnName("update_seqnr")]
        [AttrSeqnr(9)]
        [Mandatory]
        [DomId(100000914)]
        [DataLength(15)]
        [DataDecimals(0)]
        long UpdateSeqnr { get; set; }
		
		
        #endregion
    }
}
