using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the percentage value used to compute the inevitable delays caused by the type of signalling in use on the RAILWAY line.
    /// </summary>
    [DomId(100004263)]
    [DataContract]
    public enum RailwaySignalSystemEfficiencyEnum
    {
		
        /// <summary>
        /// The specific efficiency percentage represents rudimental signalling.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("50")]
        [EnumMember]
        _5065,
		
        /// <summary>
        /// The specific efficiency percentage represents normal block operations.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("70")]
        [EnumMember]
        _7075,
		
        /// <summary>
        /// The specific efficiency percentage represents automatic signalling and/or centralised traffic control.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("80")]
        [EnumMember]
        _8085,
		
        /// <summary>
        /// The specific efficiency percentage represents computerised traffic control.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("85")]
        [EnumMember]
        _85,
		
    }
}
