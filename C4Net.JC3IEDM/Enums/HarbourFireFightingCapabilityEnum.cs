using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of fire fighting capability available at a specific HARBOUR.
    /// </summary>
    [DomId(100004164)]
    [DataContract]
    public enum HarbourFireFightingCapabilityEnum
    {
		
        /// <summary>
        /// Fire fighting assets are located onboard vessels that may or may not be specifically fitted for a fire-fighting role.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AFLOAT")]
        [EnumMember]
        Afloat,
		
        /// <summary>
        /// Fire fighting assets are either provided from fixed land based assets, hydrants, or mobile land based equipment, fire engines, pumps.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ASHORE")]
        [EnumMember]
        Ashore,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
