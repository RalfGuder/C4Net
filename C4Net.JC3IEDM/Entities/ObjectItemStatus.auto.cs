using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-ITEM-STATUS that represents the table OBJ_ITEM_STAT.
	///
	/// A record of the perceived condition of a specific OBJECT-ITEM as determined by the reporting organisation.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectItemStatus", "C4Net.JC3IEDM.Definitions.ObjectItemStatus.definition.xml")]
    public class ObjectItemStatus : IEntity, IObjectItemStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectItemStatusExpression _ = new ObjectItemStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
		public decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of OBJECT-ITEM-STATUS. It serves as a discriminator that partitions OBJECT-ITEM-STATUS into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ObjectItemStatusCategoryEnum ObjectItemStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column booby_trap_prsnc_code
		///
		/// The specific value that indicates whether a specific OBJECT-ITEM has been booby-trapped.
        /// </summary>
        /// <value>
        /// Value of the column booby_trap_prsnc_code
        /// </value>
		public ObjectItemStatusBoobyTrapPresenceEnum? BoobyTrapPresence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column emsn_ctrl_code
		///
		/// The specific value that represents the emission control status of a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column emsn_ctrl_code
        /// </value>
		public ObjectItemStatusEmissionControlEnum? EmissionControl { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
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
