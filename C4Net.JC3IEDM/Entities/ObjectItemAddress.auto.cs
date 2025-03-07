using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-ITEM-ADDRESS that represents the table OBJ_ITEM_ADDR.
	///
	/// An association between an OBJECT-ITEM and an ADDRESS to specify the means by which a FACILITY, ORGANISATION or PERSON can be accessed.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectItemAddress", "C4Net.JC3IEDM.Definitions.ObjectItemAddress.definition.xml")]
    public class ObjectItemAddress : IEntity, IObjectItemAddress
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectItemAddressExpression _ = new ObjectItemAddressExpression();

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
        /// Gets or sets the value of the column addr_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ADDRESS and to distinguish it from all other ADDRESSs.
        /// </summary>
        /// <value>
        /// Value of the column addr_id
        /// </value>
		public decimal AddressId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_addr_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-ADDRESS for a specific OBJECT-ITEM and a specific ADDRESS and to distinguish it from all other OBJECT-ITEM-ADDRESSs for that OBJECT-ITEM and that ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_addr_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column call_sign_txt
		///
		/// The character string assigned to represent a specific OBJECT-ITEM that uses a specific ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column call_sign_txt
        /// </value>
		public string CallSignText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column primacy_code
		///
		/// The specific value that represents the priority that a specific ADDRESS has with respect to a specific OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column primacy_code
        /// </value>
		public ObjectItemAddressPrimacyEnum? Primacy { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column auth_ind_code
		///
		/// The specific value that denotes whether the OBJECT-ITEM is permitted by command authority to use a specific ELECTRONIC-ADDRESS.
        /// </summary>
        /// <value>
        /// Value of the column auth_ind_code
        /// </value>
		public ObjectItemAddressAuthorisationIndicatorEnum? AuthorisationIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column trns_rcv_code
		///
		/// The specific value that denotes the OBJECT-ITEM usage of an ELECTRONIC-ADDRESS in terms of transmission and reception.
        /// </summary>
        /// <value>
        /// Value of the column trns_rcv_code
        /// </value>
		public ObjectItemAddressTransmitReceiveEnum? TransmitReceive { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_id
        /// </value>
		public decimal? NetworkId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column netwrk_freq_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-FREQUENCY for a specific NETWORK and to distinguish it from all other NETWORK-FREQUENCYs for that NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_freq_ix
        /// </value>
		public decimal? NetworkFrequencyIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal? ReportingDataId { get; set; }
		
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
