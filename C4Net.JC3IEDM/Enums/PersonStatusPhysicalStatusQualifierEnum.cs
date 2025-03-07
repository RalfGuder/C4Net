using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that qualifies the health conditions of a specific PERSON at a specific point in time.
    /// </summary>
    [DomId(100000379)]
    [DataContract]
    public enum PersonStatusPhysicalStatusQualifierEnum
    {
		
        /// <summary>
        /// The PERSON is incapacitated due to an injury resulting from an event other than an armed conflict.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("INJRD")]
        [EnumMember]
        Injured,
		
        /// <summary>
        /// The PERSON has an illness, caused by a disease that is likely to transmit to others.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ILLCNT")]
        [EnumMember]
        IllContagious,
		
        /// <summary>
        /// The PERSON has an illness, caused by a disease that is not transmittable to others.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ILLNCN")]
        [EnumMember]
        IllNonContagious,
		
        /// <summary>
        /// The PERSON has an illness, caused by an unidentified disease.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ILLUNK")]
        [EnumMember]
        IllUnknownDisease,
		
        /// <summary>
        /// The PERSON is expecting a baby.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PRGNT")]
        [EnumMember]
        Pregnant,
		
        /// <summary>
        /// The PERSON is incapacitated due to an injury resulting from an armed conflict.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("WNDD")]
        [EnumMember]
        Wounded,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
