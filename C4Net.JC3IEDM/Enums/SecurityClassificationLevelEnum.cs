using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the security classification level for the information resource.
    /// </summary>
    [DomId(100004381)]
    [DataContract]
    public enum SecurityClassificationLevelEnum
    {
		
        /// <summary>
        /// The material or information is not associated with any security classification.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("0")]
        [EnumMember]
        Unmarked,
		
        /// <summary>
        /// Unauthorised disclosure would not be detrimental to the interests or effectiveness of the organisation referenced in the policy.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("1")]
        [EnumMember]
        Unclassified,
		
        /// <summary>
        /// Unauthorised disclosure would be detrimental to the interests or effectiveness of the organisation referenced in the policy.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("2")]
        [EnumMember]
        Restricted,
		
        /// <summary>
        /// Unauthorised disclosure would be damaging to the organisation referenced in the policy.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("3")]
        [EnumMember]
        Confidential,
		
        /// <summary>
        /// Unauthorised disclosure would result in grave damage to the organisation referenced in the policy.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("4")]
        [EnumMember]
        Secret,
		
        /// <summary>
        /// Unauthorised disclosure would result in exceptionally grave damage to the organisation referenced in the policy.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("5")]
        [EnumMember]
        TopSecret,
		
    }
}
