using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the categorisation of casualties by group.
    /// </summary>
    [DomId(100000321)]
    [DataContract]
    public enum CasualtyGroupEnum
    {
		
        /// <summary>
        /// The casualty is a member of the friendly force.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FRFOR")]
        [EnumMember]
        FriendlyForces,
		
        /// <summary>
        /// The casualty is a member of the opposing force.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OPFOR")]
        [EnumMember]
        OpposingForces,
		
        /// <summary>
        /// The casualty is a local civilian.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LOCCIV")]
        [EnumMember]
        LocalCivilians,
		
    }
}
