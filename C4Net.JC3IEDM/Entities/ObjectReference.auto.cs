using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-REFERENCE that represents the table OBJ_REF.
	///
	/// A RELATIVE-COORDINATE-SYSTEM that has its frame of reference defined by using the position and orientation of a specific OBJECT-ITEM at a given point in time.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectReference", "C4Net.JC3IEDM.Definitions.ObjectReference.definition.xml")]
    public class ObjectReference : RelativeCoordinateSystem, IObjectReference
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ObjectReferenceExpression _ = new ObjectReferenceExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column rel_coord_sys_id
		///
		/// The unique value, or set of characters, assigned to represent a specific RELATIVE-COORDINATE-SYSTEM and to distinguish it from all other RELATIVE-COORDINATE-SYSTEMs.
        /// </summary>
        /// <value>
        /// Value of the column rel_coord_sys_id
        /// </value>
		public decimal RelativeCoordinateSystemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ref_obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_ref_obj_item_id
        /// </value>
		public decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ref_loc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column obj_ref_loc_id
        /// </value>
		public decimal LocationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_ref_obj_item_loc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-LOCATION for a specific OBJECT-ITEM and a specific LOCATION and to distinguish it from all other OBJECT-ITEM-LOCATIONs for that OBJECT-ITEM and that LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column obj_ref_obj_item_loc_ix
        /// </value>
		public decimal ObjectItemLocationIndex { get; set; }
		
        #endregion
    }
}
