using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of FACILITY.
    /// </summary>
    [DomId(100000192)]
    [DataContract]
    public enum FacilityCategoryEnum
    {
		
        /// <summary>
        /// A FACILITY that is a structure (including overpass and viaduct), fixed or moveable, spanning and/or providing passage over an object.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BRIDGE")]
        [EnumMember]
        Bridge,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A FACILITY that is an area prepared for the accommodation (including any buildings, installations, or equipment) landing and take off of aircraft.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("AIRFLD")]
        [EnumMember]
        Airfield,
		
        /// <summary>
        /// A FACILITY that provides bearer services for communication and information services and is composed of one or more links and nodes.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NETWRK")]
        [EnumMember]
        Network,
		
        /// <summary>
        /// A FACILITY designed to stop, impede, or divert movement of amphibious or ground forces.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MILOBS")]
        [EnumMember]
        MilitaryObstacle,
		
        /// <summary>
        /// A FACILITY that is a restricted body of water, an anchorage, or other limited coastal water area and its water approaches from which and in which shipping operations are projected or supported.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("HARBOR")]
        [EnumMember]
        Harbour,
		
        /// <summary>
        /// A FACILITY that is a specifically prepared surface along which aircraft take off and land.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("RUNWAY")]
        [EnumMember]
        Runway,
		
        /// <summary>
        /// A FACILITY that is a place where vessels anchor.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ANCHOR")]
        [EnumMember]
        Anchorage,
		
        /// <summary>
        /// A FACILITY that is an open area of water, usually artificial and enclosed by dock gates lined with wharves, warehouses and berths to enable vessels to load and unload.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("BASIN")]
        [EnumMember]
        Basin,
		
        /// <summary>
        /// A FACILITY that is a space or length in the water at a harbour allocated to or reserved for a vessel to dock and moor for loading or unloading.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("BERTH")]
        [EnumMember]
        Berth,
		
        /// <summary>
        /// A FACILITY that provides an enclosure for maintenance, building or repairing ships, from which water can be pumped out.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("DRYDCK")]
        [EnumMember]
        DryDock,
		
        /// <summary>
        /// A FACILITY that is a platform that may be fixed or floating extending from a shore, normally attached to a wharf or the shore, and which allows access to a vessel lying alongside, used to secure, protect and provide landing and docking for vessels.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("JETTY")]
        [EnumMember]
        Jetty,
		
        /// <summary>
        /// A FACILITY that is a solidly constructed platform, usually parallel to the shoreline of navigable water, alongside which a vessel can be docked or berthed and, on which, the vessel can be accessed and cargo can be loaded or unloaded on one side of the vessel only.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("QUAY")]
        [EnumMember]
        Quay,
		
        /// <summary>
        /// A FACILITY that provides a sloping surface or inclined structure leading down to the water.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("SLPWAY")]
        [EnumMember]
        Slipway,
		
        /// <summary>
        /// A FACILITY that is a track or set of tracks made of steel rails along which trains run.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("RALWAY")]
        [EnumMember]
        Railway,
		
        /// <summary>
        /// A FACILITY that is a path or way with a specially prepared surface.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("ROAD")]
        [EnumMember]
        Road,
		
        /// <summary>
        /// A FACILITY that is an area intended for parking, loading, unloading and/or servicing.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("APRON")]
        [EnumMember]
        Apron,
		
    }
}
