using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ELECTRONIC-ADDRESS that represents the table ELCTRNC_ADDR.
	///
	/// An ADDRESS that is reached by using the specified NETWORK-SERVICE.
    /// </summary>
    [Serializable]
    [DefinitionName("ElectronicAddress", "C4Net.JC3IEDM.Definitions.ElectronicAddress.definition.xml")]
    public class ElectronicAddress : Address, IElectronicAddress
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ElectronicAddressExpression _ = new ElectronicAddressExpression();

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
		public decimal AddressId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column name_txt
		///
		/// The character string assigned to represent a specific ELECTRONIC-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column name_txt
        /// </value>
		public string NameText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_id
        /// </value>
		public decimal NetworkId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_service_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-SERVICE for a specific NETWORK and to distinguish it from all other NETWORK-SERVICEs for that NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_service_ix
        /// </value>
		public decimal NetworkServiceIndex { get; set; }
		
        #endregion
    }
}
