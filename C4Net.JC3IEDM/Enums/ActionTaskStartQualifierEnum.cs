using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that denotes the role of starting date and time with respect to the period of effectiveness of a specific ACTION-TASK.
    /// </summary>
    [DomId(100004136)]
    [DataContract]
    public enum ActionTaskStartQualifierEnum
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
        /// Begin the activity at the earliest possible time once execution is authorised.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ASAP")]
        [EnumMember]
        AsSoonAsPossible,
		
        /// <summary>
        /// Begin the activity at the earliest possible time after the specified start time.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("ASAPAF")]
        [EnumMember]
        AsSoonAsPossibleAfter,
		
        /// <summary>
        /// Begin the activity at the earliest possible time but not later than the specified start time.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("ASAPNL")]
        [EnumMember]
        AsSoonAsPossibleNotLaterThan,
		
        /// <summary>
        /// Time will be specified later by a dedicated call.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("ONCALL")]
        [EnumMember]
        OnCall,
		
        /// <summary>
        /// Time intended is to be determined later.
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
        /// Begin the activity on receipt of codeword.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ONCDWD")]
        [EnumMember]
        OnCodeword,
		
    }
}
