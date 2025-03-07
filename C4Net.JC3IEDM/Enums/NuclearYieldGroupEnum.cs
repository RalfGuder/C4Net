using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the explosive yield of a nuclear weapon that is the amount of energy discharged when the weapon is detonated, expressed in the equivalent mass of trinitrotoluene (TNT), either in kilotons (thousands of tons of TNT) or megatons (millions of tons of TNT).
    /// </summary>
    [DomId(100004375)]
    [DataContract]
    public enum NuclearYieldGroupEnum
    {
		
        /// <summary>
        /// Yield Group ALFA is less than 2 KT.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ALFA")]
        [EnumMember]
        Alfa,
		
        /// <summary>
        /// Yield Group BRAVO is 2 KT to less than 5 KT.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BRAVO")]
        [EnumMember]
        Bravo,
		
        /// <summary>
        /// Yield Group CHARLIE is 5 KT to less than 30 KT.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CHARLI")]
        [EnumMember]
        Charlie,
		
        /// <summary>
        /// Yield Group DELTA is 30 KT to less than 100 KT.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DELTA")]
        [EnumMember]
        Delta,
		
        /// <summary>
        /// Yield Group ECHO is 100 KT to less than 300 KT.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ECHO")]
        [EnumMember]
        Echo,
		
        /// <summary>
        /// Yield Group FOXTROT is 300 KT to less than 1000 KT.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("FOXTRT")]
        [EnumMember]
        Foxtrot,
		
        /// <summary>
        /// Yield Group GOLF is 1000 KT to less than 3000 KT.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("GOLF")]
        [EnumMember]
        Golf,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
