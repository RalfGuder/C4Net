using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that indicates whether an IED is attached to the underside of a vehicle.
    /// </summary>
    [DomId(100004426)]
    [DataContract]
    public enum IedTacticalCharacterizationVehiclePlacementEnum
    {
		
        /// <summary>
        /// An IED is placed elsewhere than on the underside of the vehicle.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("OTUVMG")]
        [EnumMember]
        No,
		
        /// <summary>
        /// An IED is placed on the underside of the vehicle.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("OTUVNM")]
        [EnumMember]
        Yes,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
