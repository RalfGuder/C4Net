using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the known status of a MINEFIELD-MARITIME.
    /// </summary>
    [DomId(100004318)]
    [DataContract]
    public enum MinefieldMaritimeStatusEnum
    {
		
        /// <summary>
        /// A maritime minefield area that presents such a threat that waterborne shipping is prevented from moving.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CLOSED")]
        [EnumMember]
        Closed,
		
        /// <summary>
        /// No known threat to shipping from maritime mines exists.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OPEN")]
        [EnumMember]
        Open,
		
    }
}
