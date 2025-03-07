using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of subsurface vessel.
    /// </summary>
    [DomId(100004285)]
    [DataContract]
    public enum SubsurfaceVesselTypeCategoryEnum
    {
		
        /// <summary>
        /// Submersible designed to operate at great depth (more than 300 metres).
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DSV")]
        [EnumMember]
        DeepSubmergenceVehicle,
		
        /// <summary>
        /// Military operated submersible designed to operate at great depth (more than 300 metres).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YSV")]
        [EnumMember]
        DeepSubmergenceVehicleMilitary,
		
        /// <summary>
        /// Military operated submersible designed for submarine rescue operations at great depth (more than 300 metres) and military operated.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("YSRV")]
        [EnumMember]
        DeepSubmersibleRescueVehicleMilitary,
		
        /// <summary>
        /// Submarine fitted with underwater to surface or surface-to-surface missiles.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SSG")]
        [EnumMember]
        SubmarineAttackGuidedMissile,
		
        /// <summary>
        /// Submarine fitted with underwater to surface or surface-to-surface missiles with nuclear power.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SSGN")]
        [EnumMember]
        SubmarineAttackGuidedMissileNuclear,
		
        /// <summary>
        /// Nuclear propelled attack submarine with both anti-submarine and anti-surface capability.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SSN")]
        [EnumMember]
        SubmarineAttackNuclear,
		
        /// <summary>
        /// Submarine used mainly in a non-combatant role which has at least a residual combat capability.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("SSA")]
        [EnumMember]
        SubmarineAuxiliary,
		
        /// <summary>
        /// Submarine used mainly in a non-combatant role that has at least a residual combat capability and with nuclear power.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SSAN")]
        [EnumMember]
        SubmarineAuxiliaryNuclearPowered,
		
        /// <summary>
        /// A subsurface vessel designed to deliver ballistic missile attacks against assigned targets from either a submerged or surfaced condition.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("SSB")]
        [EnumMember]
        SubmarineBallisticMissile,
		
        /// <summary>
        /// A subsurface vessel designed to deliver ballistic missile attacks against assigned targets from either a submerged or surfaced condition with nuclear power.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("SSBN")]
        [EnumMember]
        SubmarineBallisticMissileNuclear,
		
        /// <summary>
        /// Submarine designed primarily for operations in coastal and shallow waters.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("SSC")]
        [EnumMember]
        SubmarineCoastal,
		
        /// <summary>
        /// General designator for a warship, capable of operating under water and usually equipped with torpedoes, missiles and a periscope.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SS")]
        [EnumMember]
        SubmarineGeneral,
		
        /// <summary>
        /// Midget submarine or submersible designed primarily for special operations and operated by naval forces.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("SSW")]
        [EnumMember]
        SubmarineMidgetSwimmer,
		
        /// <summary>
        /// Submarine whose full military capability is unknown or has not been determined.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("SSU")]
        [EnumMember]
        SubmarineMilitaryCapabilityUnknown,
		
        /// <summary>
        /// Submarine with nuclear power whose full military capability is unknown or has not been determined.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("SSUN")]
        [EnumMember]
        SubmarineMilitaryCapabilityUnknownNuclearPowered,
		
        /// <summary>
        /// Long-range patrol submarine. May have primary anti- surface or anti-submarine role.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("SSK")]
        [EnumMember]
        SubmarinePatrol,
		
        /// <summary>
        /// Submarine used primarily in a training role but with at least a residual combat capability.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("SST")]
        [EnumMember]
        SubmarineTraining,
		
        /// <summary>
        /// General designator for non-combatant submersible.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("TS")]
        [EnumMember]
        SubmersibleGeneralCommercial,
		
        /// <summary>
        /// Submersible designed specifically for underwater rescue operations.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("TSR")]
        [EnumMember]
        SubmersibleRescueCommercial,
		
        /// <summary>
        /// Military operated submersible designed specifically for underwater rescue operations.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("YSG")]
        [EnumMember]
        SubmersibleRescueMilitary,
		
        /// <summary>
        /// Submersible with no combat capability used in research role.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("TSG")]
        [EnumMember]
        SubmersibleResearchCommercial,
		
        /// <summary>
        /// Military operated submersible with no combat capability used in research role.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("YSR")]
        [EnumMember]
        SubmersibleResearchMilitary,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
