using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents, for usual operational purposes, the nature of a specific REPORTING-DATA.
    /// </summary>
    [DomId(100000294)]
    [DataContract]
    public enum ReportingDataCategoryEnum
    {
		
        /// <summary>
        /// A REPORTING-DATA that points to data that is considered to be valid without being based on fact or observation.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ASS")]
        [EnumMember]
        Assumed,
		
        /// <summary>
        /// A REPORTING-DATA that points to data that is wrong.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ERR")]
        [EnumMember]
        Erroneous,
		
        /// <summary>
        /// A REPORTING-DATA that points to data derived from multiple sources.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("INFER")]
        [EnumMember]
        Inferred,
		
        /// <summary>
        /// A REPORTING-DATA that points to data expected to be true in the future.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PLAN")]
        [EnumMember]
        Planned,
		
        /// <summary>
        /// A REPORTING-DATA that points to data based on fact or observation.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("REP")]
        [EnumMember]
        Reported,
		
        /// <summary>
        /// A REPORTING-DATA that points to data that results from extrapolating, estimating, or foretelling a future condition or state.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PRDCTD")]
        [EnumMember]
        Predicted,
		
    }
}
