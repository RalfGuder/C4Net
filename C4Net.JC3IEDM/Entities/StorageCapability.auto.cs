using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity STORAGE-CAPABILITY that represents the table STORAGE_CAPAB.
	///
	/// A CAPABILITY, required for planning, of those FACILITYs and MATERIELs or EQUIPMENT-TYPEs and FACILITY-TYPEs that are deemed as having the ability to hold a specific OBJECT-TYPE.
    /// </summary>
    [Serializable]
    [DefinitionName("StorageCapability", "C4Net.JC3IEDM.Definitions.StorageCapability.definition.xml")]
    public class StorageCapability : Capability, IStorageCapability
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly StorageCapabilityExpression _ = new StorageCapabilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cargo_cat_code
		///
		/// The specific value that represents the class of cargo subject to the STORAGE-CAPABILITY.
        /// </summary>
        /// <value>
        /// Value of the column cargo_cat_code
        /// </value>
		public CargoCategoryEnum CargoCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dscpt_code
		///
		/// The specific value that represents the STORAGE-CAPABILITY that is being quantified.
        /// </summary>
        /// <value>
        /// Value of the column dscpt_code
        /// </value>
		public StorageCapabilityDescriptorEnum? Descriptor { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cond_code
		///
		/// The specific value that represents the type of storage condition.
        /// </summary>
        /// <value>
        /// Value of the column cond_code
        /// </value>
		public StorageCapabilityConditionEnum? Condition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column obj_type_id
        /// </value>
		public decimal ObjectTypeId { get; set; }
		
        #endregion
    }
}
