using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of OBJECT-ITEM.
    /// </summary>
    [DomId(100000144)]
    [DataContract]
    public enum ObjectItemCategoryEnum
    {
		
        /// <summary>
        /// An OBJECT-ITEM that is built, installed or established to serve some particular purpose and is identified by the service it provides rather than by its content.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FA")]
        [EnumMember]
        Facility,
		
        /// <summary>
        /// An OBJECT-ITEM that encompasses meteorological, geographic, and control features of military significance.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FE")]
        [EnumMember]
        Feature,
		
        /// <summary>
        /// An OBJECT-ITEM that is equipment, apparatus or supplies of military interest without distinction as to its application for administrative or combat purposes.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MA")]
        [EnumMember]
        Materiel,
		
        /// <summary>
        /// An OBJECT-ITEM that is an administrative or functional structure.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("OR")]
        [EnumMember]
        Organisation,
		
        /// <summary>
        /// An OBJECT-ITEM that is a human being to whom military or civilian significance is attached.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PE")]
        [EnumMember]
        Person,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
