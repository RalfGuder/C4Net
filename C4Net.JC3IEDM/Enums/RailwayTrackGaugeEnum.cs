using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the distance between the internal sides of rails on a RAILWAY line.
    /// </summary>
    [DomId(100004260)]
    [DataContract]
    public enum RailwayTrackGaugeEnum
    {
		
        /// <summary>
        /// The RAILWAY has a narrow track gauge (3' 5 3/8").
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NAR")]
        [EnumMember]
        Narrow,
		
        /// <summary>
        /// The RAILWAY has a standard track gauge (4' 8 1/2").
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("STD")]
        [EnumMember]
        Standard,
		
    }
}
