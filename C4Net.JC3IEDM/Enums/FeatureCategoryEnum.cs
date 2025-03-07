using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of FEATURE.
    /// </summary>
    [DomId(100000134)]
    [DataContract]
    public enum FeatureCategoryEnum
    {
		
        /// <summary>
        /// A non-tangible FEATURE of military interest that is administratively specified, may be represented by a geometric figure, and is associated with the conduct of military operations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CF")]
        [EnumMember]
        ControlFeature,
		
        /// <summary>
        /// A FEATURE describing terrain characteristics to which military significance is attached.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("GF")]
        [EnumMember]
        GeographicFeature,
		
        /// <summary>
        /// A FEATURE that describes reported or forecast weather and light conditions.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MF")]
        [EnumMember]
        MeteorologicFeature,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
