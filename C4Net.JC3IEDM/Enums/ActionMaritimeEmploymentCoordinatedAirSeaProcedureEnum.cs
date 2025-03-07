using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the coordinated air sea procedure (CASP) category for a friendly force, indicating the nature of the force relationship to the air commander.
    /// </summary>
    [DomId(100004334)]
    [DataContract]
    public enum ActionMaritimeEmploymentCoordinatedAirSeaProcedureEnum
    {
		
        /// <summary>
        /// An air-defence capable warship ORGANISATION is under tactical control of the Air Defence Commander.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CASP1")]
        [EnumMember]
        CoordinatedAirSeaProcedureOne,
		
        /// <summary>
        /// An air-defence capable warship ORGANISATION is working closely with the shore based Air Defence Commander. Tactical control of the ship remains with the Officer in Tactical Command.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CASP2")]
        [EnumMember]
        CoordinatedAirSeaProcedureTwo,
		
        /// <summary>
        /// A warship ORGANISATION that is unable to contribute to the Recognized Air Picture but requires receiving it normally via the Joint Anti-Air Warfare Shore Coordination net.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CASP3")]
        [EnumMember]
        CoordinatedAirSeaProcedureThree,
		
        /// <summary>
        /// An air-defence capable warship ORGANISATION, entering or berthed in a port or anchorage, which is able to assist the SOC/CAOC in whose sector the port or anchorage is located.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("CASP4")]
        [EnumMember]
        CoordinatedAirSeaProcedureFour,
		
    }
}
