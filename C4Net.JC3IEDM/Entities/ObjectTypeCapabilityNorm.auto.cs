using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-TYPE-CAPABILITY-NORM that represents the table OBJ_TYPE_CAPAB_NORM.
	///
	/// The standard value of a specific CAPABILITY of an OBJECT-TYPE.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectTypeCapabilityNorm", "C4Net.JC3IEDM.Definitions.ObjectTypeCapabilityNorm.definition.xml")]
    public class ObjectTypeCapabilityNorm : IEntity, IObjectTypeCapabilityNorm
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectTypeCapabilityNormExpression _ = new ObjectTypeCapabilityNormExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
		public decimal ObjectTypeId { get; set; }
		
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
        /// Gets or sets the value of the column msn_primacy_code
		///
		/// The specific value that represents the priority of the role that a specific capability, restricted to be an OPERATIONAL-CAPABILITY, has for the specific OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column msn_primacy_code
        /// </value>
		public MissionPrimacyEnum? MissionPrimacy { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column qty
		///
		/// The numeric value that represents the aggregated units of a specific CAPABILITY that is specified in a particular OBJECT-TYPE-CAPABILITY-NORM to be attainable for a specific OBJECT-TYPE. The unit of measure is defined in the CAPABILITY specification.
        /// </summary>
        /// <value>
        /// Value of the column qty
        /// </value>
		public double? Quantity { get; set; }
		
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
