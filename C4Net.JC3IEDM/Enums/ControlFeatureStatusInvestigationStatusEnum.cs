using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the investigation status of the site encompassed by a specific CONTROL-FEATURE.
    /// </summary>
    [DomId(100004103)]
    [DataContract]
    public enum ControlFeatureStatusInvestigationStatusEnum
    {
		
        /// <summary>
        /// There was a formal examination or study on the site associated to the specific control-feature, denying the reason of the investigation.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("INVNEG")]
        [EnumMember]
        InvestigatedNegative,
		
        /// <summary>
        /// There was a formal examination or study on the site associated to the specific control-feature, confirming the reason of the investigation.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("INVPOS")]
        [EnumMember]
        InvestigatedPositive,
		
        /// <summary>
        /// There has been no formal examination or study on the site associated to the specific control-feature.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NONE")]
        [EnumMember]
        None,
		
        /// <summary>
        /// A formal examination or study is been taken on the site associated to the specific control feature.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("UNDINV")]
        [EnumMember]
        UnderInvestigation,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The authority controlling the site associated to the specific control-feature did not allow a formal examination or study on it.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("DENIED")]
        [EnumMember]
        InvestigationDenied,
		
    }
}
