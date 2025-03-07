using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the qualification of the operational status of a specific ORGANISATION.
    /// </summary>
    [DomId(100000261)]
    [DataContract]
    public enum OrganisationStatusOperationalStatusQualifierEnum
    {
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that an ORGANISATION is not, and not expected ever to be, capable of performing the missions or functions for which it is created.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DSTRYD")]
        [EnumMember]
        Destroyed,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be heavily damaged.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("HVYDAM")]
        [EnumMember]
        HeavilyDamaged,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that an ORGANISATION is deficient or lacking of some mission-critical resources (e.g., fuel, ammunition).
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LVR")]
        [EnumMember]
        LackingVitalResources,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be only lightly damaged.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("LGTDAM")]
        [EnumMember]
        LightlyDamaged,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a specific organisation is missing under unknown circumstances.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LST")]
        [EnumMember]
        Lost,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be moderately damaged.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MODDAM")]
        [EnumMember]
        ModeratelyDamaged,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
