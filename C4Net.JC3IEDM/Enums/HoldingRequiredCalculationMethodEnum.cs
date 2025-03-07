using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the required stocks calculation method used for the count of OBJECT-TYPEs in a specific HOLDING.
    /// </summary>
    [DomId(100004330)]
    [DataContract]
    public enum HoldingRequiredCalculationMethodEnum
    {
		
        /// <summary>
        /// The method used to complete the required stocks calculation of a specific HOLDING is based on the level of effort methodology.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LVLOEF")]
        [EnumMember]
        LevelOfEffort,
		
        /// <summary>
        /// The method used to complete the required stocks calculation of a specific HOLDING is based on the target related methodology.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("TARGET")]
        [EnumMember]
        Target,
		
    }
}
