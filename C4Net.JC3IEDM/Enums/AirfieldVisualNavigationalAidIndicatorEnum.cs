using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value indicating whether or not the airport has a visual navigational aid displaying flashes of white or colored light to indicate the location of an airport.
    /// </summary>
    [DomId(100004257)]
    [DataContract]
    public enum AirfieldVisualNavigationalAidIndicatorEnum
    {
		
        /// <summary>
        /// Visual navigational aid is not available at the airfield.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// Visual navigational aid is available at the airfield.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
