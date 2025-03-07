using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a loading capability of an AIRCRAFT-TYPE.
    /// </summary>
    [DomId(100004203)]
    [DataContract]
    public enum AircraftTypeLoadCategoryEnum
    {
		
        /// <summary>
        /// An aircraft is capable of lifting heavy loads.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HEAVY")]
        [EnumMember]
        Heavy,
		
        /// <summary>
        /// An aircraft is capable of lifting lightweight loads.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LIGHT")]
        [EnumMember]
        Light,
		
        /// <summary>
        /// An aircraft is capable of lifting medium weight loads.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MEDIUM")]
        [EnumMember]
        Medium,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
