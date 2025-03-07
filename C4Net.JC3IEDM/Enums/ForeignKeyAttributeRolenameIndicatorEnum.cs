using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether a surrogate name is used for a migrating FOREIGN-KEY-ATTRIBUTE in the base ENTITY.
    /// </summary>
    [DomId(100006017)]
    [DataContract]
    public enum ForeignKeyAttributeRolenameIndicatorEnum
    {
		
        /// <summary>
        /// The migrating attribute has not been rolenamed.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MN")]
        [EnumMember]
        MigratedName,
		
        /// <summary>
        /// The migrating attribute has been rolenamed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RN")]
        [EnumMember]
        RoleName,
		
    }
}
