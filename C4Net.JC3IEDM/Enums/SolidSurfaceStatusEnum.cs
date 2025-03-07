using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the status of a specific solid surface.
    /// </summary>
    [DomId(100000253)]
    [DataContract]
    public enum SolidSurfaceStatusEnum
    {
		
        /// <summary>
        /// A status indicating that terrain is passable or traversable.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CLEARD")]
        [EnumMember]
        Cleared,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be rendered useless or ineffective.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("DSTRYD")]
        [EnumMember]
        Destroyed,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be heavily damaged.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("HVYDAM")]
        [EnumMember]
        HeavilyDamaged,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be only lightly damaged.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("LGTDAM")]
        [EnumMember]
        LightlyDamaged,
		
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
		
        /// <summary>
        /// Subjectively judged by the reporting organisation to be defiled, sullied or infected by contact with toxic substances.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("CNTMND")]
        [EnumMember]
        Contaminated,
		
        /// <summary>
        /// Subjectively judged by the reporting organisation that the terrain is obstructed.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("OBSTRD")]
        [EnumMember]
        Obstructed,
		
    }
}
