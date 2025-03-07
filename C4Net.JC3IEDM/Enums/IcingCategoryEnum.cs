using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of a particular ICING.
    /// </summary>
    [DomId(100000302)]
    [DataContract]
    public enum IcingCategoryEnum
    {
		
        /// <summary>
        /// Glossy, clear, or translucent ice formed by the relatively slow freezing of large supercooled droplets. The droplets spread out over the airframe surface before completely freezing.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CLRICE")]
        [EnumMember]
        ClearIcing,
		
        /// <summary>
        /// Rough, milky opaque ice formed by the instantaneous freezing of small supercooled droplets which trap air within the ice as they strike the aircraft.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RIMICE")]
        [EnumMember]
        RimeIcing,
		
        /// <summary>
        /// A hard rough conglomerate of ice that can cause very rough accumulation and severe loss of lift.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MIXICE")]
        [EnumMember]
        MixedIcing,
		
    }
}
