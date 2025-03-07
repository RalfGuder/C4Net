using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of CBRN-EVENT.
    /// </summary>
    [DomId(100000356)]
    [DataContract]
    public enum CbrnEventCategoryEnum
    {
		
        /// <summary>
        /// The release of an unknown chemical, biological, nuclear, radiological materiel(s) [agent(s)] into the environment intentionally or accidentally but not for the intended purpose of conducting an attack.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("UNROTA")]
        [EnumMember]
        UnidentifiedReleaseOtherThanAttackRota,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A CBRN-EVENT involving chemical and/or biological materiel.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("CHMBIO")]
        [EnumMember]
        ChemicalBiologicalEvent,
		
        /// <summary>
        /// A CBRN-EVENT involving radioactive materiel(s).
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("RADCTV")]
        [EnumMember]
        RadioactiveEvent,
		
    }
}
