using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity RELATIVE-COORDINATE-SYSTEM that represents the table REL_COORD_SYS.
	///
	/// A rectangular frame of reference defined by an origin, x and y axes in the horizontal plane, and a z-axis. The vertical z-axis is normal to the xy-plane with positive direction determined from the right-hand rule when the x-axis is rotated toward the y-axis.
    /// </summary>
    [Serializable]
    [DefinitionName("RelativeCoordinateSystem", "C4Net.JC3IEDM.Definitions.RelativeCoordinateSystem.definition.xml")]
    public class RelativeCoordinateSystem : IEntity, IRelativeCoordinateSystem
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly RelativeCoordinateSystemExpression _ = new RelativeCoordinateSystemExpression();

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
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_cat_code
		///
		/// The specific value that represents the source of the reference for defining the origin and axial directions for a specific RELATIVE-COORDINATE-SYSTEM. It serves as a discriminator that partitions RELATIVE-COORDINATE-SYSTEM into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column ref_cat_code
        /// </value>
		public RelativeCoordinateSystemReferenceCategoryEnum ReferenceCategory { get; set; }
		
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
