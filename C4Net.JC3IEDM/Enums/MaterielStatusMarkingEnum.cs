using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of marking of a specific MATERIEL.
    /// </summary>
    [DomId(100000390)]
    [DataContract]
    public enum MaterielStatusMarkingEnum
    {
		
        /// <summary>
        /// A set of integers.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NUMBER")]
        [EnumMember]
        Numbers,
		
        /// <summary>
        /// A long narrow band distinguished, as by colour, from the surrounding material or surface. This value includes band.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("STRIPE")]
        [EnumMember]
        Stripe,
		
        /// <summary>
        /// Multiple long narrow bands distinguished, as by colour, from the surrounding material or surface. This value includes bands.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("STRIPS")]
        [EnumMember]
        Stripes,
		
        /// <summary>
        /// A token for identification.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SYMBOL")]
        [EnumMember]
        Symbols,
		
        /// <summary>
        /// Language symbols or characters written or imprinted on a surface.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("WRITNG")]
        [EnumMember]
        Writing,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
