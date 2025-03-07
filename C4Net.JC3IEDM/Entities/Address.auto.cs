using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ADDRESS that represents the table ADDR.
	///
	/// Precise information on the basis of which a physical or electronic destination may be accessed.
    /// </summary>
    [Serializable]
    [DefinitionName("Address", "C4Net.JC3IEDM.Definitions.Address.definition.xml")]
    public class Address : IEntity, IAddress
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly AddressExpression _ = new AddressExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column addr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ADDRESS and to distinguish it from all other ADDRESSs.
        /// </summary>
        /// <value>
        /// Value of the column addr_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ADDRESS. It serves as a discriminator that partitions ADDRESS into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public AddressCategoryEnum AddressCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column place_name_txt
		///
		/// The character string assigned to represent the name of the place related to the subject address.
        /// </summary>
        /// <value>
        /// Value of the column place_name_txt
        /// </value>
		public string PlaceNameText { get; set; }
		
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
