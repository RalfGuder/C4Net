using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the notional start of the ACTION in terms of a day with defined operational meaning.
    /// </summary>
    [DomId(100004332)]
    [DataContract]
    public enum ActionTaskTimingDayEnum
    {
		
        /// <summary>
        /// The day on which deployment for an operation commences or is due to commence.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("C")]
        [EnumMember]
        C,
		
        /// <summary>
        /// The day on which an operation commences or is due to commence. This may be commencement of hostilities or any other operation.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("D")]
        [EnumMember]
        D,
		
        /// <summary>
        /// The day on which a NATO exercise commences.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("E")]
        [EnumMember]
        E,
		
        /// <summary>
        /// The day on which an order (normally national) is given to deploy a unit.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("G")]
        [EnumMember]
        G,
		
        /// <summary>
        /// French equivalent to D-day.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("J")]
        [EnumMember]
        J,
		
        /// <summary>
        /// The day on which a convoy system is introduced or is due to be introduced on any particular land convoy route or sea convoy lane.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("K")]
        [EnumMember]
        K,
		
        /// <summary>
        /// The day on which mobilization commences or is due to commence.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("M")]
        [EnumMember]
        M,
		
        /// <summary>
        /// The day of Transfer of Authority.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("T")]
        [EnumMember]
        T,
		
    }
}
