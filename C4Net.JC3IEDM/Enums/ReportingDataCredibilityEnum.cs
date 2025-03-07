using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents, for normal operational use, the degree of trustworthiness of the data referenced by a specific REPORTING-DATA.
    /// </summary>
    [DomId(100000279)]
    [DataContract]
    public enum ReportingDataCredibilityEnum
    {
		
        /// <summary>
        /// Basis for the estimate cannot be ascertained.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("IND")]
        [EnumMember]
        Indeterminate,
		
        /// <summary>
        /// Data is reported by different sources whose integrity is not in question.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("RPTFCT")]
        [EnumMember]
        ReportedAsAFact,
		
        /// <summary>
        /// Reported data is considered as possible or probable.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("RPTPLA")]
        [EnumMember]
        ReportedAsPlausible,
		
        /// <summary>
        /// Reported data is open to or can be viewed with suspicion.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("RPTUNC")]
        [EnumMember]
        ReportedAsUncertain,
		
    }
}
