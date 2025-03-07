using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the presence of a crater.
    /// </summary>
    [DomId(100004273)]
    [DataContract]
    public enum NuclearWeaponEventCraterPresenceEnum
    {
		
        /// <summary>
        /// There is a crater present.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CRATER")]
        [EnumMember]
        CraterPresent,
		
        /// <summary>
        /// There is a no crater present.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NONE")]
        [EnumMember]
        NoCraterPresent,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
