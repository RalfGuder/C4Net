using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether the ATTRIBUTE plays the role of a foreign key in the ENTITY and thereby owned by another ENTITY.
    /// </summary>
    [DomId(100006003)]
    [DataContract]
    public enum AttributeForeignKeyIndicatorEnum
    {
		
        /// <summary>
        /// That subset of ATTRIBUTE owned by the ENTITY to which the members belong; that is, they are not foreign key attributes migrating from another ENTITY under some relationship.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BA")]
        [EnumMember]
        BaseAttribute,
		
        /// <summary>
        /// An ATTRIBUTE that has been migrated under a RELATIONSHIP from the primary key of the "Parent" ENTITY of that RELATIONSHIP.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FK")]
        [EnumMember]
        ForeignKeyAttribute,
		
    }
}
