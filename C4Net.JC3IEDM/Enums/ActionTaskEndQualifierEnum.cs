using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes the role of ending date and time with respect to the period of effectiveness of a specific ACTION-TASK.
    /// </summary>
    [DomId(100004137)]
    [DataContract]
    public enum ActionTaskEndQualifierEnum
    {
		
        /// <summary>
        /// Time intended is later than the time specified.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AFT")]
        [EnumMember]
        After,
		
        /// <summary>
        /// Time intended is the time specified.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AT")]
        [EnumMember]
        At,
		
        /// <summary>
        /// Time intended is in advance of the time specified.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BEF")]
        [EnumMember]
        Before,
		
        /// <summary>
        /// Time specified is the latest.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NLT")]
        [EnumMember]
        NoLaterThan,
		
        /// <summary>
        /// Time specified is the earliest.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOB")]
        [EnumMember]
        NotBefore,
		
        /// <summary>
        /// End the activity at the earliest possible time once execution is authorised.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ASAP")]
        [EnumMember]
        AsSoonAsPossible,
		
        /// <summary>
        /// End the activity at the earliest possible time after the specified end time.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ASAPAF")]
        [EnumMember]
        AsSoonAsPossibleAfter,
		
        /// <summary>
        /// End the activity at the earliest possible time but not later than the specified end time.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("ASAPNL")]
        [EnumMember]
        AsSoonAsPossibleNotLaterThan,
		
        /// <summary>
        /// Continue the activity unless it is specifically authorised to stop.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("UNTFRN")]
        [EnumMember]
        UntilFurtherNotice,
		
        /// <summary>
        /// Time intended to be determined later.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("TBD")]
        [EnumMember]
        ToBeDetermined,
		
        /// <summary>
        /// Time intended is not known.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("UNK")]
        [EnumMember]
        Unknown,
		
        /// <summary>
        /// Time is unlimited.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("INDEF")]
        [EnumMember]
        Indefinite,
		
    }
}
