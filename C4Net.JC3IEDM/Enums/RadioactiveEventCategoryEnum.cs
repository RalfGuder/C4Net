using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of RADIOACTIVE-EVENT.
    /// </summary>
    [DomId(100004271)]
    [DataContract]
    public enum RadioactiveEventCategoryEnum
    {
		
        /// <summary>
        /// A RADIOACTIVE-EVENT involving nuclear materiel and/or nuclear detonation.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NUCEVT")]
        [EnumMember]
        NuclearEvent,
		
        /// <summary>
        /// An action by which a radiological detector is triggered or a group is warned.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RADALM")]
        [EnumMember]
        RadiationAlarm,
		
        /// <summary>
        /// A RADIOACTIVE-EVENT involving radioactive materiel(s) but not involving nuclear materiel(s) and/or nuclear detonation.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RADEVT")]
        [EnumMember]
        RadiologicalEvent,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
