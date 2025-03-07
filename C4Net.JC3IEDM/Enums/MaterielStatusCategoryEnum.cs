using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of MATERIEL-STATUS.
    /// </summary>
    [DomId(100004132)]
    [DataContract]
    public enum MaterielStatusCategoryEnum
    {
		
        /// <summary>
        /// A MATERIEL-STATUS that is a record of a condition of an explosive ordnance that has been primed, fused, armed, or otherwise prepared for action, and which has been fired, dropped, launched, placed in such a manner, as to constitute a hazard to operation, and remains unexploded either by malfunction or for any other cause.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("UXOSTA")]
        [EnumMember]
        UxoStatus,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A MATERIEL-STATUS that is a record of condition of a specific MINE.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MNESTA")]
        [EnumMember]
        MineStatus,
		
    }
}
