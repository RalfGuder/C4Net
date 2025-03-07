using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether an estimated time of arrival message is required.
    /// </summary>
    [DomId(100004298)]
    [DataContract]
    public enum HarbourEstimatedTimeOfArrivalIndicatorEnum
    {
		
        /// <summary>
        /// An estimated time of arrival message is not required.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// An estimated time of arrival message is required.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
