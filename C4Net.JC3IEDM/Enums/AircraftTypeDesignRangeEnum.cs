using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the designed range of an AIRCRAFT-TYPE.
    /// </summary>
    [DomId(100004370)]
    [DataContract]
    public enum AircraftTypeDesignRangeEnum
    {
		
        /// <summary>
        /// Distances above 4,630 kilometres.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LONG")]
        [EnumMember]
        Long,
		
        /// <summary>
        /// Distances between 1,852 to 4,630 kilometres.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MEDIUM")]
        [EnumMember]
        Medium,
		
        /// <summary>
        /// Distances less than 1,852 kilometres.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SHORT")]
        [EnumMember]
        Short,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
