using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes an identification scheme used for recording a CANDIDATE-TARGET-DETAIL.
    /// </summary>
    [DomId(100000269)]
    [DataContract]
    public enum CandidateTargetDetailSchemeEnum
    {
		
        /// <summary>
        /// Australian, British, Canadian and American target numbering system.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ABCA")]
        [EnumMember]
        Abca,
		
        /// <summary>
        /// Basic Encyclopedia.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BE")]
        [EnumMember]
        Be,
		
        /// <summary>
        /// Field Initiated Basic Encyclopedia Numbering System.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FIBE")]
        [EnumMember]
        Fibe,
		
        /// <summary>
        /// An identification of an installation, facility or physical area of potential significance as objective for attack.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SITENR")]
        [EnumMember]
        SiteNumber,
		
        /// <summary>
        /// Target numbering is given by the nominating organisation.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ORGANL")]
        [EnumMember]
        Organisational,
		
    }
}
