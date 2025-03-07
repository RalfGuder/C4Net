using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ENGINEERING-CAPABILITY.
    /// </summary>
    [DomId(100004354)]
    [DataContract]
    public enum EngineeringCapabilityCategoryEnum
    {
		
        /// <summary>
        /// The action or process of making a gap in a wall or barrier.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BRCH")]
        [EnumMember]
        Breaching,
		
        /// <summary>
        /// The action or process of constructing.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CNST")]
        [EnumMember]
        Construction,
		
        /// <summary>
        /// The action or process of demolishing or being demolished.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("DEMO")]
        [EnumMember]
        Demolition,
		
    }
}
