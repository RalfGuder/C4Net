using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes whether a detail is a ‘major part’ when the established and detail OBJECT-TYPEs are instances of MATERIEL-TYPE.
    /// </summary>
    [DomId(100004192)]
    [DataContract]
    public enum ObjectTypeEstablishmentObjectTypeDetailMajorPartIndicatorEnum
    {
		
        /// <summary>
        /// An indication that the MATERIEL-TYPE specified as the detail of the OBJECT-TYPE-ESTABLISHMENT is not designated as a major part.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// An indication that the MATERIEL-TYPE specified as the detail of the OBJECT-TYPE-ESTABLISHMENT is designated as a major part.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
