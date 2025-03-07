using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the height of the inversion layer in the atmosphere. The stability class describes the degree of mixing of released material in the atmosphere.
    /// </summary>
    [DomId(100004308)]
    [DataContract]
    public enum AtmosphereInversionLayerEnum
    {
		
        /// <summary>
        /// Top of inversion layer lower than 800 metres above ground.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("A")]
        [EnumMember]
        A,
		
        /// <summary>
        /// Top of inversion layer lower than 400 metres above ground.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("B")]
        [EnumMember]
        B,
		
        /// <summary>
        /// Top of inversion layer lower than 200 metres above ground.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("C")]
        [EnumMember]
        C,
		
    }
}
