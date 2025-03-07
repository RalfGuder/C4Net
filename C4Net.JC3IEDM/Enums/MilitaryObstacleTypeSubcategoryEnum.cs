using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class of MILITARY-OBSTACLE-TYPE.
    /// </summary>
    [DomId(100004379)]
    [DataContract]
    public enum MilitaryObstacleTypeSubcategoryEnum
    {
		
        /// <summary>
        /// The obstacle is prefabricated and can not be moved.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FXAMOV")]
        [EnumMember]
        FixedAndPrefabricated,
		
        /// <summary>
        /// It is possible to move the obstacle.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MOVABL")]
        [EnumMember]
        Moveable,
		
        /// <summary>
        /// The obstacle is prefabricated and can be moved.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MOVAPR")]
        [EnumMember]
        MoveableAndPrefabricated,
		
    }
}
