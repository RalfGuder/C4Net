using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of MILITARY-OBSTACLE.
    /// </summary>
    [DomId(100004148)]
    [DataContract]
    public enum MilitaryObstacleCategoryEnum
    {
		
        /// <summary>
        /// A MILITARY-OBSTACLE that is an area of land or water containing mines.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MNFLD")]
        [EnumMember]
        Minefield,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
