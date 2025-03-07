using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the ENTITY as standard (non-loggable) or loggable.
    /// </summary>
    [DomId(100006016)]
    [DataContract]
    public enum EntityStorageTypeEnum
    {
		
        /// <summary>
        /// The entity is to be treated as loggable.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LOG")]
        [EnumMember]
        Loggable,
		
        /// <summary>
        /// The entity is to be treated as standard (non-loggable).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("STD")]
        [EnumMember]
        Standard,
		
    }
}
