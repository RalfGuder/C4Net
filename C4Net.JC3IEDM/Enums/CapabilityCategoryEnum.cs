using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the general class of a CAPABILITY.
    /// </summary>
    [DomId(100000180)]
    [DataContract]
    public enum CapabilityCategoryEnum
    {
		
        /// <summary>
        /// A CAPABILITY, required for planning, of those ORGANISATIONs and PERSONs or ORGANISATION-TYPEs and PERSON-TYPEs that are deemed as having the ability to perform construction or destruction activities.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ENGI")]
        [EnumMember]
        EngineeringCapability,
		
        /// <summary>
        /// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs, or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs and PERSON-TYPEs that are deemed as having the ability to discharge or launch a projectile or missile.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("FIRE")]
        [EnumMember]
        FireCapability,
		
        /// <summary>
        /// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs, and PERSON-TYPEs that are deemed as having the ability to provide a range of activities required to restore or maintain operational usage.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MAIN")]
        [EnumMember]
        MaintenanceCapability,
		
        /// <summary>
        /// A CAPABILITY, required for planning, of those FACILITYs and MATERIELs or EQUIPMENT-TYPEs and FACILITY-TYPEs that are deemed as having the ability to hold a specific OBJECT-TYPE.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("STOR")]
        [EnumMember]
        StorageCapability,
		
        /// <summary>
        /// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs and PERSON-TYPEs that are deemed as having the nominal ability to observe aerospace, surface or subsurface areas, places, persons, or things, by visual, aural, electronic, photographic or other means.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("SURV")]
        [EnumMember]
        SurveillanceCapability,
		
        /// <summary>
        /// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs, ORGANISATIONs and PERSONs or FACILITY-TYPEs, EQUIPMENT-TYPEs, ORGANISATION-TYPEs, and PERSON-TYPEs that are deemed as having the nominal ability to move in space, air, on water, under water, or over a specific type of terrain.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MOBL")]
        [EnumMember]
        MobilityCapability,
		
        /// <summary>
        /// A CAPABILITY, required for planning, of those FACILITYs and MATERIELs, or FACILITY-TYPEs and EQUIPMENT-TYPEs that are deemed as having the ability to move materiels (raw materials, scrap, semi-finished, and finished) to, through, and from productive processes; in warehouses and storage; and in receiving and shipping areas.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("HNDLNG")]
        [EnumMember]
        HandlingCapability,
		
        /// <summary>
        /// A CAPABILITY, required for planning, of those FACILITYs, MATERIELs and ORGANISATIONs or FACILITY-TYPEs, EQUIPMENT-TYPEs and ORGANISATION-TYPEs that are deemed as having the ability to provide supplies or services.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("SUPPRT")]
        [EnumMember]
        SupportCapability,
		
        /// <summary>
        /// A CAPABILITY, required for planning, of those MATERIELs or MATERIEL-TYPEs that are deemed as having the ability to generate, receive or affect signals in the electromagnetic spectrum.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("TRANSM")]
        [EnumMember]
        TransmissionCapability,
		
        /// <summary>
        /// A CAPABILITY, required for planning, of those objects and types of objects that are deemed as having the ability, the training and the equipment to perform an operation.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("OPERAT")]
        [EnumMember]
        OperationalCapability,
		
    }
}
