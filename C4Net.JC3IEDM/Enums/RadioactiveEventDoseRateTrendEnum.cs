using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the rate of change of the ionising radiation emitted by a radioactive materiel.
    /// </summary>
    [DomId(100000360)]
    [DataContract]
    public enum RadioactiveEventDoseRateTrendEnum
    {
		
        /// <summary>
        /// A decreasing radiation intensity of any radioactive material with respect to time.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DECR")]
        [EnumMember]
        Decreasing,
		
        /// <summary>
        /// An increasing radiation intensity of any radioactive material with respect to time.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("INCR")]
        [EnumMember]
        Increasing,
		
        /// <summary>
        /// The initial radiation intensity of any radioactive material at the moment of the nuclear event.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("INIT")]
        [EnumMember]
        Initial,
		
        /// <summary>
        /// A maximum radiation intensity of any radioactive material with respect to time.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PEAK")]
        [EnumMember]
        Peak,
		
        /// <summary>
        /// A constant radiation intensity of any radioactive material with respect to time.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SAME")]
        [EnumMember]
        Same,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A background radiation reading of any radioactive material with respect to time.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("BACK")]
        [EnumMember]
        Background,
		
    }
}
