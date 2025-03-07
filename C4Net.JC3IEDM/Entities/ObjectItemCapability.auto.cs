using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-ITEM-CAPABILITY that represents the table OBJ_ITEM_CAPAB.
	///
	/// A perceived value of a specific CAPABILITY of an OBJECT-ITEM.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectItemCapability", "C4Net.JC3IEDM.Definitions.ObjectItemCapability.definition.xml")]
    public class ObjectItemCapability : IEntity, IObjectItemCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectItemCapabilityExpression _ = new ObjectItemCapabilityExpression();

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
        /// Gets or sets the value of the column capab_id
		///
		/// The unique value, or set of characters, assigned to represent a specific CAPABILITY and to distinguish it from all other CAPABILITYs.
        /// </summary>
        /// <value>
        /// Value of the column capab_id
        /// </value>
		public decimal CapabilityId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_capab_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-CAPABILITY for a specific OBJECT-ITEM and a specific CAPABILITY and to distinguish it from all other OBJECT-ITEM-CAPABILITYs for that OBJECT-ITEM and that CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_capab_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column msn_primacy_code
		///
		/// The specific value that represents the priority of the role that a specific capability, restricted to be an OPERATIONAL-CAPABILITY, has for the specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column msn_primacy_code
        /// </value>
		public MissionPrimacyEnum? MissionPrimacy { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qty
		///
		/// The numeric value that represents the aggregated units of a specific CAPABILITY that is estimated to be attainable for a specific OBJECT-ITEM. The unit of measure is defined in the CAPABILITY specification.
        /// </summary>
        /// <value>
        /// Value of the column qty
        /// </value>
		public double? Quantity { get; set; }
		
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
