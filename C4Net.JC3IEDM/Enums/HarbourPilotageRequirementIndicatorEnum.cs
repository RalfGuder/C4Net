using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the HARBOUR requires vessels to have a pilot.
    /// </summary>
    [DomId(100004169)]
    [DataContract]
    public enum HarbourPilotageRequirementIndicatorEnum
    {
		
        /// <summary>
        /// Vessels do not require a pilot to use the harbour.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Vessels do require a pilot to use the harbour.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
