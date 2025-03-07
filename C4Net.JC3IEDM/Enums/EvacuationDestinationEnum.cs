using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the disposition of casualties according to the destination of evacuation.
    /// </summary>
    [DomId(100000322)]
    [DataContract]
    public enum EvacuationDestinationEnum
    {
		
        /// <summary>
        /// Individual was returned to duty.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("RETDTY")]
        [EnumMember]
        ReturnedToDuty,
		
        /// <summary>
        /// Individual was evacuated to a medical facility in theatre.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MEDTHT")]
        [EnumMember]
        MedicalFacilityInTheatre,
		
        /// <summary>
        /// Individual was evacuated to home or holding country.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("HOMHOL")]
        [EnumMember]
        HomeOrHoldingCountry,
		
    }
}
