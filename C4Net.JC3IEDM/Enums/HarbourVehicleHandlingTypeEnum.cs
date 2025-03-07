using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific types of facilities available at a specified HARBOUR.
    /// </summary>
    [DomId(100004174)]
    [DataContract]
    public enum HarbourVehicleHandlingTypeEnum
    {
		
        /// <summary>
        /// A permanent bridge, usually fixed to piles, specifically designed to enable a Roll on/Roll off (RORO) vessel to dock against, either stern-on or bow-on and which joins the vessel to the shore or dockside. This structure enables land vehicles to transit between the RORO vessel and the shore or dockside.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ROROFL")]
        [EnumMember]
        RollOnRollOffFixedLinkSpan,
		
        /// <summary>
        /// A permanent bridge, usually on a pontoon(s) or a ballast tank(s)/buoyancy tank(s), against which a Roll on/Roll off (RORO) vessel docks, either stern-on or bow-on, and which joins the RORO vessel to the shore or dockside. The structure enables land vehicles to transit between the RORO vessel and the shore or dockside. The link span rises or falls with the tide as it floats on the water.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ROROFR")]
        [EnumMember]
        RollOnRollOffFloatingRamp,
		
        /// <summary>
        /// A moveable bridge, usually on a pontoon(s) or a ballast tank(s)/buoyancy tank(s), against which a Roll on/Roll off (RORO) vessel docks, either stern-on or bow-on, and which joins the RORO vessel to the shore or dockside. The structure enables land vehicles to transit between the RORO vessel and the shore or dockside. The link span rises or falls with the tide and can be moved to another location, as it is floating on the water.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ROROML")]
        [EnumMember]
        RollOnRollOffMoveableLinkSpan,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
