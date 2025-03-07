using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of FEATURE-TYPE.
    /// </summary>
    [DomId(100000135)]
    [DataContract]
    public enum FeatureTypeCategoryEnum
    {
		
        /// <summary>
        /// A non-tangible FEATURE-TYPE of military interest that may be represented as a geometric figure and is associated with the conduct of military operations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CF")]
        [EnumMember]
        ControlFeatureType,
		
        /// <summary>
        /// A FEATURE-TYPE that describes terrain characteristics to which military significance is attached.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("GF")]
        [EnumMember]
        GeographicFeatureType,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A FEATURE-TYPE that describes reported or forecast weather and light conditions.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MF")]
        [EnumMember]
        MeteorologicFeatureType,
		
    }
}
