using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the severity of a particular ICING.
    /// </summary>
    [DomId(100000303)]
    [DataContract]
    public enum IcingSeverityQualifierEnum
    {
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LIGHT")]
        [EnumMember]
        Light,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MODER")]
        [EnumMember]
        Moderate,
		
        /// <summary>
        /// No definition provided in APP-6A.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SEVERE")]
        [EnumMember]
        Severe,
		
    }
}
