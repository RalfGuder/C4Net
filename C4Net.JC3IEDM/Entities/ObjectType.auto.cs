using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-TYPE that represents the table OBJ_TYPE.
	///
	/// An individually identified class of objects that has military or civilian significance.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectType", "C4Net.JC3IEDM.Definitions.ObjectType.definition.xml")]
    public class ObjectType : IEntity, IObjectType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectTypeExpression _ = new ObjectTypeExpression();

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
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of OBJECT-TYPE. It serves as a discriminator that partitions OBJECT-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ObjectTypeCategoryEnum ObjectTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column decoy_ind_code
		///
		/// The specific value that denotes whether a specific OBJECT-TYPE represents an object class acting as a decoy.
        /// </summary>
        /// <value>
        /// Value of the column decoy_ind_code
        /// </value>
		public ObjectTypeDecoyIndicatorEnum DecoyIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific OBJECT-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
		public string NameText { get; set; }
		
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
