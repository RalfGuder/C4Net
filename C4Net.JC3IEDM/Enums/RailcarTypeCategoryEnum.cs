using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of RAILCAR-TYPE.
    /// </summary>
    [DomId(100000346)]
    [DataContract]
    public enum RailcarTypeCategoryEnum
    {
		
        /// <summary>
        /// A detachable, wheeled engine used for pulling trains.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LCMTVE")]
        [EnumMember]
        Locomotive,
		
        /// <summary>
        /// Mobile equipment that uses rails to move on, for example, dockyard cranes.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("RLDEQP")]
        [EnumMember]
        RailedEquipment,
		
        /// <summary>
        /// Generic term for wagons, either passenger, freight or specialised that are used to form a train.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RLLSTK")]
        [EnumMember]
        RollingStock,
		
        /// <summary>
        /// A passenger carrying vehicle that runs on rails normally along roads, with minimal earthworks, typically powered by electricity from overhead power cables via a pantograph.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("TRAM")]
        [EnumMember]
        Tram,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A self-propelled passenger carrying vehicle that runs on rails.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("TRAIN")]
        [EnumMember]
        Train,
		
    }
}
