using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents a subjective indication of the effect of weather conditions on a specific operation.
    /// </summary>
    [DomId(100004343)]
    [DataContract]
    public enum ActionTaskMeteorologicalImpactEnum
    {
		
        /// <summary>
        /// The meteorological conditions will not affect the specific operation.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ACCPTB")]
        [EnumMember]
        Acceptable,
		
        /// <summary>
        /// The meteorological conditions will render the specific operation with a moderate risk of failure.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MARGNL")]
        [EnumMember]
        Marginal,
		
        /// <summary>
        /// The meteorological conditions will render the specific operation with a high risk of failure.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("UNACC")]
        [EnumMember]
        Unacceptable,
		
    }
}
