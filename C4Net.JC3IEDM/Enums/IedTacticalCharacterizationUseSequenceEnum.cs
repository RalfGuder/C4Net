using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that identifies enemy use of an IED as a primary, secondary, or tertiary form of attack, independent of intended outcome.
    /// </summary>
    [DomId(100004425)]
    [DataContract]
    public enum IedTacticalCharacterizationUseSequenceEnum
    {
		
        /// <summary>
        /// This is the initial IED employed in the target area.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("PRI")]
        [EnumMember]
        Primary,
		
        /// <summary>
        /// This is an additional device emplaced in the target area to attack individuals or vehicles after the initial event.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SEC")]
        [EnumMember]
        Secondary,
		
        /// <summary>
        /// This is an additional device emplaced in the target area to attack individuals or vehicles after the initial and secondary events.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("TER")]
        [EnumMember]
        Tertiary,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
