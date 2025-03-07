using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the ENTITY is independent for its meaning and instances from all other instance of ENTITY.
    /// </summary>
    [DomId(100006015)]
    [DataContract]
    public enum EntityDependencyEnum
    {
		
        /// <summary>
        /// The entity is dependent upon one or more parents for its identity.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DE")]
        [EnumMember]
        DependentEntity,
		
        /// <summary>
        /// The entity is independent for its meaning and instances from all other instance of entity.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("IE")]
        [EnumMember]
        IndependentEntity,
		
        /// <summary>
        /// The entity is dependent upon one parent for its identity.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SE")]
        [EnumMember]
        SubtypeEntity,
		
    }
}
