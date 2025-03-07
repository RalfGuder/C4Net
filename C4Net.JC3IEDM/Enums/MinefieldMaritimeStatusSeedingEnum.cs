using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates the seeding details for a MINEFIELD-MARITIME.
    /// </summary>
    [DomId(100004322)]
    [DataContract]
    public enum MinefieldMaritimeStatusSeedingEnum
    {
		
        /// <summary>
        /// The original laying of the maritime minefield.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("INITAL")]
        [EnumMember]
        InitialImplant,
		
        /// <summary>
        /// The first addition of replacement or extra mines to a minefield.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("FIRST")]
        [EnumMember]
        FirstReseeding,
		
        /// <summary>
        /// The second addition of replacement or extra mines to a minefield.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SECOND")]
        [EnumMember]
        SecondReseeding,
		
        /// <summary>
        /// The third addition of replacement or extra mines to a minefield.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("THIRD")]
        [EnumMember]
        ThirdReseeding,
		
        /// <summary>
        /// The fourth addition of replacement or extra mines to a minefield.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("FOURTH")]
        [EnumMember]
        FourthReseeding,
		
        /// <summary>
        /// The fifth addition of replacement or extra mines to a minefield.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("FIFTH")]
        [EnumMember]
        FifthReseeding,
		
        /// <summary>
        /// The sixth addition of replacement or extra mines to a minefield.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("SIXTH")]
        [EnumMember]
        SixthReseeding,
		
        /// <summary>
        /// The seventh addition of replacement or extra mines to a minefield.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SEVNTH")]
        [EnumMember]
        SeventhReseeding,
		
        /// <summary>
        /// The eighth addition of replacement or extra mines to a minefield.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("EIGHTH")]
        [EnumMember]
        EighthReseeding,
		
        /// <summary>
        /// The ninth addition of replacement or extra mines to a minefield.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NINTH")]
        [EnumMember]
        NinthReseeding,
		
    }
}
