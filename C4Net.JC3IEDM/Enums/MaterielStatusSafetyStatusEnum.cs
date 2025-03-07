using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the arming state of a specific MATERIEL that is a weapon or ammunition.
    /// </summary>
    [DomId(100000393)]
    [DataContract]
    public enum MaterielStatusSafetyStatusEnum
    {
		
        /// <summary>
        /// The specific MATERIEL is dismantled or taken apart so that it is not operable, but it can be operable if reassembled.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("UNASMB")]
        [EnumMember]
        Unassembled,
		
        /// <summary>
        /// The state in which material cannot function and in which it is safe to handle and transport.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SAFE")]
        [EnumMember]
        Safe,
		
        /// <summary>
        /// The specific MATERIEL is ready to fire or explode.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ARMED")]
        [EnumMember]
        Armed,
		
        /// <summary>
        /// The specific MATERIEL has been rendered incapable of firing or exploding, although it may remain dangerous to handle.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NUTRLD")]
        [EnumMember]
        Neutralized,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
