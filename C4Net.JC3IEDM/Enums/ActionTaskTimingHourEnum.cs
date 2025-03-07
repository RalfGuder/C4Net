using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the notional start of the ACTION in terms of an hour with defined operational meaning.
    /// </summary>
    [DomId(100004333)]
    [DataContract]
    public enum ActionTaskTimingHourEnum
    {
		
        /// <summary>
        /// The time designated for the start of cross-FLOT aviation operations.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("F")]
        [EnumMember]
        F,
		
        /// <summary>
        /// The time on which an order (normally national) is given to deploy a unit.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("G")]
        [EnumMember]
        G,
		
        /// <summary>
        /// 1. The specific time at which an operation or exercise commences or is due to commence. It is also the time at which the Line of Departure is crossed by the leading element in an attack. 2. In amphibious operations, the time at which the first waterborne wave of an amphibious assault lands on a beach.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("H")]
        [EnumMember]
        H,
		
        /// <summary>
        /// The time on which a convoy system is introduced or is due to be introduced on any particular land convoy route or sea convoy lane.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("K")]
        [EnumMember]
        K,
		
        /// <summary>
        /// In amphibious or airmobile operations, the time at which the first helicopter of the heliborne assault wave touches down in the landing zone (LZ).
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("L")]
        [EnumMember]
        L,
		
        /// <summary>
        /// In airborne operations, the time at which the lead parachute element is to arrive over the parachute impact point to begin operations.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("P")]
        [EnumMember]
        P,
		
        /// <summary>
        /// The time of Transfer of Authority.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("T")]
        [EnumMember]
        T,
		
        /// <summary>
        /// In airmobile operations the time at which the first helicopter in the first wave departs the "Pick-up-Point"(PUP).
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("Y")]
        [EnumMember]
        Y,
		
    }
}
