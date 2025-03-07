using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether there is a requirement for the flight leader to provide a report of mission accomplishments.
    /// </summary>
    [DomId(100000223)]
    [DataContract]
    public enum ActionAircraftEmploymentInflightReportRequirementIndicatorEnum
    {
		
        /// <summary>
        /// The flight leader is not to provide a report of mission accomplishments.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The flight leader is to provide a report of mission accomplishments.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
