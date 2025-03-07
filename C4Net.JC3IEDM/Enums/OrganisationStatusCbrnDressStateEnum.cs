using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the Mission Oriented Protective Posture (MOPP) status defining the NBC (CBRN) dress code of a specific ORGANISATION.
    /// </summary>
    [DomId(100004159)]
    [DataContract]
    public enum OrganisationStatusCbrnDressStateEnum
    {
		
        /// <summary>
        /// Mask is carried. First set individual protection equipment is available within 2 hours, second set individual protection equipment is available within 6 hours.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MOPPRY")]
        [EnumMember]
        MoppReady,
		
        /// <summary>
        /// Mask is carried. Individual protection equipment is immediately available.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MOPP0")]
        [EnumMember]
        Mopp0,
		
        /// <summary>
        /// Mask is carried. Suit worn, boots and gloves are carried.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MOPP1")]
        [EnumMember]
        Mopp1,
		
        /// <summary>
        /// Mask is carried. Suit and boots worn, gloves are carried.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MOPP2")]
        [EnumMember]
        Mopp2,
		
        /// <summary>
        /// Mask is carried. Suit, boots and gloves are worn.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MOPP3")]
        [EnumMember]
        Mopp3,
		
    }
}
