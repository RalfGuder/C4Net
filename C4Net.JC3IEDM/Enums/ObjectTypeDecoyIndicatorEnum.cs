using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether a specific OBJECT-TYPE represents an object class acting as a decoy.
    /// </summary>
    [DomId(100000300)]
    [DataContract]
    public enum ObjectTypeDecoyIndicatorEnum
    {
		
        /// <summary>
        /// The OBJECT-TYPE represents an object not acting as a decoy or dummy.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The OBJECT-TYPE represents an object acting as a decoy or dummy.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
