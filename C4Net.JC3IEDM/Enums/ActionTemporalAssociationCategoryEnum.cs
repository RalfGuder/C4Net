using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of chronological relationship of a subject ACTION to an object ACTION for a specific ACTION-TEMPORAL-ASSOCIATION.
    /// </summary>
    [DomId(100000120)]
    [DataContract]
    public enum ActionTemporalAssociationCategoryEnum
    {
		
        /// <summary>
        /// The two ACTIONs are concurrent.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SAEAST")]
        [EnumMember]
        StartsAtAndEndsAtTheSameTimeAs,
		
        /// <summary>
        /// The subject ACTION begins before the object ACTION and ends before the object ACTION ends.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SAENDO")]
        [EnumMember]
        StartsBeforeAndEndsBeforeEndOf,
		
        /// <summary>
        /// The subject ACTION begins concurrently with the object ACTION, but will extend beyond the object ACTION.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SASTEA")]
        [EnumMember]
        StartsAtTheSameTimeAndEndsAfter,
		
        /// <summary>
        /// The start of the object ACTION precedes that of the subject ACTION, but they will end concurrently.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SBEAST")]
        [EnumMember]
        StartsDuringAndEndsAtTheSameTimeAs,
		
        /// <summary>
        /// The subject ACTION is sequential but overlapping with the object ACTION.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("SDUREA")]
        [EnumMember]
        StartsDuringAndEndsAfter,
		
        /// <summary>
        /// The subject ACTION starts after the start of object ACTION and ends before the end of object ACTION.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SDUREB")]
        [EnumMember]
        StartsAndEndsDuring,
		
        /// <summary>
        /// The subject ACTION ends no later than the end of object ACTION augmented by a fixed duration.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("ENDENL")]
        [EnumMember]
        EndsNoLaterThanAfterEndOf,
		
        /// <summary>
        /// The subject ACTION ends after the object ACTION ends.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ENDEND")]
        [EnumMember]
        EndsAfterEndOf,
		
        /// <summary>
        /// The subject ACTION ends no earlier than the end of the object ACTION augmented by a fixed duration.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ENDENE")]
        [EnumMember]
        EndsNoEarlierThanAfterEndOf,
		
        /// <summary>
        /// The subject ACTION starts no later than the end of object ACTION augmented by a fixed duration.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("STRENL")]
        [EnumMember]
        StartsNoLaterThanAfterEndOf,
		
        /// <summary>
        /// The subject ACTION starts after the object ACTION ends.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("STREND")]
        [EnumMember]
        StartsAfterEndOf,
		
        /// <summary>
        /// The subject ACTION starts no earlier than the end of the object ACTION augmented by a fixed duration.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("STRENE")]
        [EnumMember]
        StartsNoEarlierThanAfterEndOf,
		
        /// <summary>
        /// The subject ACTION ends no later than the start of object ACTION augmented by a fixed duration.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("ENDSNL")]
        [EnumMember]
        EndsNoLaterThanAfterStartOf,
		
        /// <summary>
        /// The subject ACTION ends after the object ACTION starts.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("ENDSTR")]
        [EnumMember]
        EndsAfterStartOf,
		
        /// <summary>
        /// The subject ACTION ends no earlier than the start of the object ACTION augmented by a fixed duration.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("ENDSNE")]
        [EnumMember]
        EndsNoEarlierThanAfterStartOf,
		
        /// <summary>
        /// The subject ACTION starts no later than the start of object ACTION augmented by a fixed duration.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("STRSNL")]
        [EnumMember]
        StartsNoLaterThanAfterStartOf,
		
        /// <summary>
        /// The subject ACTION starts after the object ACTION starts.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("STRSTR")]
        [EnumMember]
        StartsAfterStartOf,
		
        /// <summary>
        /// The subject ACTION starts no earlier than the start of the object ACTION augmented by a fixed duration.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("STRSNE")]
        [EnumMember]
        StartsNoEarlierThanAfterStartOf,
		
    }
}
