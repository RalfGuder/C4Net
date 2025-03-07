using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the placement of a specific ORBIT-AREA with respect to its defining reference axis.
    /// </summary>
    [DomId(100004105)]
    [DataContract]
    public enum OrbitAreaAlignmentEnum
    {
		
        /// <summary>
        /// The sides of a specific ORBIT-AREA are equidistant from the reference axis.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CENTRE")]
        [EnumMember]
        Centre,
		
        /// <summary>
        /// The right side of a specific ORBIT-AREA coincides with the reference axis.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LEFT")]
        [EnumMember]
        Left,
		
        /// <summary>
        /// The left side of a specific ORBIT-AREA coincides with the reference axis.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RIGHT")]
        [EnumMember]
        Right,
		
    }
}
