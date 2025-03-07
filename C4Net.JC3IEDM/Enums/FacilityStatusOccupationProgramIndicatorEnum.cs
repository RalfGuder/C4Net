using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether an occupation programme is present at the facility.
    /// </summary>
    [DomId(100000386)]
    [DataContract]
    public enum FacilityStatusOccupationProgramIndicatorEnum
    {
		
        /// <summary>
        /// There is no occupation program present.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// There is an occupation program present.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
