using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes the protective posture of personnel for the specific TARGET.
    /// </summary>
    [DomId(100000312)]
    [DataContract]
    public enum TargetPersonnelProtectionCategoryEnum
    {
		
        /// <summary>
        /// First volley (under overhead cover); second volley (under overhead cover).
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("COVER")]
        [EnumMember]
        UnderCover,
		
        /// <summary>
        /// First volley (dug in); second volley (dug in).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DUGIN")]
        [EnumMember]
        DugIn,
		
        /// <summary>
        /// First volley (half prone; half standing); second volley (all prone).
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PRAND")]
        [EnumMember]
        HalfProneHalfStanding,
		
        /// <summary>
        /// First volley (prone); second volley (prone).
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PRONE")]
        [EnumMember]
        Prone,
		
        /// <summary>
        /// First volley (prone); second volley (under overhead cover).
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PROVER")]
        [EnumMember]
        ProneUnderCover,
		
        /// <summary>
        /// First volley (prone); second volley (dug in).
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("PRUG")]
        [EnumMember]
        ProneDugIn,
		
    }
}
