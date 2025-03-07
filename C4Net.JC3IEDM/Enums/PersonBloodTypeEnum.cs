using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// A code which represents the specific blood type of a PERSON.
    /// </summary>
    [DomId(100000177)]
    [DataContract]
    public enum PersonBloodTypeEnum
    {
		
        /// <summary>
        /// The circulating red blood cells with 'A' antigen and the presence of the 'Rh' antigen.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("APLUS")]
        [EnumMember]
        ARhPositive,
		
        /// <summary>
        /// The circulating red blood cells with 'A' antigen and the absence of the 'Rh' antigen.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AMNUS")]
        [EnumMember]
        ARhNegative,
		
        /// <summary>
        /// The circulating red blood cells with 'B' antigen and the presence of the 'Rh' antigen.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BPLUS")]
        [EnumMember]
        BRhPositive,
		
        /// <summary>
        /// The circulating red blood cells with 'B' antigen and the absence of the 'Rh' antigen.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("BMNUS")]
        [EnumMember]
        BRhNegative,
		
        /// <summary>
        /// The circulating red blood cells with 'A' and 'B' antigen and the presence of the 'Rh' antigen.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ABPLUS")]
        [EnumMember]
        AbRhPositive,
		
        /// <summary>
        /// The circulating red blood cells with 'A' and 'B' antigen and the absence of the 'Rh' antigen.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ABMNUS")]
        [EnumMember]
        AbRhNegative,
		
        /// <summary>
        /// The circulating red blood cells that lack 'A' and 'B' antigen and the presence of the 'Rh' antigen.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("OPLUS")]
        [EnumMember]
        ORhPositive,
		
        /// <summary>
        /// The circulating red blood cells that lack 'A' and 'B' antigen and the absence of the 'Rh' antigen.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("OMNUS")]
        [EnumMember]
        ORhNegative,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
