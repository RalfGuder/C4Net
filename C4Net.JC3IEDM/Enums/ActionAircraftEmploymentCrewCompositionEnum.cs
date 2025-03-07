using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the composition of the crew.
    /// </summary>
    [DomId(100004315)]
    [DataContract]
    public enum ActionAircraftEmploymentCrewCompositionEnum
    {
		
        /// <summary>
        /// A military crew with additional members for an extended crew day.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AUGMNT")]
        [EnumMember]
        Augmented,
		
        /// <summary>
        /// A normal sized military crew for the aircraft type.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BASIC")]
        [EnumMember]
        Basic,
		
        /// <summary>
        /// A crew that has been contracted from non-military sources.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("COMRCL")]
        [EnumMember]
        Commercial,
		
    }
}
