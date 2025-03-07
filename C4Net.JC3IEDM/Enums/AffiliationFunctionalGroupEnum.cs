using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the category of functional group.
    /// </summary>
    [DomId(100004161)]
    [DataContract]
    public enum AffiliationFunctionalGroupEnum
    {
		
        /// <summary>
        /// Affiliation is directed to a group that is organised for the conduct of criminal activity.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CRIMIN")]
        [EnumMember]
        Criminal,
		
        /// <summary>
        /// Affiliation is directed to a group whose charter is based on a treaty signed by multiple nations.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MULTIN")]
        [EnumMember]
        Multinational,
		
        /// <summary>
        /// Affiliation is directed to a group that is organised for the conduct of terrorist activity.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TERRST")]
        [EnumMember]
        Terrorist,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// Affiliation is directed to a group that exists solely for the purpose of practice, rehearsal or training in the conduct of operations.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("EXER")]
        [EnumMember]
        Exercise,
		
        /// <summary>
        /// Affiliation is directed to a group that provides financial support.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("FINANC")]
        [EnumMember]
        Financial,
		
        /// <summary>
        /// Affiliation is directed to a group that is involved within a political area of activity and concerned with politics or has ties to a political party.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("POLTCL")]
        [EnumMember]
        Political,
		
        /// <summary>
        /// Affiliation is directed to a unit of socio-political organization consisting of a number of families, clans, or other groups who share a common ancestry and culture.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("TRIBAL")]
        [EnumMember]
        Tribal,
		
    }
}
