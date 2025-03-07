using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity NETWORK-CAPACITY that represents the table NETWRK_CAP.
	///
	/// An identification of the specific capacities of a NETWORK.
    /// </summary>
    [Serializable]
    [DefinitionName("NetworkCapacity", "C4Net.JC3IEDM.Definitions.NetworkCapacity.definition.xml")]
    public class NetworkCapacity : IEntity, INetworkCapacity
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly NetworkCapacityExpression _ = new NetworkCapacityExpression();

        #endregion

        #region - Properties -
		
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
        /// Gets or sets the value of the column netwrk_cap_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific NETWORK-CAPACITY for a specific NETWORK and to distinguish it from all other NETWORK-CAPACITYs for that NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column netwrk_cap_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column bandwidth_code
		///
		/// The specific value that represents a bandwidth capacity that is supported by a NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column bandwidth_code
        /// </value>
		public NetworkCapacityBandwidthEnum? Bandwidth { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column protocol_code
		///
		/// The specific value that represents an application-level (OSI model level 3 to 7) protocol governing the information transfer in a NETWORK.
        /// </summary>
        /// <value>
        /// Value of the column protocol_code
        /// </value>
		public NetworkCapacityProtocolEnum? Protocol { get; set; }
		
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
