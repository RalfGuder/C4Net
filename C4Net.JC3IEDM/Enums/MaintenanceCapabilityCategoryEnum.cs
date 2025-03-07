using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of MAINTENANCE-CAPABILITY.
    /// </summary>
    [DomId(100004348)]
    [DataContract]
    public enum MaintenanceCapabilityCategoryEnum
    {
		
        /// <summary>
        /// Equipment and resources for painting any part of a docked vessel.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PNTSHP")]
        [EnumMember]
        PaintShop,
		
        /// <summary>
        /// Equipment and resources for fitting and repairing pipes, fixtures and other apparatus of a water gas or sewage system belonging to a docked vessel.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PLUMBN")]
        [EnumMember]
        Plumbing,
		
        /// <summary>
        /// Equipment and resources for the construction, fitting and repairing the wooden parts of a docked vessel.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SHPWRG")]
        [EnumMember]
        Shipwright,
		
        /// <summary>
        /// Equipment and resources for the construction or manufacture of any article made of steel required for a docked vessel.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("STLFBR")]
        [EnumMember]
        SteelworkFabrication,
		
        /// <summary>
        /// Equipment and resources for the cleaning of metal, belonging to a docked vessel, by the impact of a stream of shot (lead pellets).
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SHTBLS")]
        [EnumMember]
        Shotblast,
		
        /// <summary>
        /// Equipment and resources for the removal of any trace of the original contents of any tank belonging to a docked vessel. Removal is often carried out by means of a high-pressure water jet.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("TNKCLN")]
        [EnumMember]
        TankCleaning,
		
        /// <summary>
        /// The specific MAINTENANCE-CAPABILITY determines the ability to provide cable repair.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("CABLE")]
        [EnumMember]
        Cable,
		
        /// <summary>
        /// The specific MAINTENANCE-CAPABILITY determines the ability to provide electrical repair.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("ELEC")]
        [EnumMember]
        Electrical,
		
        /// <summary>
        /// The specific MAINTENANCE-CAPABILITY determines the ability to provide navigational equipment repair.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NAVGTE")]
        [EnumMember]
        NavigationalEquipment,
		
        /// <summary>
        /// The specific MAINTENANCE-CAPABILITY determines the ability to provide steam repair.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("STEAM")]
        [EnumMember]
        Steam,
		
    }
}
