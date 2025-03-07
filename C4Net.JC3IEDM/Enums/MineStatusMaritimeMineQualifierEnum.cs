using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the qualification status of a specific maritime mine.
    /// </summary>
    [DomId(100004341)]
    [DataContract]
    public enum MineStatusMaritimeMineQualifierEnum
    {
		
        /// <summary>
        /// A maritime mine rendered inoperative by the shock of a nearby explosion of another or independent explosive charge, resulting in the main charge of the maritime mine exploding.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CNTMND")]
        [EnumMember]
        Countermined,
		
        /// <summary>
        /// Mine has been destroyed or rendered harmless and discarded.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DISPSD")]
        [EnumMember]
        Disposed,
		
        /// <summary>
        /// Mine partially destroyed on the right side by gunfire.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("EXPLRS")]
        [EnumMember]
        ExplodedRightSide,
		
        /// <summary>
        /// Mine partially destroyed on the left side by gunfire.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("EXPLLS")]
        [EnumMember]
        ExplodedLeftSide,
		
        /// <summary>
        /// Mine visible on the surface.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("FLOATN")]
        [EnumMember]
        Floating,
		
        /// <summary>
        /// Mine is entangled in some obstruction, unable to deploy as designed.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("FOULED")]
        [EnumMember]
        Fouled,
		
        /// <summary>
        /// Mine rendered, by external means, permanently incapable of firing on passage of a vehicle sweep, although it may remain dangerous to handle. The mine case may remain virtually intact.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("NEUTRL")]
        [EnumMember]
        Neutralized,
		
        /// <summary>
        /// The located mine remains in its detected position and no action has been taken against the mine.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("NOTDLT")]
        [EnumMember]
        NotDealtWith,
		
        /// <summary>
        /// Mine salvaged as nearly as intact as possible to permit further investigation for intelligence and/or evaluation purposes.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("RECVRD")]
        [EnumMember]
        Recovered,
		
        /// <summary>
        /// Mine removed out of an area where its detonation would be unacceptable.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("REMOVD")]
        [EnumMember]
        Removed,
		
        /// <summary>
        /// The interruption of the function or separation of essential components of unexploded ordnance to prevent an unacceptable detonation.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("RNDRSF")]
        [EnumMember]
        RenderedSafe,
		
        /// <summary>
        /// Buoyant mine holed, either deliberately or through malfunction, water filled and allowed to sink to the bottom surface.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SUNKEN")]
        [EnumMember]
        Sunken,
		
    }
}
