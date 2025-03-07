using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the qualification of the operational status of a specific MATERIEL.
    /// </summary>
    [DomId(100000256)]
    [DataContract]
    public enum MaterielStatusOperationalStatusQualifierEnum
    {
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a MATERIEL is unavailable through means such as removal, contamination or erection of obstructions.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DENIED")]
        [EnumMember]
        Denied,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a MATERIEL is not, and not expected ever to be, capable of performing the missions or functions for which it is designed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DSTRYD")]
        [EnumMember]
        Destroyed,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be heavily damaged.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("HVYDAM")]
        [EnumMember]
        HeavilyDamaged,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a MATERIEL is deficient or lacking of some mission-critical resources (e.g., fuel, ammunition).
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("LVR")]
        [EnumMember]
        LackingVitalResources,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be only lightly damaged.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LGTDAM")]
        [EnumMember]
        LightlyDamaged,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a specific materiel is missing under unknown circumstances.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("LST")]
        [EnumMember]
        Lost,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be moderately damaged.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MODDAM")]
        [EnumMember]
        ModeratelyDamaged,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a specific materiel has been preserved to some degree.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("MTHBLD")]
        [EnumMember]
        Mothballed,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a specific materiel is dismantled or taken apart into pieces to store or destroy.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("SCRPPD")]
        [EnumMember]
        Scrapped,
		
        /// <summary>
        /// The piece of materiel is weapon and explosive free.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("CLEARD")]
        [EnumMember]
        Cleared,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that the MATERIEL is taken apart in a way that it can be reassembled.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("DISASM")]
        [EnumMember]
        Disassembled,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a specific materiel or its component is incapable of movement in its current condition.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("IMMBLS")]
        [EnumMember]
        Immobilised,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a specific materiel is under some kind of service.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("INMNT")]
        [EnumMember]
        InMaintenance,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be in an area unsuitable for recovery due to political, military, or geographic/environmental considerations.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("INTREC")]
        [EnumMember]
        IntactButUnrecoverable,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that a specific materiel has been made incapable of functioning productively or effectively.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("STERLZ")]
        [EnumMember]
        Sterilized,
		
    }
}
