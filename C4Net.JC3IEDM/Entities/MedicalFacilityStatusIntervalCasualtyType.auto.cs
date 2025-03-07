using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-TYPE that represents the table MFS_INTVL_CAS_TYPE.
	///
	/// A MEDICAL-FACILITY-STATUS that specifies the count of casualty arrivals and admissions in each of specified groups according to specified medical classification during the period defined by the effective beginning and ending datetimes stipulated through REPORTING-DATA.
    /// </summary>
    [Serializable]
    [DefinitionName("MedicalFacilityStatusIntervalCasualtyType", "C4Net.JC3IEDM.Definitions.MedicalFacilityStatusIntervalCasualtyType.definition.xml")]
    public class MedicalFacilityStatusIntervalCasualtyType : IEntity, IMedicalFacilityStatusIntervalCasualtyType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly MedicalFacilityStatusIntervalCasualtyTypeExpression _ = new MedicalFacilityStatusIntervalCasualtyTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mfs_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mfs_id
        /// </value>
		public decimal MedicalFacilityStatusId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
		public decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mfs_intvl_cas_type_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-TYPE for a specific FACILITY and a specific OBJECT-ITEM-STATUS and to distinguish it from all other instances of MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-TYPE for that FACILITY and that OBJECT-ITEM-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column mfs_intvl_cas_type_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the categorisation of casualties according to the type of illness or injury in a specific MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
		public MedicalFacilityStatusIntervalCasualtyTypeEnum MedicalFacilityStatusIntervalCasualtyTypeCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column arrival_cnt
		///
		/// The integer value representing the number of new casualties of the specified type in a specific MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column arrival_cnt
        /// </value>
		public int ArrivalCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column admitted_cnt
		///
		/// The integer value representing the number of admitted casualties of the specified type in a specific MEDICAL-FACILITY-STATUS-INTERVAL-CASUALTY-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column admitted_cnt
        /// </value>
		public int AdmittedCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}
