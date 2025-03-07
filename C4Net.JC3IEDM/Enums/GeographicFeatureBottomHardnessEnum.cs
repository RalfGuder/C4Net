using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// A specific value that represents the subjective indication obtained by a diver of the hardness of the liquid/solid surface interface and is the result of a single arm thrust.
    /// </summary>
    [DomId(100004338)]
    [DataContract]
    public enum GeographicFeatureBottomHardnessEnum
    {
		
        /// <summary>
        /// The depth to which the divers arm penetrates the surface bottom, using a clenched fist, up to the elbow.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ARMELB")]
        [EnumMember]
        ArmPenetratesToElbow,
		
        /// <summary>
        /// The depth to which the divers arm penetrates the surface bottom, using extended fingers, up to the knuckles.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ARMKNU")]
        [EnumMember]
        HandPenetratesToKnuckles,
		
        /// <summary>
        /// The depth to which the divers arm penetrates the surface bottom, using extended fingers, up to the palm.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ARMPLM")]
        [EnumMember]
        HandPenetratesToPalm,
		
        /// <summary>
        /// The depth to which the divers arm penetrates the surface bottom, using a clenched fist, up to the shoulder.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ARMSHO")]
        [EnumMember]
        ArmPenetratesToShoulder,
		
        /// <summary>
        /// The depth to which the divers arm penetrates the surface bottom, using a clenched fist, up to the wrist.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("ARMWRS")]
        [EnumMember]
        ArmPenetratesToWrist,
		
        /// <summary>
        /// The depth to which the divers arm penetrates the surface bottom, using a clenched fist, resulting in no penetration.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NOPENT")]
        [EnumMember]
        NoPenetration,
		
    }
}
