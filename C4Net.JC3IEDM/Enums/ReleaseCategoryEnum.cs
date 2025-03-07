using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the chemical, biological, or radiological class of release.
    /// </summary>
    [DomId(100000361)]
    [DataContract]
    public enum ReleaseCategoryEnum
    {
		
        /// <summary>
        /// A continuous discharge of a contaminant release in a release other than attack (ROTA) event.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CONT")]
        [EnumMember]
        Continuous,
		
        /// <summary>
        /// A single discharge of a contaminant release in a release other than attack (ROTA) event.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PUFF")]
        [EnumMember]
        SingleReleaseOfACloud,
		
        /// <summary>
        /// The spraying of a contaminant in a release other than attack (ROTA) event.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SPRAY")]
        [EnumMember]
        Spraying,
		
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
		
    }
}
