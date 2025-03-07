using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of RELATIONSHIP being specified.
    /// </summary>
    [DomId(100006025)]
    [DataContract]
    public enum RelationshipTypeEnum
    {
		
        /// <summary>
        /// A one-way RELATIONSHIP that identifies a specific “parent” ENTITY with a specific “child” ENTITY where the child is a dependent ENTITY whose set of key attributes may differ from the set of key attributes of the parent.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CR")]
        [EnumMember]
        CardinalityRelationship,
		
        /// <summary>
        /// A RELATIONSHIP that identifies a subset of instances of a Parent ENTITY as an entity itself, which has a set of primary key attributes that are identical to those of the Parent ENTITY.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SR")]
        [EnumMember]
        SubtypeRelationship,
		
    }
}
