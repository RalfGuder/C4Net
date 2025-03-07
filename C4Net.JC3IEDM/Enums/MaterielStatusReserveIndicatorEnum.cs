using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether a specific MATERIEL has been placed in reserve.
    /// </summary>
    [DomId(100000258)]
    [DataContract]
    public enum MaterielStatusReserveIndicatorEnum
    {
		
        /// <summary>
        /// The specific MATERIEL is not in reserve status.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The specific MATERIEL is currently in reserve status.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
