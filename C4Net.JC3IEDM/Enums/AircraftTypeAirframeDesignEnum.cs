using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the design of the airframe of an AIRCRAFT-TYPE.
    /// </summary>
    [DomId(100004365)]
    [DataContract]
    public enum AircraftTypeAirframeDesignEnum
    {
		
        /// <summary>
        /// An aircraft powered by a conventional propeller and a freewheeling, horizontal rotor.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AUTOGY")]
        [EnumMember]
        Autogyro,
		
        /// <summary>
        /// An unpowered lighter than air aircraft.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BALOON")]
        [EnumMember]
        Balloon,
		
        /// <summary>
        /// An aircraft capable of air operations using air to ground ordnance to destroy or neutralize enemy forces or installations.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BOMBER")]
        [EnumMember]
        Bomber,
		
        /// <summary>
        /// A powered lighter than air aircraft.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DIRIG")]
        [EnumMember]
        Dirigible,
		
        /// <summary>
        /// A generic term to describe a type of fast and manoeuvrable fixed wing aircraft capable of tactical air operations against air and/or surface targets.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("FIGHTR")]
        [EnumMember]
        Fighter,
		
        /// <summary>
        /// A fixed wing aircraft that flies without an engine.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("GLIDER")]
        [EnumMember]
        Glider,
		
        /// <summary>
        /// A rotary wing aircraft capable of atmospheric flight and dependent on rotating blades for lift.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("HELO")]
        [EnumMember]
        Helicopter,
		
        /// <summary>
        /// An aircraft designed primarily for the carriage of personnel and/or cargo, and/or fuel.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("CARGO")]
        [EnumMember]
        Transport,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A space vehicle that orbits the earth.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("SATEL")]
        [EnumMember]
        Satellite,
		
    }
}
