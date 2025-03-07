using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the temporal variation of the effectiveness of a biological or chemical materiel under determined conditions after its dispersal.
    /// </summary>
    [DomId(100000353)]
    [DataContract]
    public enum PersistencyEnum
    {
		
        /// <summary>
        /// Agents that are disseminated mainly as vapour, but some of the agent types may leave unevaporated liquid in shell or bomb craters for either hours or days depending upon the climatic conditions and the munition type. Craters should be avoided until tests have proved the absence of a liquid hazard.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NONPRS")]
        [EnumMember]
        NonPersistent,
		
        /// <summary>
        /// Agents that are disseminated as liquid and present a vapour hazard as well as a contact hazard. This hazard will last for several hours to days depending on the terrain, climatic conditions and munition type.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PRSTNT")]
        [EnumMember]
        Persistent,
		
        /// <summary>
        /// Agents that may have to be treated as persistent, ground contaminating agents. Blister agents are normally classified as persistent agents and will be so indicated when detected by three way detection paper. Some agents however, are very volatile and should be treated as nonpersistent, but still ground contaminating agents.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("THCKND")]
        [EnumMember]
        Thickened,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
