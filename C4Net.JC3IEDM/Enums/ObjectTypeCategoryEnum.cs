using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of OBJECT-TYPE.
    /// </summary>
    [DomId(100000148)]
    [DataContract]
    public enum ObjectTypeCategoryEnum
    {
		
        /// <summary>
        /// An OBJECT-TYPE that is intended to be built, installed or established to serve some particular purpose and is identified by the service it is intended to provided rather than by its content.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FA")]
        [EnumMember]
        FacilityType,
		
        /// <summary>
        /// An OBJECT-TYPE that encompasses meteorological, geographic, and control features of military significance.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FE")]
        [EnumMember]
        FeatureType,
		
        /// <summary>
        /// An OBJECT-TYPE that represents equipment, apparatus or supplies of military interest without distinction to its application for administrative or combat purposes.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MA")]
        [EnumMember]
        MaterielType,
		
        /// <summary>
        /// An OBJECT-TYPE that represents administrative or functional structures.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("OR")]
        [EnumMember]
        OrganisationType,
		
        /// <summary>
        /// An OBJECT-TYPE that represents human beings about whom information is to be held.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PE")]
        [EnumMember]
        PersonType,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
