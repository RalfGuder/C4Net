using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of surface vessel.
    /// </summary>
    [DomId(100004284)]
    [DataContract]
    public enum SurfaceVesselTypeCategoryEnum
    {
		
        /// <summary>
        /// General designation for amphibious landing craft.
        /// </summary>
        [DomValIx(1000180)]
        [StringValue("LC")]
        [EnumMember]
        LandingCraft,
		
        /// <summary>
        /// High speed (40 knots - 74 km/hr) assault landing craft capable of travelling over land and water from over-the-horizon distances 12-200nm - 22-370 km using air cushion/gas turbine propulsion.
        /// </summary>
        [DomValIx(1000181)]
        [StringValue("LCAC")]
        [EnumMember]
        LandingCraftAirCushion,
		
        /// <summary>
        /// Landing craft optimised to provide fire support with guns or rockets during amphibious assaults. Probably does not carry troops.
        /// </summary>
        [DomValIx(1000182)]
        [StringValue("LCFS")]
        [EnumMember]
        LandingCraftFireSupport,
		
        /// <summary>
        /// Landing craft in size range 15-25 metres capable of carrying 1 tank or 50-200 troops. Must have landing ramp.
        /// </summary>
        [DomValIx(1000183)]
        [StringValue("LCM")]
        [EnumMember]
        LandingCraftMechanized,
		
        /// <summary>
        /// Landing craft in size range 15-25 metres capable of carrying 1 tank or 50-200 troops. Must have landing ramp. It is an air cushion or surface effect design.
        /// </summary>
        [DomValIx(1000184)]
        [StringValue("LCMJ")]
        [EnumMember]
        LandingCraftMediumAirCushion,
		
        /// <summary>
        /// Landing craft in size range 7.5-30 metres overall suitable only for carrying personnel. May be fast and/or ramped.
        /// </summary>
        [DomValIx(1000185)]
        [StringValue("LCP")]
        [EnumMember]
        LandingCraftPersonnel,
		
        /// <summary>
        /// Landing craft in size range 7.5-30 metres overall suitable only for carrying personnel. May be fast and/or ramped and armoured for protection.
        /// </summary>
        [DomValIx(1000186)]
        [StringValue("LCPA")]
        [EnumMember]
        LandingCraftPersonnelArmoured,
		
        /// <summary>
        /// 11 metre landing control boat used primarily to control amphibious seaborne assault waves.
        /// </summary>
        [DomValIx(1000187)]
        [StringValue("LCPL")]
        [EnumMember]
        LandingCraftPersonnelLarge,
		
        /// <summary>
        /// High-speed craft utilised primarily for underwater demolition and/or special warfare operations.
        /// </summary>
        [DomValIx(1000188)]
        [StringValue("LCW")]
        [EnumMember]
        LandingCraftSwimmerSupport,
		
        /// <summary>
        /// Landing craft in size range 15-25 metres capable of carrying 1 tank or 50-200 troops. Must have landing ramp and is optimised for carrying and landing tanks and vehicles.
        /// </summary>
        [DomValIx(1000189)]
        [StringValue("LCT")]
        [EnumMember]
        LandingCraftTank,
		
        /// <summary>
        /// All-purpose landing craft in size range 25-55 metres and full load of 120-500 tons with landing ramp/other landing facilities used for handling 2-3 tanks or 300-450 troops.
        /// </summary>
        [DomValIx(1000190)]
        [StringValue("LCU")]
        [EnumMember]
        LandingCraftUtility,
		
        /// <summary>
        /// All-purpose landing craft in size range 25-55 metres and full load of 120-500 tons with landing ramp/other landing facilities used for handling 2-3 tanks or 300-450 troops with an air cushion or surface effect design.
        /// </summary>
        [DomValIx(1000191)]
        [StringValue("LCUJ")]
        [EnumMember]
        LandingCraftUtilityAirCushion,
		
        /// <summary>
        /// Landing craft in size range 7.5-30 metres capable of carrying a light vehicle in place of troops. Must have bow ramp.
        /// </summary>
        [DomValIx(1000192)]
        [StringValue("LCVP")]
        [EnumMember]
        LandingCraftVehiclePersonnel,
		
        /// <summary>
        /// Primarily a tank and vehicle carrier but capable of transporting 150-400 assault troops and launch them embarked in organic landing craft without off-loading in the landing area. Need not have a helicopter platform.
        /// </summary>
        [DomValIx(1000193)]
        [StringValue("LSD")]
        [EnumMember]
        LandingShipDock,
		
        /// <summary>
        /// General designator for an amphibious landing ship.
        /// </summary>
        [DomValIx(1000194)]
        [StringValue("LS")]
        [EnumMember]
        LandingShipGeneral,
		
        /// <summary>
        /// Landing ship capable of carrying initial, second and follow-on echelon equipment, vehicles and troops. Normally ramped, not part of initial assault force.
        /// </summary>
        [DomValIx(1000195)]
        [StringValue("LSL")]
        [EnumMember]
        LandingShipLogistics,
		
        /// <summary>
        /// Ship in size range 45-85 metres, capable of beaching to land troops and/or tanks. Must have bow doors and/or landing ramp.
        /// </summary>
        [DomValIx(1000196)]
        [StringValue("LSM")]
        [EnumMember]
        LandingShipMedium,
		
        /// <summary>
        /// Ship in size range 85-100 metres employed to transport troops, vehicles and tanks for amphibious assault. Must have bow doors and/or landing ramp.
        /// </summary>
        [DomValIx(1000197)]
        [StringValue("LST")]
        [EnumMember]
        LandingShipTank,
		
        /// <summary>
        /// Ship in size range 45-60 metres overall, intended primarily to carry vehicles. Must have bow doors and/or landing ramp. Not capable of beaching.
        /// </summary>
        [DomValIx(1000198)]
        [StringValue("LSV")]
        [EnumMember]
        LandingShipVehicle,
		
        /// <summary>
        /// Small craft less than 20 metres employed in sheltered waters for transporting personnel.
        /// </summary>
        [DomValIx(1000199)]
        [StringValue("YFL")]
        [EnumMember]
        Launch,
		
        /// <summary>
        /// Small craft less than 20 metres employed in sheltered waters for transporting personnel but with covered areas.
        /// </summary>
        [DomValIx(1000200)]
        [StringValue("YFLN")]
        [EnumMember]
        LaunchCovered,
		
        /// <summary>
        /// Small craft over 20 metres employed in sheltered waters for transporting personnel.
        /// </summary>
        [DomValIx(1000201)]
        [StringValue("YFLB")]
        [EnumMember]
        LaunchCoveredLarge,
		
        /// <summary>
        /// Small craft less than 20 metres employed in sheltered waters for transporting personnel, but fitted with hydrofoils.
        /// </summary>
        [DomValIx(1000202)]
        [StringValue("YFLK")]
        [EnumMember]
        LaunchHydrofoil,
		
        /// <summary>
        /// Ship employed in monitoring satellite launching operations.
        /// </summary>
        [DomValIx(1000203)]
        [StringValue("AGSL")]
        [EnumMember]
        LaunchingShipSatellite,
		
        /// <summary>
        /// Ship actually moored or anchored in a fixed position showing navigational aiding light(s).
        /// </summary>
        [DomValIx(1000204)]
        [StringValue("ALS")]
        [EnumMember]
        LightShip,
		
        /// <summary>
        /// General designator for lighters.
        /// </summary>
        [DomValIx(1000205)]
        [StringValue("YL")]
        [EnumMember]
        Lighter,
		
        /// <summary>
        /// Barge-like vessel used in loading and unloading ships or in transporting loads for short distances, optimised for transporting aircraft.
        /// </summary>
        [DomValIx(1000206)]
        [StringValue("YCV")]
        [EnumMember]
        LighterAircraftTransport,
		
        /// <summary>
        /// Craft 40 metres or less used for transporting ammunition.
        /// </summary>
        [DomValIx(1000207)]
        [StringValue("YE")]
        [EnumMember]
        LighterAmmunition,
		
        /// <summary>
        /// A lighter designed to carry cargo for the re-supply of landing forces.
        /// </summary>
        [DomValIx(1000208)]
        [StringValue("LARC")]
        [EnumMember]
        LighterAmphibiousReSupplyCargo,
		
        /// <summary>
        /// A lighter designed to carry cargo and vehicles for the re-supply of landing forces.
        /// </summary>
        [DomValIx(1000209)]
        [StringValue("LARCV")]
        [EnumMember]
        LighterAmphibiousReSupplyVehicle,
		
        /// <summary>
        /// Craft used to support the operations of a dry dock other than workshops.
        /// </summary>
        [DomValIx(1000210)]
        [StringValue("YFC")]
        [EnumMember]
        LighterCoveredDryDockCompanion,
		
        /// <summary>
        /// Self-propelled transport craft under 40 metres.
        /// </summary>
        [DomValIx(1000211)]
        [StringValue("YF")]
        [EnumMember]
        LighterCoveredFerry,
		
        /// <summary>
        /// Refrigerated cargo transport craft 40 metres or less.
        /// </summary>
        [DomValIx(1000212)]
        [StringValue("YFR")]
        [EnumMember]
        LighterCoveredRefrigerated,
		
        /// <summary>
        /// Carrier capable of operating VSTOL and/or helicopters in sustained anti-submarine warfare (ASW) area operations and escort duties.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CVS")]
        [EnumMember]
        AircraftCarrierAsw,
		
        /// <summary>
        /// General designator for aircraft/multi-role aircraft carrier.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CV")]
        [EnumMember]
        AircraftCarrierGeneral,
		
        /// <summary>
        /// Designator for multi-role aircraft carriers, fitted with one or more force guided missile systems.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CVG")]
        [EnumMember]
        AircraftCarrierGuidedMissile,
		
        /// <summary>
        /// Designator for multi-role aircraft carriers, fitted with one or more force guided missile systems, nuclear powered.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("CVGN")]
        [EnumMember]
        AircraftCarrierGuidedMissileNuclearPower,
		
        /// <summary>
        /// Aircraft carrier without arrest gear/catapult operating VSTOL aircraft and/or helicopters that is not an amphibious or minewarfare ship.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CVH")]
        [EnumMember]
        AircraftCarrierHelicopterVstol,
		
        /// <summary>
        /// Aircraft carrier without arrest gear/catapult operating VSTOL aircraft and/or helicopters which is not an amphibious or minewarfare ship, fitted with one or more force guided missile systems.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CVHG")]
        [EnumMember]
        AircraftCarrierHelicopterVstolGuidedMissile,
		
        /// <summary>
        /// Aircraft carrier without arrest gear/catapult operating VSTOL aircraft and/or helicopters which is not an amphibious or minewarfare ship, fitted with one or more force guided missile systems and with nuclear power.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("CVHGN")]
        [EnumMember]
        AircraftCarrierHelicopterVstolGuidedMissileNuclearPowered,
		
        /// <summary>
        /// Aircraft carrier without arrest gear/catapult operating VSTOL aircraft and/or helicopters that is not an amphibious or minewarfare ship, having nuclear power.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("CVHN")]
        [EnumMember]
        AircraftCarrierHelicopterVstolNuclearPowered,
		
        /// <summary>
        /// Designator for multi-role aircraft carriers under a certain tonnage (tbd).
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("CVL")]
        [EnumMember]
        AircraftCarrierLight,
		
        /// <summary>
        /// Designator for multi-role aircraft carriers, fitted with one or more force guided missile systems under a certain tonnage (tbd).
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CVLG")]
        [EnumMember]
        AircraftCarrierLightGuidedMissile,
		
        /// <summary>
        /// Designator for multi-role aircraft carriers with nuclear power.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("CVN")]
        [EnumMember]
        AircraftCarrierNuclearPowered,
		
        /// <summary>
        /// Designator for multi-role aircraft carriers used primarily in a training role.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("CVT")]
        [EnumMember]
        AircraftCarrierTraining,
		
        /// <summary>
        /// Ship at least 80 metres employed to transport general cargo and provisions. No underway replenishment facilities, employed to transport aircraft and aircraft spares.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("AKV")]
        [EnumMember]
        AircraftFerryCargoShip,
		
        /// <summary>
        /// Any ship equipped to rescue personnel trapped in a sunken aircraft. May also have facilities to salvage sunken aircraft.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("AVR")]
        [EnumMember]
        AircraftRescueVessel,
		
        /// <summary>
        /// Craft 40 metres or less employed to transport sick/wounded and/or medical personnel.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("YH")]
        [EnumMember]
        AmbulanceBoat,
		
        /// <summary>
        /// Ship about 120 metres or more capable of transporting 5000 or more tons of ammunition and capable of providing underway replenishment of ammunition.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("AE")]
        [EnumMember]
        AmmunitionShip,
		
        /// <summary>
        /// Ship between 40-120 metres handling less than 5000 tons of ammunition and capable of providing underway replenishment of ammunition.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("AEL")]
        [EnumMember]
        AmmunitionShipSmall,
		
        /// <summary>
        /// Ship capable of transporting 5000 or more tons of ammunition but lacking sophisticated underway replenishment capabilities.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("AET")]
        [EnumMember]
        AmmunitionShipTransport,
		
        /// <summary>
        /// Ship capable of handling less than 5000 tons of ammunition but lacking sophisticated underway replenishment capabilities.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("AETL")]
        [EnumMember]
        AmmunitionShipTransportSmall,
		
        /// <summary>
        /// Amphibious ship designed for beaching operations.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("LLB")]
        [EnumMember]
        AmphibiousAssaultShipBeaching,
		
        /// <summary>
        /// A large general purpose ship which embarks and lands elements of an assault force in both organic helicopters and organic landing craft. Capable of carrying about 1800 assault troops. Must have internal stowage and ramp, and flooded well capability for vehicles or craft.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("LHA")]
        [EnumMember]
        AmphibiousAssaultShipGeneral,
		
        /// <summary>
        /// A large helicopter carrier with the mission of transporting and landing about 1800 assault troops with its organic aircraft. Employment of organic landing craft is not a principle function.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("LPH")]
        [EnumMember]
        AmphibiousAssaultShipHelicopter,
		
        /// <summary>
        /// A large multi-purpose amphibious ship that embarks and lands elements of a landing force by helicopter, landing craft and amphibious vehicles. Can also conduct sea control and power projection missions with VSTOL aircraft and ASW helicopters.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("LHD")]
        [EnumMember]
        AmphibiousAssaultShipMultiPurpose,
		
        /// <summary>
        /// Wheeled vehicle designed to carry assault troops in amphibious operations.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("AAV")]
        [EnumMember]
        AmphibiousAssaultVehicle,
		
        /// <summary>
        /// Ship which carries supplies for amphibious assaults and can land the same in its own organic landing craft.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("LKA")]
        [EnumMember]
        AmphibiousCargoShip,
		
        /// <summary>
        /// Landing ship converted for use in amphibious assaults. Armament is usually rocket launchers, but may also have bombardment guns. May or may not carry troops.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("LFS")]
        [EnumMember]
        AmphibiousFireSupportShip,
		
        /// <summary>
        /// Command ship for amphibious task force and landing operations. May carry a limited number of troops and supplies for the headquarters element of the landing force.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("LCC")]
        [EnumMember]
        AmphibiousForceFlagshipOrAmphibiousCommandShip,
		
        /// <summary>
        /// General designator for amphibious vessels.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("LL")]
        [EnumMember]
        AmphibiousShipGeneral,
		
        /// <summary>
        /// Ship that carries about 1000 troops. Capable of carrying up to 9 LCM (Landing craft, mechanized). Primarily a troop ship and armoured car carrier, with considerable internal berthing space. Must have permanent helicopter platform.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("LPD")]
        [EnumMember]
        AmphibiousTransportDock,
		
        /// <summary>
        /// A large ship capable of carrying 1300-1500 assault troops and capable of landing them in its own organic landing craft.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("LPP")]
        [EnumMember]
        AmphibiousTransportPersonnel,
		
        /// <summary>
        /// Armed vessel operated by customs. Size may vary.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("ZPG")]
        [EnumMember]
        ArmedCustomsGunboat,
		
        /// <summary>
        /// Armed vessel operated by police. Size may vary.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("VPG")]
        [EnumMember]
        ArmedPoliceGunboat,
		
        /// <summary>
        /// Assault landing craft equipped with guns.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("LG")]
        [EnumMember]
        AssaultCraftGunEquipped,
		
        /// <summary>
        /// Landing craft equipped with other than force guided missiles.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("LM")]
        [EnumMember]
        AssaultCraftMissileEquipped,
		
        /// <summary>
        /// Amphibious ship designed specifically to carry personnel.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("LLP")]
        [EnumMember]
        AssaultShipPersonnel,
		
        /// <summary>
        /// Assault ship optimised for carrying tanks.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("LLT")]
        [EnumMember]
        AssaultShipTank,
		
        /// <summary>
        /// High speed (35 knots - 65 km/hr) anti-surface ship patrol craft in size range 20 - 30 metres with torpedoes and with a force guided missile system.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("PTG")]
        [EnumMember]
        AttackBoatGuidedMissile,
		
        /// <summary>
        /// High speed (35 knots - 65 km/hr) anti-surface ship patrol craft in size range 20 - 30 metres fitted with torpedoes and with a force guided missile system and is of an air cushion or surface effect design.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("PTGJ")]
        [EnumMember]
        AttackBoatGuidedMissileAirCushion,
		
        /// <summary>
        /// High speed (35 knots - 65 km/hr) anti-surface ship patrol craft in size range 20 - 30 metres fitted with torpedoes and with force guided missile system and hydrofoils.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("PTGK")]
        [EnumMember]
        AttackBoatGuidedMissileHydrofoil,
		
        /// <summary>
        /// High speed (35 knots - 65 km/hr) anti-surface ship patrol craft in size range 20 - 30 metres fitted with torpedoes and with force guided missile system and used primarily in a training role.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("PTGT")]
        [EnumMember]
        AttackBoatGuidedMissileTraining,
		
        /// <summary>
        /// Training carrier for command and fleet carrier qualification requirements.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("AVT")]
        [EnumMember]
        AuxiliaryAircraftLandingTrainingShip,
		
        /// <summary>
        /// Ship 55 metres or more used to provide afloat communications facilities and accommodation for a force commander and his operations staff.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("AGF")]
        [EnumMember]
        AuxiliaryFlagOrCommandShip,
		
        /// <summary>
        /// Floating dock capable of docking ships of all sizes.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("AFDB")]
        [EnumMember]
        AuxiliaryFloatingDrydockLarge,
		
        /// <summary>
        /// Floating dock capable of docking medium and small ships.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("AFDM")]
        [EnumMember]
        AuxiliaryFloatingDrydockMedium,
		
        /// <summary>
        /// Floating dock capable of docking small ships.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("AFDL")]
        [EnumMember]
        AuxiliaryFloatingDrydockSmall,
		
        /// <summary>
        /// Dry dock with repair facilities for all ship sizes.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("ARD")]
        [EnumMember]
        AuxiliaryRepairDock,
		
        /// <summary>
        /// Vessel designed for local rescue operations inshore or offshore.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("AAR")]
        [EnumMember]
        AuxiliaryRescueCraft,
		
        /// <summary>
        /// General designator for all naval auxiliary ship types.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("AA")]
        [EnumMember]
        AuxiliaryShipGeneral,
		
        /// <summary>
        /// Ship 40 metres or more employed in general or multi-purpose functions of support, training, R&D, or a testing nature.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("AG")]
        [EnumMember]
        AuxiliaryMiscellaneous,
		
        /// <summary>
        /// Large ship equipped to provide aviation logistic support.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("AVB")]
        [EnumMember]
        AviationLogisticSupportShip,
		
        /// <summary>
        /// Ship equipped to carry and supply aviation stores.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("AVS")]
        [EnumMember]
        AviationSupplyShip,
		
        /// <summary>
        /// General designator for vessels that have repair and support facilities for aircraft.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("AV")]
        [EnumMember]
        AviationTender,
		
        /// <summary>
        /// Ship with supply and support facilities for airborne guided missiles.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("AVM")]
        [EnumMember]
        AviationTenderGuidedMissileSupport,
		
        /// <summary>
        /// Craft used to carry cables for laying.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("YRCN")]
        [EnumMember]
        BargeCable,
		
        /// <summary>
        /// Barge specifically designed for the disposal of nuclear waste.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("YOSR")]
        [EnumMember]
        BargeDisposalNuclearWaste,
		
        /// <summary>
        /// Craft of any design 60 metres or less used to store and transport POL products.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("YO")]
        [EnumMember]
        BargeFuelOil,
		
        /// <summary>
        /// Self-propelled craft used for the collection of garbage.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("YGG")]
        [EnumMember]
        BargeGarbage,
		
        /// <summary>
        /// Craft, probably self-propelled, used for collecting garbage from ships.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("YLG")]
        [EnumMember]
        BargeGarbage2,
		
        /// <summary>
        /// Craft 60 metres or less used to store and transport clean petroleum products.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("YOG")]
        [EnumMember]
        BargeGasoline,
		
        /// <summary>
        /// Craft of any size used to provide heat to moored ships or ship facilities.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("YHT")]
        [EnumMember]
        BargeHeating,
		
        /// <summary>
        /// A vessel that has no power of its own and must be towed.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("YB")]
        [EnumMember]
        BargeNonSelfPropelled,
		
        /// <summary>
        /// Craft used to transport radioactive materials.
        /// </summary>
        [DomValIx(1000062)]
        [StringValue("YRNS")]
        [EnumMember]
        BargeNuclearShipSupport,
		
        /// <summary>
        /// POL (petroleum oil and lubricant) storage barge that cannot be towed around the harbour.
        /// </summary>
        [DomValIx(1000063)]
        [StringValue("YOS")]
        [EnumMember]
        BargeOilStorage,
		
        /// <summary>
        /// POL (Petroleum oil and lubricants) storage barge that cannot be towed around the harbour but does sink below the water surface when filled.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("YOSS")]
        [EnumMember]
        BargeOilStorageSubmersible,
		
        /// <summary>
        /// Craft used to stow pontoons.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("YPK")]
        [EnumMember]
        BargePontoonStorage,
		
        /// <summary>
        /// Barge used to repair and/or service radioactive equipment.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("YRR")]
        [EnumMember]
        BargeRadiologicalRepair,
		
        /// <summary>
        /// Craft which both serves as a floating work ship and has berthing facilities for the assigned personnel. May/may not provide messing facilities as well.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("YRB")]
        [EnumMember]
        BargeRepairAndBerthing,
		
        /// <summary>
        /// Craft which both serves as a floating work ship and has berthing facilities for the assigned personnel. It provides messing facilities.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("YRBM")]
        [EnumMember]
        BargeRepairBerthingAndMessing,
		
        /// <summary>
        /// Any utility barge used for salvage.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("YRST")]
        [EnumMember]
        BargeSalvage,
		
        /// <summary>
        /// General designator for self-propelled barges.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("YS")]
        [EnumMember]
        BargeSelfPropelled,
		
        /// <summary>
        /// Craft 60 metres or less designed to transport fluids other than POL products or water in harbour areas.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("YOM")]
        [EnumMember]
        BargeSpecialLiquid,
		
        /// <summary>
        /// Barge used for various designated special purposes.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("YFNX")]
        [EnumMember]
        BargeSpecialPurposeNonSelfPropelled,
		
        /// <summary>
        /// Self-propelled craft used to simulate a target.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("YGTN")]
        [EnumMember]
        BargeTarget,
		
        /// <summary>
        /// Craft used to transport and store potable water.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("YW")]
        [EnumMember]
        BargeWater,
		
        /// <summary>
        /// Ship of at least 120 metres employed to transport troops, their supplies and equipment but also with capability of providing barrack facilities.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("APL")]
        [EnumMember]
        BarracksCraft,
		
        /// <summary>
        /// A self-propelled of any size employed as a mobile base facility and support ship for the crews of other vessels (usually small craft) and has no repair facilities.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("APB")]
        [EnumMember]
        BarracksShip,
		
        /// <summary>
        /// Capital surface ship designed for surface action with a reasonable compromise between speed, protection and armament that may include guided missiles. A very large, heavily armoured vessel.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("BB")]
        [EnumMember]
        BattleshipGeneral,
		
        /// <summary>
        /// Ship 40 metres or more employed for the placing and tending of buoys and aids to navigation in coastal and adjoining waters.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("ABU")]
        [EnumMember]
        BuoyTender,
		
        /// <summary>
        /// Ship 40 metres or more employed for the placing and tending of buoys and aids to navigation in coastal and adjoining waters with heavy lift capability.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("ABUD")]
        [EnumMember]
        BuoyTenderHeavyLift,
		
        /// <summary>
        /// Craft under 30 metres used to lay, retrieve and maintain submarine cables.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("YRC")]
        [EnumMember]
        CableTenderYardCraft,
		
        /// <summary>
        /// Ship equipped for cable or netlaying.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("AN")]
        [EnumMember]
        CableNetlayingShip,
		
        /// <summary>
        /// Smaller ship equipped for cable or netlaying.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("ANL")]
        [EnumMember]
        CableNetlayingShipSmall,
		
        /// <summary>
        /// Ship at least 80 metres employed to transport general cargo and provisions. No underway replenishment facilities.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("AK")]
        [EnumMember]
        CargoShipNaval,
		
        /// <summary>
        /// Ship at least 40 - 80 metres employed to transport general cargo and provisions. No underway replenishment facilities.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("AKL")]
        [EnumMember]
        CargoShipLightNaval,
		
        /// <summary>
        /// Ship at least 40 metres overall designed to transport vehicles, guns and tanks in a non-combatant situation. Must have roll-on/roll-off capability for vehicles.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("AKR")]
        [EnumMember]
        CargoShipRollOnRollOffNaval,
		
        /// <summary>
        /// Ship of at least 40 metres whose primary purpose is sustaining post operative casualties during transport out of theatre. Not declared by ICRC/red crescent (TU ships only). May be armed and carrying secure communications.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("APCT")]
        [EnumMember]
        CasualtyTransportShip,
		
        /// <summary>
        /// Sail or engine powered vessel with twin hulls.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("CAT")]
        [EnumMember]
        Catamaran,
		
        /// <summary>
        /// Small fishing vessel of specific design, usually powered by sail.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("CATBAT")]
        [EnumMember]
        Catboat,
		
        /// <summary>
        /// Large ship, usually over 165 metres capable of underway alongside replenishment of ships with refrigerated and dry provisions, technical spares, ammunition, and general stores. May carry POL but main emphasis is on mixed replenishment.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("AFS")]
        [EnumMember]
        CombatStoresShipNaval,
		
        /// <summary>
        /// Large ship over 230 metres, capable of speeds of 25 knots - 46.3 km/hr or more and/or providing rapid and simultaneous underway replenishment of ships at sea with POL, ammunition, refrigerated and dry provisions, spare parts and general stores. Primary emphasis is on POL replenishment.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("AOE")]
        [EnumMember]
        CombatSupportShipFastNaval,
		
        /// <summary>
        /// Craft 40 metres or less employed as a command ship but not designed for use at sea.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("YAGF")]
        [EnumMember]
        CommandCraftMiscellaneous,
		
        /// <summary>
        /// Small auxiliary optimised for communications duties.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("AGCL")]
        [EnumMember]
        CommunicationsShipSmall,
		
        /// <summary>
        /// A speedy, lightly armed warship smaller than a destroyer.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("FS")]
        [EnumMember]
        Corvette,
		
        /// <summary>
        /// General designator for frigate. A coast guard surface combatant in size range of about 75-150 metres, fitted primarily to fulfil an ASW role.
        /// </summary>
        [DomValIx(1000094)]
        [StringValue("WFFL")]
        [EnumMember]
        CorvetteCoastGuard,
		
        /// <summary>
        /// Craft used at sea for torpedo trials.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("YTT")]
        [EnumMember]
        CraftTorpedoTrials,
		
        /// <summary>
        /// General designator for all cruiser type ships of 140 metres or more. A fast warship of medium tonnage with a long cruising radius and les firepower and armour than a battleship.
        /// </summary>
        [DomValIx(1000096)]
        [StringValue("CC")]
        [EnumMember]
        CruiserGeneral,
		
        /// <summary>
        /// Cruiser with one or more force guided missile systems as its main armament.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("CG")]
        [EnumMember]
        CruiserGuidedMissile,
		
        /// <summary>
        /// Cruiser with one or more force guided missile systems as its main armament, fitted with a flight deck with a primary mission of operating and maintaining helicopters.
        /// </summary>
        [DomValIx(1000098)]
        [StringValue("CGH")]
        [EnumMember]
        CruiserGuidedMissileHelicopterCapable,
		
        /// <summary>
        /// Cruiser with one or more force guided missile systems as its main armament, fitted with a flight deck with a primary mission of operating and maintaining helicopters but with nuclear power.
        /// </summary>
        [DomValIx(1000099)]
        [StringValue("CGHN")]
        [EnumMember]
        CruiserGuidedMissileHelicopterCapableNuclearPowered,
		
        /// <summary>
        /// Cruiser with one or more force guided missile systems as its main armament and having nuclear power.
        /// </summary>
        [DomValIx(1000100)]
        [StringValue("CGN")]
        [EnumMember]
        CruiserGuidedMissileNuclearPowered,
		
        /// <summary>
        /// Cruiser with guns 15 cm (6 inch) or larger as its main armament and with no missile systems.
        /// </summary>
        [DomValIx(1000101)]
        [StringValue("CA")]
        [EnumMember]
        CruiserGun,
		
        /// <summary>
        /// General designator for all cruiser type ships of 140 metres or more, fitted with a flight deck with a primary mission of operating and maintaining helicopters.
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("CH")]
        [EnumMember]
        CruiserHelicopterCapable,
		
        /// <summary>
        /// Customs operated small craft less than 20 metres employed in sheltered waters for transporting personnel.
        /// </summary>
        [DomValIx(1000103)]
        [StringValue("ZYFL")]
        [EnumMember]
        CustomsLaunch,
		
        /// <summary>
        /// Sailing vessel of cutter design.
        /// </summary>
        [DomValIx(1000104)]
        [StringValue("CUTTER")]
        [EnumMember]
        Cutter,
		
        /// <summary>
        /// A ship with special facilities to support deep submergence diving operations.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("AGDS")]
        [EnumMember]
        DeepSubmergenceSupportShip,
		
        /// <summary>
        /// Vessel of any size used for degaussing purposes.
        /// </summary>
        [DomValIx(1000106)]
        [StringValue("YDG")]
        [EnumMember]
        DegaussingVessel,
		
        /// <summary>
        /// Ship designed for deperming operations.
        /// </summary>
        [DomValIx(1000107)]
        [StringValue("ADG")]
        [EnumMember]
        DepermingShip,
		
        /// <summary>
        /// Usually a large ship designed to provide support and depot facilities to other vessels of a specific type.
        /// </summary>
        [DomValIx(1000108)]
        [StringValue("AB")]
        [EnumMember]
        DepotShipTender,
		
        /// <summary>
        /// Ships of any size but usually large, employed primarily to furnish facilities and services for the support and repair of destroyer type ships.
        /// </summary>
        [DomValIx(1000109)]
        [StringValue("AD")]
        [EnumMember]
        DestroyerTender,
		
        /// <summary>
        /// A coast guard destroyer type ship. Major surface combatant in range of about 95 to 140 metres whole general mission is to conduct operations with strike, ASW and amphibious forces, and to perform screening and convoy duties. May have helicopters not especially fitted for ASW.
        /// </summary>
        [DomValIx(1000110)]
        [StringValue("WDD")]
        [EnumMember]
        DestroyerCoastGuard,
		
        /// <summary>
        /// A destroyer type ship optimised for escort duties. Major surface combatant in range of about 95 to 140 metres whole general mission is to conduct operations with strike, ASW and amphibious forces, and to perform screening and convoy duties. May have helicopters not especially fitted for ASW.
        /// </summary>
        [DomValIx(1000111)]
        [StringValue("DE")]
        [EnumMember]
        DestroyerEscort,
		
        /// <summary>
        /// General designator for destroyer type ships. Major surface combatant in range of about 95 to 140 metres whole general mission is to conduct operations with strike, ASW and amphibious forces, and to perform screening and convoy duties. May have helicopters not especially fitted for ASW.
        /// </summary>
        [DomValIx(1000112)]
        [StringValue("DD")]
        [EnumMember]
        DestroyerGeneral,
		
        /// <summary>
        /// A destroyer type ship fitted with one more force guided missile systems. Major surface combatant in range of about 95 to 140 metres whole general mission is to conduct operations with strike, ASW and amphibious forces, and to perform screening and convoy duties. May have helicopters not especially fitted for ASW.
        /// </summary>
        [DomValIx(1000113)]
        [StringValue("DDG")]
        [EnumMember]
        DestroyerGuidedMissile,
		
        /// <summary>
        /// A destroyer type ship fitted with a flight deck with a primary mission of operating and maintaining helicopters. Major surface combatant in range of about 95 to 140 metres whole general mission is to conduct operations with strike, ASW and amphibious forces, and to perform screening and convoy duties. May have helicopters not especially fitted for ASW.
        /// </summary>
        [DomValIx(1000114)]
        [StringValue("DDH")]
        [EnumMember]
        DestroyerHelicopterCapable,
		
        /// <summary>
        /// A destroyer type ship fitted with one more force guided missile systems and with a flight deck with a primary mission of operating and maintaining helicopters. Major surface combatant in range of about 95 to 140 metres whole general mission is to operations with strike, ASW and amphibious forces, and to perform screening and convoy duties. May have helicopters not especially fitted for ASW.
        /// </summary>
        [DomValIx(1000115)]
        [StringValue("DDGH")]
        [EnumMember]
        DestroyerHelicopterCapableGuidedMissile,
		
        /// <summary>
        /// A destroyer type ship used primarily in a training role. Major surface combatant in range of about 95 to 140 metres whole general mission is to conduct operations with strike, ASW and amphibious forces, and to perform screening and convoy duties. May have helicopters not especially fitted for ASW.
        /// </summary>
        [DomValIx(1000116)]
        [StringValue("DDT")]
        [EnumMember]
        DestroyerTraining,
		
        /// <summary>
        /// Sailing vessel, usually associated with middle eastern countries of specific design. May be powered by engine or sails, usually used for transportation purposes.
        /// </summary>
        [DomValIx(1000117)]
        [StringValue("DHOW")]
        [EnumMember]
        Dhow,
		
        /// <summary>
        /// Ship capable of distilling and transporting potable water.
        /// </summary>
        [DomValIx(1000118)]
        [StringValue("AWW")]
        [EnumMember]
        DistillingShipNaval,
		
        /// <summary>
        /// Craft usually 40 metres or less equipped to provide support for divers.
        /// </summary>
        [DomValIx(1000119)]
        [StringValue("YDT")]
        [EnumMember]
        DivingTender,
		
        /// <summary>
        /// Small craft optimised to act as tender for diving operations.
        /// </summary>
        [DomValIx(1000120)]
        [StringValue("YTD")]
        [EnumMember]
        DivingTender2,
		
        /// <summary>
        /// Craft employed as a dredge. It is not self-propelled.
        /// </summary>
        [DomValIx(1000121)]
        [StringValue("YMN")]
        [EnumMember]
        DredgerNonSelfPropelled,
		
        /// <summary>
        /// Craft equipped with catapult for the launching of drone aircraft and after launch capable of serving as the control craft for the drone.
        /// </summary>
        [DomValIx(1000122)]
        [StringValue("YV")]
        [EnumMember]
        DroneAircraftCatapultControlCraft,
		
        /// <summary>
        /// Craft used to support the operations of a dry dock.
        /// </summary>
        [DomValIx(1000123)]
        [StringValue("YFND")]
        [EnumMember]
        DryDockCompanionCraft,
		
        /// <summary>
        /// Non-self-propelled dry dock, closed bow and stern over 200 metres.
        /// </summary>
        [DomValIx(1000124)]
        [StringValue("YRDB")]
        [EnumMember]
        DryDockFloatingClosedLarge,
		
        /// <summary>
        /// Non-self-propelled dry dock, closed bow and stern between 60-200 metres.
        /// </summary>
        [DomValIx(1000125)]
        [StringValue("YRDM")]
        [EnumMember]
        DryDockFloatingClosedMedium,
		
        /// <summary>
        /// Non-self-propelled dry dock, closed bow and stern under 60 metres.
        /// </summary>
        [DomValIx(1000126)]
        [StringValue("YRDL")]
        [EnumMember]
        DryDockFloatingClosedSmall,
		
        /// <summary>
        /// Non-self-propelled open-ended dry dock 200 metres or more.
        /// </summary>
        [DomValIx(1000127)]
        [StringValue("YFDB")]
        [EnumMember]
        DryDockFloatingOpenLarge,
		
        /// <summary>
        /// Non-self-propelled open ended dry dock between 60-200 metres.
        /// </summary>
        [DomValIx(1000128)]
        [StringValue("YFDM")]
        [EnumMember]
        DryDockFloatingOpenMedium,
		
        /// <summary>
        /// Non-self-propelled open-ended dry dock less than 60 metres.
        /// </summary>
        [DomValIx(1000129)]
        [StringValue("YFDL")]
        [EnumMember]
        DryDockFloatingOpenSmall,
		
        /// <summary>
        /// Medium and small ship employed as a mobile repair facility providing limited support to various types of ships. Not a lifting ship. Repair primary function, support secondary.
        /// </summary>
        [DomValIx(1000130)]
        [StringValue("ARDM")]
        [EnumMember]
        DryDockAuxiliaryRepairMedium,
		
        /// <summary>
        /// Non-self- propelled dry dock with workshop facilities.
        /// </summary>
        [DomValIx(1000131)]
        [StringValue("YRD")]
        [EnumMember]
        DryDockFloatingWorkshop,
		
        /// <summary>
        /// Barge used for experimental weapon testing.
        /// </summary>
        [DomValIx(1000132)]
        [StringValue("YAGEN")]
        [EnumMember]
        ExperimentalWeaponTestingBarge,
		
        /// <summary>
        /// Boat or craft designed to provide ferry service in coastal and protected waters.
        /// </summary>
        [DomValIx(1000133)]
        [StringValue("YFB")]
        [EnumMember]
        FerryBoat,
		
        /// <summary>
        /// Harbour craft operated by customs fire service extensively equipped for firefighting. For this type that capability is more important than horsepower alone. Must have several fire monitors.
        /// </summary>
        [DomValIx(1000134)]
        [StringValue("ZYTR")]
        [EnumMember]
        FireServiceRescueTender,
		
        /// <summary>
        /// Coastal/harbour tug operated by customs fire service, between 30-40 metres with total horsepower of 1300 or more.
        /// </summary>
        [DomValIx(1000135)]
        [StringValue("ZYTB")]
        [EnumMember]
        FireTug,
		
        /// <summary>
        /// Harbour craft extensively equipped for firefighting. For this type that capability is more important than horsepower alone. Must have several fire monitors.
        /// </summary>
        [DomValIx(1000136)]
        [StringValue("YTR")]
        [EnumMember]
        FireRescueBoatSmall,
		
        /// <summary>
        /// Fisheries service operated vessel (fisheries patrol craft) in size range 35-55 metres designed and fitted primarily for escort duties in ASW role.
        /// </summary>
        [DomValIx(1000137)]
        [StringValue("ZPC")]
        [EnumMember]
        FisheriesPatrolCraft,
		
        /// <summary>
        /// Vessel equipped to conduct fisheries research.
        /// </summary>
        [DomValIx(1000138)]
        [StringValue("TUS")]
        [EnumMember]
        FisheriesResearchShip,
		
        /// <summary>
        /// Fishing vessel support ship (other than supplying fuel/water only).
        /// </summary>
        [DomValIx(1000139)]
        [StringValue("TUB")]
        [EnumMember]
        FishingVesselBaseShip,
		
        /// <summary>
        /// Fishing vessel equipped to prepare fish or other seafood into commercial products.
        /// </summary>
        [DomValIx(1000140)]
        [StringValue("TUF")]
        [EnumMember]
        FishingVesselFactoryShip,
		
        /// <summary>
        /// Fishing vessel over 30 metres.
        /// </summary>
        [DomValIx(1000141)]
        [StringValue("TU")]
        [EnumMember]
        FishingVesselGeneral,
		
        /// <summary>
        /// Any ship other than naval used for inspection of fishing vessels.
        /// </summary>
        [DomValIx(1000142)]
        [StringValue("TUI")]
        [EnumMember]
        FishingVesselInspection,
		
        /// <summary>
        /// Fishing vessel equipped with refrigerated holds.
        /// </summary>
        [DomValIx(1000143)]
        [StringValue("TUR")]
        [EnumMember]
        FishingVesselRefrigerated,
		
        /// <summary>
        /// Vessel used to train personnel in fisheries techniques.
        /// </summary>
        [DomValIx(1000144)]
        [StringValue("TUT")]
        [EnumMember]
        FishingVesselTraining,
		
        /// <summary>
        /// Fishing vessel equipped to engage in whale hunting.
        /// </summary>
        [DomValIx(1000145)]
        [StringValue("TUC")]
        [EnumMember]
        FishingVesselWhaleCatcher,
		
        /// <summary>
        /// Craft used as accommodation for vessels crews.
        /// </summary>
        [DomValIx(1000146)]
        [StringValue("YPB")]
        [EnumMember]
        FloatingBarracks,
		
        /// <summary>
        /// Barge-like vessels usually non-self-propelled equipped with a crane.
        /// </summary>
        [DomValIx(1000147)]
        [StringValue("YD")]
        [EnumMember]
        FloatingCrane,
		
        /// <summary>
        /// Craft employed as a dredge.
        /// </summary>
        [DomValIx(1000148)]
        [StringValue("YM")]
        [EnumMember]
        FloatingDredger,
		
        /// <summary>
        /// Non-self- propelled dry dock with workshop facilities optimised for hull repairs.
        /// </summary>
        [DomValIx(1000149)]
        [StringValue("YRDH")]
        [EnumMember]
        FloatingDryDockWorkshopHull,
		
        /// <summary>
        /// Craft used as a pile driver.
        /// </summary>
        [DomValIx(1000150)]
        [StringValue("YPD")]
        [EnumMember]
        FloatingPileDriver,
		
        /// <summary>
        /// Craft capable of providing auxiliary power.
        /// </summary>
        [DomValIx(1000151)]
        [StringValue("YFP")]
        [EnumMember]
        FloatingPowerBarge,
		
        /// <summary>
        /// Craft built to simulate a target.
        /// </summary>
        [DomValIx(1000152)]
        [StringValue("YGT")]
        [EnumMember]
        FloatingTarget,
		
        /// <summary>
        /// Craft about 30 metres fitted out as a general or special purpose mobile workshop.
        /// </summary>
        [DomValIx(1000153)]
        [StringValue("YR")]
        [EnumMember]
        FloatingWorkshopRepair,
		
        /// <summary>
        /// A coast guard frigate. A surface combatant in size range of about 75-150 metres. Fitted primarily to fulfil an ASW role. Generally has lighter surface armament than a Destroyer, general.
        /// </summary>
        [DomValIx(1000154)]
        [StringValue("WFF")]
        [EnumMember]
        FrigateCoastGuard,
		
        /// <summary>
        /// General designator for frigate. A surface combatant in size range of about 75-150 metres. Fitted primarily to fulfil an ASW role. Generally has lighter surface armament than a Destroyer, general.
        /// </summary>
        [DomValIx(1000155)]
        [StringValue("FF")]
        [EnumMember]
        FrigateGeneral,
		
        /// <summary>
        /// A frigate fitted with one or more force guided missile systems. A surface combatant in size range of about 75-150 metres. Fitted primarily to fulfil an ASW role.
        /// </summary>
        [DomValIx(1000156)]
        [StringValue("FFG")]
        [EnumMember]
        FrigateGuidedMissile,
		
        /// <summary>
        /// A frigate fitted with one or more force guided missile systems and a flight deck with a primary mission of operating and maintaining helicopters. A surface combatant in size range of about 75-150 metres. Fitted primarily to fulfil an ASW role.
        /// </summary>
        [DomValIx(1000157)]
        [StringValue("FFGH")]
        [EnumMember]
        FrigateGuidedMissileHelicopterCapable,
		
        /// <summary>
        /// A frigate fitted with a flight deck with a primary mission of operating and maintaining helicopters. A surface combatant in size range of about 75-150 metres. Fitted primarily to fulfil an ASW role.
        /// </summary>
        [DomValIx(1000158)]
        [StringValue("FFH")]
        [EnumMember]
        FrigateHelicopterCapable,
		
        /// <summary>
        /// General designator for frigate but smaller. A surface combatant in size range of about 75-150 metres. Fitted primarily to fulfil an ASW role. Generally has lighter surface armament than a Destroyer, general. Classification determined by armament or capability.
        /// </summary>
        [DomValIx(1000159)]
        [StringValue("FFL")]
        [EnumMember]
        FrigateSmallOrCorvette,
		
        /// <summary>
        /// General designator for frigate fitted with one or more force guided missile systems. A surface combatant in size range of about 75-150 metres. Fitted primarily to fulfil an ASW role. Generally has lighter surface armament than a Destroyer, general. Classification determined by armament or capability.
        /// </summary>
        [DomValIx(1000160)]
        [StringValue("FFLG")]
        [EnumMember]
        FrigateSmallOrCorvetteGuidedMissile,
		
        /// <summary>
        /// General designator for frigate used primarily in a training role. A surface combatant in size range of about 75-150 metres. Fitted primarily to fulfil an ASW role. Generally has lighter surface armament than a Destroyer, general. Classification determined by armament or capability.
        /// </summary>
        [DomValIx(1000161)]
        [StringValue("FFT")]
        [EnumMember]
        FrigateTraining,
		
        /// <summary>
        /// Craft used for control or maintenance of harbour defence equipment.
        /// </summary>
        [DomValIx(1000162)]
        [StringValue("YNG")]
        [EnumMember]
        GateCraft,
		
        /// <summary>
        /// Former landing craft, utility in size range 25-55 metres and full load of 120-500 tons with landing ramp/other landing facilities employed for general cargo transport purposes.
        /// </summary>
        [DomValIx(1000163)]
        [StringValue("YFU")]
        [EnumMember]
        HarbourUtilityCraft,
		
        /// <summary>
        /// Ship of at least 40 metres which provides 3rd line medical and surgical care. Declared to and protected by the ICRC (International Committee of the Red Cross/red crescent (TU ships only)) and marked accordingly.
        /// </summary>
        [DomValIx(1000164)]
        [StringValue("AH")]
        [EnumMember]
        HospitalShip,
		
        /// <summary>
        /// Vessel designed or converted to provide living accommodation.
        /// </summary>
        [DomValIx(1000165)]
        [StringValue("HUSBAT")]
        [EnumMember]
        Houseboat,
		
        /// <summary>
        /// Hovercraft specially fitted to assist in icebreaking.
        /// </summary>
        [DomValIx(1000166)]
        [StringValue("TJGB")]
        [EnumMember]
        HovercraftIceBreaker,
		
        /// <summary>
        /// Hovercraft fitted to carry passengers and/or vehicles.
        /// </summary>
        [DomValIx(1000167)]
        [StringValue("TJF")]
        [EnumMember]
        HovercraftFerry,
		
        /// <summary>
        /// A vehicle or craft that can be supported by a cushion of air ejected downwards against a surface close below it, and can in principle travel over any relatively smooth surface (as a body of water, marshland, gently sloping land) while having no significant contact with it.
        /// </summary>
        [DomValIx(1000168)]
        [StringValue("TJ")]
        [EnumMember]
        HovercraftGeneral,
		
        /// <summary>
        /// Non-military hovercraft specially equipped for research or survey duties.
        /// </summary>
        [DomValIx(1000169)]
        [StringValue("TJGS")]
        [EnumMember]
        HovercraftScientificResearchSurvey,
		
        /// <summary>
        /// Non-military hovercraft under ?? Metres.
        /// </summary>
        [DomValIx(1000170)]
        [StringValue("TJL")]
        [EnumMember]
        HovercraftSmall,
		
        /// <summary>
        /// Hovercraft capable of carrying vehicles and cargo. Not fitted to carry passengers.
        /// </summary>
        [DomValIx(1000171)]
        [StringValue("TJC")]
        [EnumMember]
        HovercraftTransportCargo,
		
        /// <summary>
        /// Any unused/historic ship.
        /// </summary>
        [DomValIx(1000172)]
        [StringValue("YXR")]
        [EnumMember]
        HulkOrRelic,
		
        /// <summary>
        /// Armed ship in size range 70 metres or more used primarily for icebreaking duties.
        /// </summary>
        [DomValIx(1000173)]
        [StringValue("AGB")]
        [EnumMember]
        IceBreaker,
		
        /// <summary>
        /// Armed ship in size range 70 metres or more used primarily for icebreaking duties. It has nuclear power.
        /// </summary>
        [DomValIx(1000174)]
        [StringValue("AGBN")]
        [EnumMember]
        IceBreakerNuclearPowered,
		
        /// <summary>
        /// Armed ship in size range under 70 metres used primarily for icebreaking duties.
        /// </summary>
        [DomValIx(1000175)]
        [StringValue("AGBL")]
        [EnumMember]
        IceBreakerSmall,
		
        /// <summary>
        /// Ship specially fitted with instrumentation for hydro acoustic range operations.
        /// </summary>
        [DomValIx(1000176)]
        [StringValue("AGH")]
        [EnumMember]
        InstrumentationShipHydroacousticRange,
		
        /// <summary>
        /// Ship specially fitted for and primarily employed in the collection of electronic intelligence.
        /// </summary>
        [DomValIx(1000177)]
        [StringValue("AGI")]
        [EnumMember]
        IntelligenceCollector,
		
        /// <summary>
        /// Sail/motor powered vessel, usually associated with China, of wooden construction designed with high bow and poop deck area. Usually used for transportation purposes.
        /// </summary>
        [DomValIx(1000178)]
        [StringValue("QJ")]
        [EnumMember]
        Junk,
		
        /// <summary>
        /// Vessel of specific design, usually powered by sail.
        /// </summary>
        [DomValIx(1000179)]
        [StringValue("KETCH")]
        [EnumMember]
        Ketch,
		
        /// <summary>
        /// Barge-like vessel used in loading and unloading ships or in transporting loads for short distances.
        /// </summary>
        [DomValIx(1000213)]
        [StringValue("YC")]
        [EnumMember]
        LighterOpen,
		
        /// <summary>
        /// Barge-like vessel used in loading and unloading ships or in transporting loads for short distances, but open and used for transporting cargo.
        /// </summary>
        [DomValIx(1000214)]
        [StringValue("YCK")]
        [EnumMember]
        LighterOpenCargo,
		
        /// <summary>
        /// Self-propelled craft 40 metres or less employed for transporting torpedoes.
        /// </summary>
        [DomValIx(1000215)]
        [StringValue("YFT")]
        [EnumMember]
        LighterTorpedoTransport,
		
        /// <summary>
        /// Non-naval ship designed to carry dry cargo in bulk form.
        /// </summary>
        [DomValIx(1000216)]
        [StringValue("TMB")]
        [EnumMember]
        MerchantShipBulkCarrier,
		
        /// <summary>
        /// Non-naval ship designed to lay and/or retrieve cables.
        /// </summary>
        [DomValIx(1000217)]
        [StringValue("TMK")]
        [EnumMember]
        MerchantShipCableLayer,
		
        /// <summary>
        /// Non-naval ship or craft designed to run a ferry service of both cars and passengers.
        /// </summary>
        [DomValIx(1000218)]
        [StringValue("TMF")]
        [EnumMember]
        MerchantShipCarPassengerFerry,
		
        /// <summary>
        /// Non-naval ship designed to carry cargo in loadable and unloadable containers. Not equipped to handle the containers with own equipment.
        /// </summary>
        [DomValIx(1000219)]
        [StringValue("TMC")]
        [EnumMember]
        MerchantShipContainerNonSelfSustained,
		
        /// <summary>
        /// Non-naval ship designed to carry cargo in loadable and unloadable containers and equipped with its own handling equipment.
        /// </summary>
        [DomValIx(1000220)]
        [StringValue("TMCS")]
        [EnumMember]
        MerchantShipContainerSelfSustained,
		
        /// <summary>
        /// Non-naval ship capable of distilling and transporting potable water.
        /// </summary>
        [DomValIx(1000221)]
        [StringValue("TMWW")]
        [EnumMember]
        MerchantShipDistilling,
		
        /// <summary>
        /// Non-naval dry cargo carrying ship capable of handling break bulk cargo.
        /// </summary>
        [DomValIx(1000222)]
        [StringValue("TMA")]
        [EnumMember]
        MerchantShipDryCargoBreakBulk,
		
        /// <summary>
        /// General designator for non-naval ship designed to transport cargo or passengers.
        /// </summary>
        [DomValIx(1000223)]
        [StringValue("TM")]
        [EnumMember]
        MerchantShipGeneral,
		
        /// <summary>
        /// Non-naval ship fitted with heavy duty crane or derrick for heavy lift.
        /// </summary>
        [DomValIx(1000224)]
        [StringValue("TMH")]
        [EnumMember]
        MerchantShipHeavyLift,
		
        /// <summary>
        /// Non-naval ship used primarily for icebreaking.
        /// </summary>
        [DomValIx(1000225)]
        [StringValue("TMGB")]
        [EnumMember]
        MerchantShipIcebreaker,
		
        /// <summary>
        /// Non-naval ship primarily used to transport cargo via inland waterways.
        /// </summary>
        [DomValIx(1000226)]
        [StringValue("TMI")]
        [EnumMember]
        MerchantShipInlandWaterway,
		
        /// <summary>
        /// Non-naval ship equipped with gantry crane, capable of embarking and disembarking pre-loaded standard sized barge (lash lighters).
        /// </summary>
        [DomValIx(1000227)]
        [StringValue("TML")]
        [EnumMember]
        MerchantShipLash,
		
        /// <summary>
        /// Non-naval ship designed to transport liquid gas.
        /// </summary>
        [DomValIx(1000228)]
        [StringValue("TMOT")]
        [EnumMember]
        MerchantShipLiquidGas,
		
        /// <summary>
        /// Non-naval ship designed primarily to monitor meteorological conditions.
        /// </summary>
        [DomValIx(1000229)]
        [StringValue("TMM")]
        [EnumMember]
        MerchantShipMeteorological,
		
        /// <summary>
        /// Non-naval ship designed primarily to transport passengers.
        /// </summary>
        [DomValIx(1000230)]
        [StringValue("TMP")]
        [EnumMember]
        MerchantShipPassenger,
		
        /// <summary>
        /// Non-naval ship or craft designed to ferry railroad cars.
        /// </summary>
        [DomValIx(1000231)]
        [StringValue("TMFR")]
        [EnumMember]
        MerchantShipRailroadCarFerry,
		
        /// <summary>
        /// Non-naval ship able to provide replenishment to ships at sea of POL and solid store products. Over 120 metres in size.
        /// </summary>
        [DomValIx(1000232)]
        [StringValue("TMOR")]
        [EnumMember]
        MerchantShipReplenishmentOiler,
		
        /// <summary>
        /// Non-naval ship able to provide replenishment to ships at sea of POL and solid store products. Less than 120 metres in size.
        /// </summary>
        [DomValIx(1000233)]
        [StringValue("TMOL")]
        [EnumMember]
        MerchantShipReplenishmentOilerSmall,
		
        /// <summary>
        /// Non-naval ship 40 metres or more, having capability for roll-on/roll-off cargo.
        /// </summary>
        [DomValIx(1000234)]
        [StringValue("TME")]
        [EnumMember]
        MerchantShipRollOnRollOffRoRo,
		
        /// <summary>
        /// Non-naval ship employed to conduct scientific research.
        /// </summary>
        [DomValIx(1000235)]
        [StringValue("TMGS")]
        [EnumMember]
        MerchantShipScientificResearchSurvey,
		
        /// <summary>
        /// Non-naval barge carrying ship with a stern elevator, capable of embarking and disembarking barges of non-standard size.
        /// </summary>
        [DomValIx(1000236)]
        [StringValue("TMLS")]
        [EnumMember]
        MerchantShipSeabee,
		
        /// <summary>
        /// Non-naval ship designed or converted primarily to support space and missile programmes.
        /// </summary>
        [DomValIx(1000237)]
        [StringValue("TMS")]
        [EnumMember]
        MerchantShipSpaceMissileAssociated,
		
        /// <summary>
        /// Non-naval ship 40 metres or more designed to transport a special kind of propellant or other non-nuclear associated liquid cargo.
        /// </summary>
        [DomValIx(1000238)]
        [StringValue("TMOS")]
        [EnumMember]
        MerchantShipSpecialLiquids,
		
        /// <summary>
        /// Non-naval ship designed to transport liquids (or gases).
        /// </summary>
        [DomValIx(1000239)]
        [StringValue("TMO")]
        [EnumMember]
        MerchantShipTanker,
		
        /// <summary>
        /// Non-naval ship used primarily for training purposes.
        /// </summary>
        [DomValIx(1000240)]
        [StringValue("TMX")]
        [EnumMember]
        MerchantShipTraining,
		
        /// <summary>
        /// Non-naval sea-going tug with horsepower of 1000 or more, length usually over 60 metres.
        /// </summary>
        [DomValIx(1000241)]
        [StringValue("TMT")]
        [EnumMember]
        MerchantShipTugOceanGoing,
		
        /// <summary>
        /// Non-naval sea-going tug with horsepower of 1000 or more, length usually over 60 metres and extensively equipped for fire fighting and rescue operations.
        /// </summary>
        [DomValIx(1000242)]
        [StringValue("TMTR")]
        [EnumMember]
        MerchantShipTugOceanGoingRescue,
		
        /// <summary>
        /// Non-naval sea-going tug that can provide towing, salvage, repair, diving and rescue services to ships and craft.
        /// </summary>
        [DomValIx(1000243)]
        [StringValue("TMTS")]
        [EnumMember]
        MerchantShipTugOceanGoingSalvage,
		
        /// <summary>
        /// Non-naval ship designed primarily for transporting potable water.
        /// </summary>
        [DomValIx(1000244)]
        [StringValue("TMWT")]
        [EnumMember]
        MerchantShipWaterTender,
		
        /// <summary>
        /// Non-naval ship designed to dredge channels in open seas.
        /// </summary>
        [DomValIx(1000245)]
        [StringValue("TMD")]
        [EnumMember]
        MerchantDredger,
		
        /// <summary>
        /// Non-naval ship designed primarily to transport cargo in refrigerated spaces.
        /// </summary>
        [DomValIx(1000246)]
        [StringValue("TMR")]
        [EnumMember]
        MerchantRefrigerated,
		
        /// <summary>
        /// An armed combatant fitted for the command and support of MCM vessels and their equipment.
        /// </summary>
        [DomValIx(1000247)]
        [StringValue("MCCS")]
        [EnumMember]
        MineCountermeasuresCommandAndSupport,
		
        /// <summary>
        /// A vessel used primarily in a mine countermeasures training role.
        /// </summary>
        [DomValIx(1000248)]
        [StringValue("MCT")]
        [EnumMember]
        MineCountermeasuresCraftTraining,
		
        /// <summary>
        /// An armed combatant fitted for the control and support of MCM vessels in combat situations. Has limited facilities for repair of Mine countermeasures vessels and their equipment.
        /// </summary>
        [DomValIx(1000249)]
        [StringValue("MCS")]
        [EnumMember]
        MineCountermeasuresSupportShip,
		
        /// <summary>
        /// A smaller armed combatant fitted for the control and diminished support of MCM vessels in combat situations. Has limited facilities for repair of Mine countermeasures vessels and their equipment.
        /// </summary>
        [DomValIx(1000250)]
        [StringValue("MCSL")]
        [EnumMember]
        MineCountermeasuresSupportShipSmall,
		
        /// <summary>
        /// A mine countermeasures vessel specially equipped to carry out and support diving operations.
        /// </summary>
        [DomValIx(1000251)]
        [StringValue("MCD")]
        [EnumMember]
        MineCountermeasuresVesselDiving,
		
        /// <summary>
        /// General designator for mine countermeasures vessels.
        /// </summary>
        [DomValIx(1000252)]
        [StringValue("MCMV")]
        [EnumMember]
        MineCountermeasuresVesselGeneral,
		
        /// <summary>
        /// A mine countermeasures vessel that is air cushion or surface effect design.
        /// </summary>
        [DomValIx(1000253)]
        [StringValue("MCJ")]
        [EnumMember]
        MineCountermeasuresVesselHovercraft,
		
        /// <summary>
        /// General designator for mine countermeasures vessel with no specification.
        /// </summary>
        [DomValIx(1000254)]
        [StringValue("MC")]
        [EnumMember]
        MineCountermeasuresVesselUnspecified,
		
        /// <summary>
        /// A ship of any size employed primarily to furnish facilities and services for the support, repair and limited command of mine countermeasures vessels.
        /// </summary>
        [DomValIx(1000255)]
        [StringValue("AGCM")]
        [EnumMember]
        MineCountermeasuresVesselsSupportShipTender,
		
        /// <summary>
        /// General designator for mine warfare vessels.
        /// </summary>
        [DomValIx(1000256)]
        [StringValue("MM")]
        [EnumMember]
        MineWarfareVesselGeneral,
		
        /// <summary>
        /// Any seagoing ship not designed as a mine hunter but converted to such use.
        /// </summary>
        [DomValIx(1000257)]
        [StringValue("MHA")]
        [EnumMember]
        MinehunterAuxiliary,
		
        /// <summary>
        /// Ship equipped with specific equipment to hunt mines and designed to operate in coastal waters.
        /// </summary>
        [DomValIx(1000258)]
        [StringValue("MHC")]
        [EnumMember]
        MinehunterCoastal,
		
        /// <summary>
        /// Ship equipped with specific equipment to hunt mines by the use of a drone.
        /// </summary>
        [DomValIx(1000259)]
        [StringValue("MHCD")]
        [EnumMember]
        MinehunterCoastalWithDrone,
		
        /// <summary>
        /// Ship equipped with specific equipment to hunt mines.
        /// </summary>
        [DomValIx(1000260)]
        [StringValue("MH")]
        [EnumMember]
        MinehunterGeneral,
		
        /// <summary>
        /// Ship equipped with specific equipment to hunt mines and designed for operating in more shallow waters or estuaries.
        /// </summary>
        [DomValIx(1000261)]
        [StringValue("MHI")]
        [EnumMember]
        MinehunterInshore,
		
        /// <summary>
        /// Ship equipped with specific equipment to hunt mines and designed for operating in ocean waters.
        /// </summary>
        [DomValIx(1000262)]
        [StringValue("MHO")]
        [EnumMember]
        MinehunterOcean,
		
        /// <summary>
        /// A mine warfare craft equipped for both hunting and sweeping mines by the use of a drone.
        /// </summary>
        [DomValIx(1000263)]
        [StringValue("MHSD")]
        [EnumMember]
        MinehunterSweeperWDrone,
		
        /// <summary>
        /// A mine warfare craft equipped for both hunting and sweeping mines, limited to coastal waters.
        /// </summary>
        [DomValIx(1000264)]
        [StringValue("MHSC")]
        [EnumMember]
        MinehunterSweeperCoastal,
		
        /// <summary>
        /// A mine warfare craft equipped for both hunting and sweeping mines.
        /// </summary>
        [DomValIx(1000265)]
        [StringValue("MHS")]
        [EnumMember]
        MinehunterSweeperGeneral,
		
        /// <summary>
        /// A mine warfare craft equipped for both hunting and sweeping mines and capable of operating in open ocean waters.
        /// </summary>
        [DomValIx(1000266)]
        [StringValue("MHSO")]
        [EnumMember]
        MinehunterSweeperOcean,
		
        /// <summary>
        /// Any fishing or merchant ship having both capability and mission to lay mines.
        /// </summary>
        [DomValIx(1000267)]
        [StringValue("MLA")]
        [EnumMember]
        MinelayerAuxiliary,
		
        /// <summary>
        /// Minelayer in size range 50 - 85 metres overall.
        /// </summary>
        [DomValIx(1000268)]
        [StringValue("MLC")]
        [EnumMember]
        MinelayerCoastal,
		
        /// <summary>
        /// A ship with a primary mission of laying mines.
        /// </summary>
        [DomValIx(1000269)]
        [StringValue("ML")]
        [EnumMember]
        MinelayerGeneral,
		
        /// <summary>
        /// Minelayer in size range 25 - 50 metres overall.
        /// </summary>
        [DomValIx(1000270)]
        [StringValue("MLI")]
        [EnumMember]
        MinelayerInshore,
		
        /// <summary>
        /// Large ship over 85 metres used primarily for minelaying.
        /// </summary>
        [DomValIx(1000271)]
        [StringValue("MLO")]
        [EnumMember]
        MinelayerOcean,
		
        /// <summary>
        /// Small minelayer 15 metres or less suitable only for operations on rivers or in protected roadsteads.
        /// </summary>
        [DomValIx(1000272)]
        [StringValue("MLR")]
        [EnumMember]
        MinelayerRiver,
		
        /// <summary>
        /// A large armed ship (over 90 metres) capable of extensive minelaying, but not capable of speeds over 30 knots - 55 km/hr, with the facilities for command and control of mine warfare ships and boats in combat environment. Has limited support capability.
        /// </summary>
        [DomValIx(1000273)]
        [StringValue("MLS")]
        [EnumMember]
        MinelayerSupportShip,
		
        /// <summary>
        /// Any seagoing ship not designed as a minesweeper but converted to such use.
        /// </summary>
        [DomValIx(1000274)]
        [StringValue("MSA")]
        [EnumMember]
        MinesweeperAuxiliary,
		
        /// <summary>
        /// Minesweeper less than 12.5 metres.
        /// </summary>
        [DomValIx(1000275)]
        [StringValue("MSB")]
        [EnumMember]
        MinesweeperBoat,
		
        /// <summary>
        /// Non-magnetic minesweeper between 40-70 metres.
        /// </summary>
        [DomValIx(1000276)]
        [StringValue("MSC")]
        [EnumMember]
        MinesweeperCoastal,
		
        /// <summary>
        /// Coastal minesweeper capable of deploying and/or controlling unmanned remote controlled or towed vehicle(s) used for clearing mines.
        /// </summary>
        [DomValIx(1000277)]
        [StringValue("MSCD")]
        [EnumMember]
        MinesweeperCoastalWDroneS,
		
        /// <summary>
        /// Non-magnetic minesweeper between 40-70 metres with an air cushion or surface effect design.
        /// </summary>
        [DomValIx(1000278)]
        [StringValue("MSCJ")]
        [EnumMember]
        MinesweeperCoastalAirCushion,
		
        /// <summary>
        /// Non-magnetic minesweeper between 40-70 metres, fitted with hydrofoils.
        /// </summary>
        [DomValIx(1000279)]
        [StringValue("MSCK")]
        [EnumMember]
        MinesweeperCoastalHydrofoil,
		
        /// <summary>
        /// A minesweeper fitted with special to type mine-sweeping devices, for use within coastal waters.
        /// </summary>
        [DomValIx(1000280)]
        [StringValue("MSCS")]
        [EnumMember]
        MinesweeperCoastalSpecial,
		
        /// <summary>
        /// Non-magnetic minesweeper between 40-70 metres, used primarily in a training role.
        /// </summary>
        [DomValIx(1000281)]
        [StringValue("MSCT")]
        [EnumMember]
        MinesweeperCoastalTraining,
		
        /// <summary>
        /// Unmanned remotely controlled or towed vehicle capable of clearing mines.
        /// </summary>
        [DomValIx(1000282)]
        [StringValue("MSD")]
        [EnumMember]
        MinesweeperDrone,
		
        /// <summary>
        /// Minesweeper in size range 46 metres or more that cannot be regarded as being non-magnetic.
        /// </summary>
        [DomValIx(1000283)]
        [StringValue("MSF")]
        [EnumMember]
        MinesweeperFleet,
		
        /// <summary>
        /// Minesweeper in size range 46 metres or more that cannot be regarded as being non-magnetic, with an air cushion or surface effect design.
        /// </summary>
        [DomValIx(1000284)]
        [StringValue("MSFJ")]
        [EnumMember]
        MinesweeperFleetAirCushion,
		
        /// <summary>
        /// Minesweeper in size range 46 metres or more which cannot be regarded as being non-magnetic, fitted with hydrofoils.
        /// </summary>
        [DomValIx(1000285)]
        [StringValue("MSFK")]
        [EnumMember]
        MinesweeperFleetHydrofoil,
		
        /// <summary>
        /// Ship designed to sweep mines.
        /// </summary>
        [DomValIx(1000286)]
        [StringValue("MS")]
        [EnumMember]
        MinesweeperGeneral,
		
        /// <summary>
        /// Minesweeper between 20-40 metres. Intended and equipped for inshore minesweeping.
        /// </summary>
        [DomValIx(1000287)]
        [StringValue("MSI")]
        [EnumMember]
        MinesweeperInshore,
		
        /// <summary>
        /// Minesweeper between 20-40 metres. Intended and equipped for inshore minesweeping with an air cushion or surface effect design.
        /// </summary>
        [DomValIx(1000288)]
        [StringValue("MSIJ")]
        [EnumMember]
        MinesweeperInshoreAirCushion,
		
        /// <summary>
        /// A small vessel designed to sweep mines.
        /// </summary>
        [DomValIx(1000289)]
        [StringValue("MSL")]
        [EnumMember]
        MinesweeperLight,
		
        /// <summary>
        /// Non-magnetic minesweeper 46 metres or more designed for open ocean operations.
        /// </summary>
        [DomValIx(1000290)]
        [StringValue("MSO")]
        [EnumMember]
        MinesweeperOcean,
		
        /// <summary>
        /// Shallow water minesweeper in size range 12.5 - 25 metres which has been armoured to provide protection for crew in close combat situations. In the USN a converted lCM-6 known as MSM.
        /// </summary>
        [DomValIx(1000291)]
        [StringValue("MSR")]
        [EnumMember]
        MinesweeperRiver,
		
        /// <summary>
        /// A minesweeper fitted with special to type minesweeping devices.
        /// </summary>
        [DomValIx(1000292)]
        [StringValue("MSS")]
        [EnumMember]
        MinesweeperSpecialDevice,
		
        /// <summary>
        /// Ship employed at sea to provide telemetry and recover missiles.
        /// </summary>
        [DomValIx(1000293)]
        [StringValue("AGM")]
        [EnumMember]
        MissileRangeInstrumentationShip,
		
        /// <summary>
        /// Ship larger than 40 metres employed primarily to transport missiles.
        /// </summary>
        [DomValIx(1000294)]
        [StringValue("AEM")]
        [EnumMember]
        MissileSupportShip,
		
        /// <summary>
        /// Vessel, usually associated with luxury living accommodation, powered by inboard engines.
        /// </summary>
        [DomValIx(1000295)]
        [StringValue("MYAC")]
        [EnumMember]
        MotorYacht,
		
        /// <summary>
        /// Craft 40 metres or less used to store and transport harbour defence craft.
        /// </summary>
        [DomValIx(1000296)]
        [StringValue("YNC")]
        [EnumMember]
        NetCargoCraft,
		
        /// <summary>
        /// Craft 40 metres or less used to maintain nets, booms and other harbour defence equipment. May/may not be able to lay and recover same.
        /// </summary>
        [DomValIx(1000297)]
        [StringValue("YNT")]
        [EnumMember]
        NetTenderBoom,
		
        /// <summary>
        /// Ship which conducts multi-discipline research at sea in oceanographic radiomagnetics, meteorology and oceanography.
        /// </summary>
        [DomValIx(1000298)]
        [StringValue("AGOR")]
        [EnumMember]
        OceanographicResearchShip,
		
        /// <summary>
        /// Ship which conducts multi-discipline research at sea in oceanographic radiomagnetics, meteorology and oceanography, specially fitted for ice operations. Must have icebreaker bow.
        /// </summary>
        [DomValIx(1000299)]
        [StringValue("AGOB")]
        [EnumMember]
        OceanographicResearchShipPolar,
		
        /// <summary>
        /// A vessel specifically designed for pollution control/oil recovery operations.
        /// </summary>
        [DomValIx(1000300)]
        [StringValue("YOR")]
        [EnumMember]
        OilRecoveryVessel,
		
        /// <summary>
        /// Ship of at least 140 metres capable of providing rapid replenishment of POL and solid store products.
        /// </summary>
        [DomValIx(1000301)]
        [StringValue("AOR")]
        [EnumMember]
        OilerReplenishmentNaval,
		
        /// <summary>
        /// Ship between 40-140 metres capable of providing rapid replenishment of POL and solid store products.
        /// </summary>
        [DomValIx(1000302)]
        [StringValue("AORL")]
        [EnumMember]
        OilerReplenishmentSmallNaval,
		
        /// <summary>
        /// Ship usually exceeding 120 metres capable of transporting POL products but not specially fitted to provide underway replenishment.
        /// </summary>
        [DomValIx(1000303)]
        [StringValue("AOT")]
        [EnumMember]
        OilerTransportNaval,
		
        /// <summary>
        /// Ship between 40-120 metres capable of transporting POL products but not specially fitted to provide underway replenishment.
        /// </summary>
        [DomValIx(1000304)]
        [StringValue("AOTL")]
        [EnumMember]
        OilerTransportSmallNaval,
		
        /// <summary>
        /// Ship in size range 60-100 metres capable of furnishing underway replenishment of POL products.
        /// </summary>
        [DomValIx(1000305)]
        [StringValue("AOL")]
        [EnumMember]
        OilerSmallNaval,
		
        /// <summary>
        /// General designator for oilers.
        /// </summary>
        [DomValIx(1000306)]
        [StringValue("AO")]
        [EnumMember]
        OilerTankerGeneral,
		
        /// <summary>
        /// Customs operated coastal patrol unit intended for a basically coastal guarding function. Includes any coastal patrol ship under 45 metres which cannot qualify as a PG in armament. May be unarmed.
        /// </summary>
        [DomValIx(1000307)]
        [StringValue("ZPB")]
        [EnumMember]
        PatrolBoatCustoms,
		
        /// <summary>
        /// Coastal patrol unit intended for a basically coastal guarding function. Includes any coastal patrol ship under 45 metres which cannot qualify as a PG in armament. May be unarmed and capable of at least 35 knots - 65 km/hr.
        /// </summary>
        [DomValIx(1000308)]
        [StringValue("PBF")]
        [EnumMember]
        PatrolBoatFast,
		
        /// <summary>
        /// Coastal patrol unit intended for a basically coastal guarding function. Includes any coastal patrol ship under 45 metres which cannot qualify as a PG in armament. May be unarmed.
        /// </summary>
        [DomValIx(1000309)]
        [StringValue("PB")]
        [EnumMember]
        PatrolBoatGeneral,
		
        /// <summary>
        /// Coastal patrol unit intended for a basically coastal guarding function. Includes any coastal patrol ship under 45 metres that cannot qualify as a Patrol ship, gun equipped, general in armament. May be unarmed and fitted with hydrofoils.
        /// </summary>
        [DomValIx(1000310)]
        [StringValue("PBK")]
        [EnumMember]
        PatrolBoatHydrofoil,
		
        /// <summary>
        /// Coastal patrol unit in size 45-60 metres designed for use in offshore waters. May or may not be armed with guns.
        /// </summary>
        [DomValIx(1000311)]
        [StringValue("PBO")]
        [EnumMember]
        PatrolBoatOffshore,
		
        /// <summary>
        /// Police operated coastal patrol unit intended for a basically coastal guarding function. Includes any coastal patrol ship under 45 metres that cannot qualify as a Patrol ship, gun equipped, general in armament. May be unarmed.
        /// </summary>
        [DomValIx(1000312)]
        [StringValue("VPB")]
        [EnumMember]
        PatrolBoatPolice,
		
        /// <summary>
        /// Lightly armed unit generally suitable by design only for operations in sheltered waters, such as rivers and roadsteads.
        /// </summary>
        [DomValIx(1000313)]
        [StringValue("PBR")]
        [EnumMember]
        PatrolBoatRiverRoadstead,
		
        /// <summary>
        /// Patrol, blockade and surveillance ship in range 45-85 metres overall. Designed to operate in other than open ocean areas. Has special mission of attacking hostile ships. Must have at least 76mm main armament and is fitted with one or more force guided missile systems.
        /// </summary>
        [DomValIx(1000314)]
        [StringValue("PGG")]
        [EnumMember]
        PatrolCombatantGuidedMissile,
		
        /// <summary>
        /// Patrol, blockade and surveillance ship in range 45-85 metres overall. Designed to operate in other than open ocean areas. Has special mission of attacking hostile ships. Must have at least 76mm main armament and is fitted with guns and other than force guided missile systems. Also known as motor gunboat.
        /// </summary>
        [DomValIx(1000315)]
        [StringValue("PGM")]
        [EnumMember]
        PatrolCombatantGuidedMissileMotorGunboat,
		
        /// <summary>
        /// Patrol, blockade and surveillance ship in range 45-85 metres overall. Designed to operate in other than open ocean areas. Has special mission of attacking hostile ships. Must have at least 76mm main armament. It is fitted with one or more force guided missile systems and is either an air cushion or surface effect design.
        /// </summary>
        [DomValIx(1000316)]
        [StringValue("PGGJ")]
        [EnumMember]
        PatrolCombatantGuidedMissileAirCushion,
		
        /// <summary>
        /// Patrol, blockade and surveillance ship in range 45-85 metres overall. Designed to operate in other than open ocean areas. Has special mission of attacking hostile ships. Must have at least 76mm main armament. It is fitted with one or more force guided missile systems and is fitted with hydrofoils.
        /// </summary>
        [DomValIx(1000317)]
        [StringValue("PGGK")]
        [EnumMember]
        PatrolCombatantGuidedMissileHydrofoil,
		
        /// <summary>
        /// A high-speed patrol hovercraft that can conduct surveillance screening and special operations and is operated by naval or marine forces.
        /// </summary>
        [DomValIx(1000318)]
        [StringValue("PHJ")]
        [EnumMember]
        PatrolCombatantHovercraft,
		
        /// <summary>
        /// A high-speed patrol hovercraft, which can conduct surveillance screening and special operations and is operated by naval or marine forces and is fitted with other than force guided missile systems.
        /// </summary>
        [DomValIx(1000319)]
        [StringValue("PHJM")]
        [EnumMember]
        PatrolCombatantHovercraftGuidedMissile,
		
        /// <summary>
        /// A high-speed patrol hovercraft which is used primarily in minewarfare.
        /// </summary>
        [DomValIx(1000320)]
        [StringValue("PHJS")]
        [EnumMember]
        PatrolCombatantHovercraftMineWarfare,
		
        /// <summary>
        /// Patrol, blockade and surveillance ship in range 45-85 metres overall. Designed to operate in other than open ocean areas. Has special mission of attacking hostile ships. Must have at least 76mm main armament and is fitted with hydrofoils.
        /// </summary>
        [DomValIx(1000321)]
        [StringValue("PGK")]
        [EnumMember]
        PatrolCombatantHydrofoil,
		
        /// <summary>
        /// Vessel in size range 35-55 metres designed and fitted primarily for escort duties in ASW role capable of at least 35 knots - 65 km/hr and has either an air cushion or surface effect design.
        /// </summary>
        [DomValIx(1000322)]
        [StringValue("PCFJ")]
        [EnumMember]
        PatrolCraftAirCushionFast,
		
        /// <summary>
        /// Vessel in size range 55-75 metres designed and fitted primarily for ASW role and coastal duty. NOTE: Improved seakeeping, vice mere large size, distinguishes Patrol craft, coastal escort from Patrol craft, submarine chaser/escort, general, and vessels lacking this should be typed as Patrol craft, submarine chaser/escort, general.
        /// </summary>
        [DomValIx(1000323)]
        [StringValue("PCE")]
        [EnumMember]
        PatrolCraftCoastalEscort,
		
        /// <summary>
        /// Craft used primarily for training personnel for service aboard patrol types. However, may be armed and used as a Patrol boat, general.
        /// </summary>
        [DomValIx(1000324)]
        [StringValue("YP")]
        [EnumMember]
        PatrolCraftHarbor,
		
        /// <summary>
        /// Vessel in size range 35-55 metres designed and fitted primarily for escort duties in ASW role and is fitted with hydrofoils.
        /// </summary>
        [DomValIx(1000325)]
        [StringValue("PCK")]
        [EnumMember]
        PatrolCraftHydrofoil,
		
        /// <summary>
        /// Vessel in size range 35-55 metres designed and fitted primarily for escort duties in ASW role. It is capable of at least 35 knots and is fitted with hydrofoils.
        /// </summary>
        [DomValIx(1000326)]
        [StringValue("PCFK")]
        [EnumMember]
        PatrolCraftHydrofoilFast,
		
        /// <summary>
        /// Police operated vessel in size range 35-55 metres designed and fitted primarily for escort duties in ASW role.
        /// </summary>
        [DomValIx(1000327)]
        [StringValue("VPC")]
        [EnumMember]
        PatrolCraftPolice,
		
        /// <summary>
        /// Vessel in size range 35-55 metres designed and fitted primarily for escort duties in the anti submarine warfare role capable of at least 35 knots - 65 km/hr.
        /// </summary>
        [DomValIx(1000328)]
        [StringValue("PCF")]
        [EnumMember]
        PatrolCraftSubmarineChaserFast,
		
        /// <summary>
        /// Vessel in size range 35-55 metres designed and fitted primarily for escort duties in ASW role.
        /// </summary>
        [DomValIx(1000329)]
        [StringValue("PC")]
        [EnumMember]
        PatrolCraftSubmarineChaserEscortGeneral,
		
        /// <summary>
        /// High-speed (35 knots) anti-surface ship patrol craft in size range 20 - 30 metres fitted with torpedoes.
        /// </summary>
        [DomValIx(1000330)]
        [StringValue("PT")]
        [EnumMember]
        PatrolCraftTorpedo,
		
        /// <summary>
        /// Vessel in size range 35-55 metres designed and fitted primarily for escort duties in ASW role and used primarily in a training role.
        /// </summary>
        [DomValIx(1000331)]
        [StringValue("PCT")]
        [EnumMember]
        PatrolCraftTraining,
		
        /// <summary>
        /// ASW (anti-submarine warfare) patrol ship in size range 45 - 85 metres fitted with medium range sonar and ASW weapons.
        /// </summary>
        [DomValIx(1000332)]
        [StringValue("PGS")]
        [EnumMember]
        PatrolShipAntiSubmarineWarfare,
		
        /// <summary>
        /// Patrol, blockade and surveillance ship in range 45-85 metres overall. Designed to operate in other than open ocean areas. Has special mission of attacking hostile ships. Must have at least 76mm main armament and be capable of at least 35 knots - 65 km/hr.
        /// </summary>
        [DomValIx(1000333)]
        [StringValue("PGF")]
        [EnumMember]
        PatrolShipFast,
		
        /// <summary>
        /// Patrol, blockade and surveillance ship in range 45-85 metres overall. Designed to operate in other than open ocean areas. Has special mission of attacking hostile ships. Must have at least 76mm main armament.
        /// </summary>
        [DomValIx(1000334)]
        [StringValue("PG")]
        [EnumMember]
        PatrolShipGunEquippedGeneral,
		
        /// <summary>
        /// Any ship designed as an icebreaker but employed primarily in a patrol mission. The icebreaking capability is to facilitate the patrol function through ice, rather than to support the movement of other ships.
        /// </summary>
        [DomValIx(1000335)]
        [StringValue("PGB")]
        [EnumMember]
        PatrolShipIcebreaker,
		
        /// <summary>
        /// Coastal patrol unit in size over 60 metres designed for use in offshore waters. May or may not be armed with guns.
        /// </summary>
        [DomValIx(1000336)]
        [StringValue("PSO")]
        [EnumMember]
        PatrolShipOffshore,
		
        /// <summary>
        /// General designator for patrol vessels.
        /// </summary>
        [DomValIx(1000337)]
        [StringValue("PP")]
        [EnumMember]
        PatrolVesselGeneral,
		
        /// <summary>
        /// Ship of any size employed primarily to furnish facilities and services for the support and repair of small patrol craft, the primary function being support.
        /// </summary>
        [DomValIx(1000338)]
        [StringValue("AGP")]
        [EnumMember]
        PatrolTorpedoBoatSupportShipTender,
		
        /// <summary>
        /// Ship of at least 120 metres employed to transport troops, their supplies and equipment.
        /// </summary>
        [DomValIx(1000339)]
        [StringValue("AP")]
        [EnumMember]
        PersonnelTransport,
		
        /// <summary>
        /// Police operated craft usually 40 metres or less equipped to provide support for divers.
        /// </summary>
        [DomValIx(1000340)]
        [StringValue("VYDT")]
        [EnumMember]
        PoliceDivingTender,
		
        /// <summary>
        /// Police operated small craft less than 20 metres employed in sheltered waters for transporting personnel.
        /// </summary>
        [DomValIx(1000341)]
        [StringValue("VYFL")]
        [EnumMember]
        PoliceLaunch,
		
        /// <summary>
        /// Ship of at least 40 metres whose primary purpose is to provide 3rd line medical and surgical care. Not declared by ICRC/red crescent (TU ships only). May be armed and carrying secure communications.
        /// </summary>
        [DomValIx(1000342)]
        [StringValue("APCR")]
        [EnumMember]
        PrimaryCasualtyReceivingShip,
		
        /// <summary>
        /// Sailing vessel designed specifically for ocean racing. May have auxiliary inboard engines.
        /// </summary>
        [DomValIx(1000343)]
        [StringValue("RCRUSR")]
        [EnumMember]
        RacingCruiser,
		
        /// <summary>
        /// Unarmed surface ship employed for radar picket duty.
        /// </summary>
        [DomValIx(1000344)]
        [StringValue("AGR")]
        [EnumMember]
        RadarPicketShipUnarmed,
		
        /// <summary>
        /// Ship 40 metres or more designed to transport radioactive liquids.
        /// </summary>
        [DomValIx(1000345)]
        [StringValue("AOSR")]
        [EnumMember]
        RadiologicalLiquidShip,
		
        /// <summary>
        /// Craft used for safety and utility purposes on ranges.
        /// </summary>
        [DomValIx(1000346)]
        [StringValue("YFRT")]
        [EnumMember]
        RangeTender,
		
        /// <summary>
        /// Barge optimised to repair nuclear propulsion plants.
        /// </summary>
        [DomValIx(1000347)]
        [StringValue("YRRN")]
        [EnumMember]
        RepairBargeNuclearPropulsion,
		
        /// <summary>
        /// Ship of at least 120 metres or more employed as a mobile repair facility providing limited support to various types of ships. Not a lifting ship. Repair primary function, support secondary.
        /// </summary>
        [DomValIx(1000348)]
        [StringValue("AR")]
        [EnumMember]
        RepairShip,
		
        /// <summary>
        /// Ship of any size used to repair helicopters, aircraft and aircraft engines.
        /// </summary>
        [DomValIx(1000349)]
        [StringValue("ARV")]
        [EnumMember]
        RepairShipAircraft,
		
        /// <summary>
        /// Ship of at least 120 metres or more employed as a mobile repair facility providing limited support to various types of ships. Not a lifting ship. Repair primary function, support secondary and optimised for repair of battle damage.
        /// </summary>
        [DomValIx(1000350)]
        [StringValue("ARB")]
        [EnumMember]
        RepairShipBattleDamage,
		
        /// <summary>
        /// Ship 40 metres or more employed to lay, retrieve and maintain submarine cables.
        /// </summary>
        [DomValIx(1000351)]
        [StringValue("ARC")]
        [EnumMember]
        RepairShipCable,
		
        /// <summary>
        /// Ship of at least 120 metres or more employed as a mobile repair facility providing limited support to various types of ships. Not a lifting ship. Repair primary function, support secondary and optimised for extensive repairs to ships hulls.
        /// </summary>
        [DomValIx(1000352)]
        [StringValue("ARH")]
        [EnumMember]
        RepairShipHeavyHull,
		
        /// <summary>
        /// Ship optimised to provide mobile repairs to radiological installations and facilities.
        /// </summary>
        [DomValIx(1000353)]
        [StringValue("ARR")]
        [EnumMember]
        RepairShipRadiological,
		
        /// <summary>
        /// Ship 40-120 metres capable of providing mobile repair facilities and possible limited support to smaller boats.
        /// </summary>
        [DomValIx(1000354)]
        [StringValue("ARL")]
        [EnumMember]
        RepairShipSmall,
		
        /// <summary>
        /// Ship 49 metres or more used to conduct tests, experiments and/or research.
        /// </summary>
        [DomValIx(1000355)]
        [StringValue("AGE")]
        [EnumMember]
        ResearchShip,
		
        /// <summary>
        /// Vessel powered by oars.
        /// </summary>
        [DomValIx(1000356)]
        [StringValue("QR")]
        [EnumMember]
        RowBoat,
		
        /// <summary>
        /// Vessel of no specific design used for utility purposes.
        /// </summary>
        [DomValIx(1000357)]
        [StringValue("RABOUT")]
        [EnumMember]
        Runabout,
		
        /// <summary>
        /// Craft of 40 metres or less employed to raise sunken ships. Lift capacity about 60 tons.
        /// </summary>
        [DomValIx(1000358)]
        [StringValue("YLC")]
        [EnumMember]
        SalvageLiftCraft,
		
        /// <summary>
        /// Ship at least 40 metres used to provide mobile salvage, repairs, diving and rescue services.
        /// </summary>
        [DomValIx(1000359)]
        [StringValue("ARS")]
        [EnumMember]
        SalvageShip,
		
        /// <summary>
        /// Ship at least 40 metres used to provide mobile salvage, repairs, diving and rescue services, must have heavy lifting capability.
        /// </summary>
        [DomValIx(1000360)]
        [StringValue("ARSD")]
        [EnumMember]
        SalvageShipLifting,
		
        /// <summary>
        /// Sailing vessel of schooner design.
        /// </summary>
        [DomValIx(1000361)]
        [StringValue("SCHOON")]
        [EnumMember]
        Schooner,
		
        /// <summary>
        /// Aircraft designed to take-off/land on water.
        /// </summary>
        [DomValIx(1000362)]
        [StringValue("QS")]
        [EnumMember]
        Seaplane,
		
        /// <summary>
        /// Coast guard aircraft capable of operating from water.
        /// </summary>
        [DomValIx(1000363)]
        [StringValue("WQS")]
        [EnumMember]
        SeaplaneCoastGuard,
		
        /// <summary>
        /// Craft, usually under 40 metres overall employed in general or multi-purpose functions of support, training, R&D or test in nature and used for experimental purposes.
        /// </summary>
        [DomValIx(1000364)]
        [StringValue("YAGE")]
        [EnumMember]
        ServiceCraftExperimental,
		
        /// <summary>
        /// Craft, usually under 40 metres overall employed in general or multi-purpose functions of support, training, R&D or test in nature.
        /// </summary>
        [DomValIx(1000365)]
        [StringValue("YAG")]
        [EnumMember]
        ServiceCraftMiscellaneous,
		
        /// <summary>
        /// Craft used to rescue, tow, service or support seaplanes.
        /// </summary>
        [DomValIx(1000366)]
        [StringValue("YVS")]
        [EnumMember]
        ServiceCraftSeaplane,
		
        /// <summary>
        /// Craft, usually under 40 metres overall employed in general or multi-purpose functions of support, training, R&D or test in nature. It is used for experimental purposes with a surface effect design.
        /// </summary>
        [DomValIx(1000367)]
        [StringValue("YAGK")]
        [EnumMember]
        ServiceCraftSurfaceEffectExperimental,
		
        /// <summary>
        /// Craft 45 metres or less employed as a target in support of gunnery or missile firing training.
        /// </summary>
        [DomValIx(1000368)]
        [StringValue("YAGT")]
        [EnumMember]
        ServiceCraftTarget,
		
        /// <summary>
        /// General designator for yard service craft.
        /// </summary>
        [DomValIx(1000369)]
        [StringValue("YY")]
        [EnumMember]
        ServiceCraftYardGeneral,
		
        /// <summary>
        /// Ship employed in servicing surface targets.
        /// </summary>
        [DomValIx(1000370)]
        [StringValue("AGT")]
        [EnumMember]
        ServiceShipTarget,
		
        /// <summary>
        /// Ship employed in servicing torpedoes and sub-surface targets.
        /// </summary>
        [DomValIx(1000371)]
        [StringValue("AGTT")]
        [EnumMember]
        ServiceShipTorpedoTarget,
		
        /// <summary>
        /// Sailing vessel of sloop design.
        /// </summary>
        [DomValIx(1000372)]
        [StringValue("SLOOP")]
        [EnumMember]
        Sloop,
		
        /// <summary>
        /// Any ship equipped to recover space capsules following space flights.
        /// </summary>
        [DomValIx(1000373)]
        [StringValue("ASVR")]
        [EnumMember]
        SpaceVehicleRecoveryShip,
		
        /// <summary>
        /// Ship 40 metres or more designed to transport a special kind of propellant or other non-nuclear associated liquid cargo.
        /// </summary>
        [DomValIx(1000374)]
        [StringValue("AOS")]
        [EnumMember]
        SpecialLiquidShip,
		
        /// <summary>
        /// A light craft specifically designed for special warfare operations.
        /// </summary>
        [DomValIx(1000375)]
        [StringValue("SWCL")]
        [EnumMember]
        SpecialWarfareCraftLight,
		
        /// <summary>
        /// A medium craft specifically designed for special warfare operations.
        /// </summary>
        [DomValIx(1000376)]
        [StringValue("SWCM")]
        [EnumMember]
        SpecialWarfareCraftMedium,
		
        /// <summary>
        /// Small, sleek boat capable of high speeds with or without outboard engines.
        /// </summary>
        [DomValIx(1000377)]
        [StringValue("SPDBAT")]
        [EnumMember]
        Speedboat,
		
        /// <summary>
        /// Ship 60 metres or more capable of underway replenishment of ships with refrigerated and dry provisions. May carry ammunition and POL but main emphasis is on dry provisions.
        /// </summary>
        [DomValIx(1000378)]
        [StringValue("AF")]
        [EnumMember]
        StoresShipNaval,
		
        /// <summary>
        /// Ship 40 metres or more used to provide supplies and services.
        /// </summary>
        [DomValIx(1000379)]
        [StringValue("AKS")]
        [EnumMember]
        StoresShipIssueNaval,
		
        /// <summary>
        /// Ship less than 40 metres or more used to provide supplies and services.
        /// </summary>
        [DomValIx(1000380)]
        [StringValue("AKSL")]
        [EnumMember]
        StoresShipIssueSmallNaval,
		
        /// <summary>
        /// Ship under 60 metres capable of underway replenishment of ships with refrigerated and dry provisions. May carry ammunition and POL but main emphasis is on dry provisions.
        /// </summary>
        [DomValIx(1000381)]
        [StringValue("AFL")]
        [EnumMember]
        StoresShipSmallNaval,
		
        /// <summary>
        /// Ship capable of transporting 5000 or more tons of refrigerated and dry provisions, technical spares and general stores but lacking sophisticated underway replenishment capabilities.
        /// </summary>
        [DomValIx(1000382)]
        [StringValue("AFT")]
        [EnumMember]
        StoresShipTransport,
		
        /// <summary>
        /// Patrol craft optimised for the ASW role.
        /// </summary>
        [DomValIx(1000383)]
        [StringValue("PCS")]
        [EnumMember]
        SubmarineChaser,
		
        /// <summary>
        /// Any ship equipped to rescue personnel entrapped in a sunken submarine.
        /// </summary>
        [DomValIx(1000384)]
        [StringValue("ASR")]
        [EnumMember]
        SubmarineRescueShip,
		
        /// <summary>
        /// Ship of at least 120 metres or more that provides mobile base facilities and support for submarines.
        /// </summary>
        [DomValIx(1000385)]
        [StringValue("AS")]
        [EnumMember]
        SubmarineTender,
		
        /// <summary>
        /// Ship between 40-120 metres, which provide mobile base facilities and support for submarines.
        /// </summary>
        [DomValIx(1000386)]
        [StringValue("ASL")]
        [EnumMember]
        SubmarineTenderSmall,
		
        /// <summary>
        /// Any self-propelled craft specially fitted and employed primarily in support of missile R&D, missile testing, associated training and/or space flights in coastal waters, but not at sea.
        /// </summary>
        [DomValIx(1000387)]
        [StringValue("YAM")]
        [EnumMember]
        SupportBargeMissile,
		
        /// <summary>
        /// Ship employed in missile range support operations.
        /// </summary>
        [DomValIx(1000388)]
        [StringValue("AGMS")]
        [EnumMember]
        SupportShipMissileRange,
		
        /// <summary>
        /// No definition provided in STANAG 1166.
        /// </summary>
        [DomValIx(1000389)]
        [StringValue("AGOS")]
        [EnumMember]
        SurveillanceShipOcean,
		
        /// <summary>
        /// Small craft used for survey purposes in sheltered waters.
        /// </summary>
        [DomValIx(1000390)]
        [StringValue("YGS")]
        [EnumMember]
        SurveyCraft,
		
        /// <summary>
        /// Ship 40 metres or more employed to conduct hydrographic and limited oceanographic surveys.
        /// </summary>
        [DomValIx(1000391)]
        [StringValue("AGS")]
        [EnumMember]
        SurveyShip,
		
        /// <summary>
        /// Ship 40 metres or more employed to conduct hydrographic and limited oceanographic surveys only in coastal and inshore waters.
        /// </summary>
        [DomValIx(1000392)]
        [StringValue("AGSC")]
        [EnumMember]
        SurveyShipCoastal,
		
        /// <summary>
        /// Ship used for surveying arctic/antarctic areas.
        /// </summary>
        [DomValIx(1000393)]
        [StringValue("AGSA")]
        [EnumMember]
        SurveyShipPolar,
		
        /// <summary>
        /// Amphibious ship designed to operate swimmers.
        /// </summary>
        [DomValIx(1000394)]
        [StringValue("LDW")]
        [EnumMember]
        SwimmerDeliveryVehicle,
		
        /// <summary>
        /// Craft equipped for steam cleaning liquid storage tanks or ships.
        /// </summary>
        [DomValIx(1000395)]
        [StringValue("YRG")]
        [EnumMember]
        TankCleaningCraft,
		
        /// <summary>
        /// High-speed (35 knots - 65 km/hr) anti-surface ship patrol craft in size range 20 - 30 metres fitted with torpedoes with either an air cushion or surface effect design.
        /// </summary>
        [DomValIx(1000396)]
        [StringValue("PTJ")]
        [EnumMember]
        TorpedoBoatAirCushion,
		
        /// <summary>
        /// High-speed (35 knots - 65 km/hr) anti-surface ship patrol craft in size range 20 - 30 metres fitted with torpedoes, fitted with hydrofoils.
        /// </summary>
        [DomValIx(1000397)]
        [StringValue("PTK")]
        [EnumMember]
        TorpedoBoatHydrofoil,
		
        /// <summary>
        /// High-speed (35 knots - 65 km/hr) anti-surface ship patrol craft smaller in size range 20 - 30 metres fitted with torpedoes.
        /// </summary>
        [DomValIx(1000398)]
        [StringValue("PTL")]
        [EnumMember]
        TorpedoBoatSmall,
		
        /// <summary>
        /// High-speed (35 knots - 65 km/hr) anti-surface ship patrol craft smaller in size range 20 - 30 metres fitted with torpedoes and hydrofoils.
        /// </summary>
        [DomValIx(1000399)]
        [StringValue("PTLK")]
        [EnumMember]
        TorpedoBoatSmallHydrofoil,
		
        /// <summary>
        /// High-speed (35 knots - 65 km/hr) anti-surface ship patrol craft in size range 20 - 30 metres fitted with torpedoes and used primarily in a training role.
        /// </summary>
        [DomValIx(1000400)]
        [StringValue("PTT")]
        [EnumMember]
        TorpedoBoatTraining,
		
        /// <summary>
        /// Craft used primarily to retrieve spent torpedoes during exercises. However may be armed and used as a harbour patrol craft as an auxiliary duty.
        /// </summary>
        [DomValIx(1000401)]
        [StringValue("YPT")]
        [EnumMember]
        TorpedoRetrieverCraft,
		
        /// <summary>
        /// General designator for any craft used for training purposes.
        /// </summary>
        [DomValIx(1000402)]
        [StringValue("YXT")]
        [EnumMember]
        TrainingCraft,
		
        /// <summary>
        /// Sailing craft of any size used for training.
        /// </summary>
        [DomValIx(1000403)]
        [StringValue("YTS")]
        [EnumMember]
        TrainingCraftSail,
		
        /// <summary>
        /// Large ocean-going ship designed to serve as a training ship.
        /// </summary>
        [DomValIx(1000404)]
        [StringValue("AX")]
        [EnumMember]
        TrainingShipNaval,
		
        /// <summary>
        /// Naval sail training ship.
        /// </summary>
        [DomValIx(1000405)]
        [StringValue("AXS")]
        [EnumMember]
        TrainingShipSailNaval,
		
        /// <summary>
        /// Large non-ocean-going ship designed to serve as a training ship.
        /// </summary>
        [DomValIx(1000406)]
        [StringValue("AXL")]
        [EnumMember]
        TrainingShipSmallNaval,
		
        /// <summary>
        /// Sail or engine powered vessel with three hulls.
        /// </summary>
        [DomValIx(1000407)]
        [StringValue("TRIHUL")]
        [EnumMember]
        Trimaran,
		
        /// <summary>
        /// General designator for craft capable of towing naval ships in sheltered or protected seas.
        /// </summary>
        [DomValIx(1000408)]
        [StringValue("YT")]
        [EnumMember]
        TugHarbour,
		
        /// <summary>
        /// Coastal/harbour tug between 30-40 metres with total horsepower of 1300 or more.
        /// </summary>
        [DomValIx(1000409)]
        [StringValue("YTB")]
        [EnumMember]
        TugHarbourLarge,
		
        /// <summary>
        /// Harbour tug between 20-40 metres with total horsepower between 500 and 1300.
        /// </summary>
        [DomValIx(1000410)]
        [StringValue("YTM")]
        [EnumMember]
        TugHarbourMedium,
		
        /// <summary>
        /// Harbour tug under 20 metres with total horsepower under 500.
        /// </summary>
        [DomValIx(1000411)]
        [StringValue("YTL")]
        [EnumMember]
        TugHarbourSmall,
		
        /// <summary>
        /// General designator for tugs capable of operating in open ocean waters.
        /// </summary>
        [DomValIx(1000412)]
        [StringValue("AT")]
        [EnumMember]
        TugOceanGoing,
		
        /// <summary>
        /// Ship that can provide salvage, repair, diving and rescue services, and tow ships and craft.
        /// </summary>
        [DomValIx(1000413)]
        [StringValue("ATS")]
        [EnumMember]
        TugOceanGoingOrShipSalvageRescue,
		
        /// <summary>
        /// Seagoing tug employed to tow navy ships and craft. Usually about 40-50 metres.
        /// </summary>
        [DomValIx(1000414)]
        [StringValue("ATA")]
        [EnumMember]
        TugOceanGoingAuxiliary,
		
        /// <summary>
        /// Seagoing tug employed to tow navy ships and craft. Usually about 40-50 metres, but equipped to operate with fleets.
        /// </summary>
        [DomValIx(1000415)]
        [StringValue("ATF")]
        [EnumMember]
        TugOceanGoingFleet,
		
        /// <summary>
        /// Seagoing tug employed to tow navy ships and craft. Usually about 40-50 metres, but equipped to operate with fleets and extensively equipped for fire fighting and rescue operations.
        /// </summary>
        [DomValIx(1000416)]
        [StringValue("ATR")]
        [EnumMember]
        TugOceanGoingRescue,
		
        /// <summary>
        /// Tug used for warping ships in berths.
        /// </summary>
        [DomValIx(1000417)]
        [StringValue("YLWT")]
        [EnumMember]
        WarpingTug,
		
        /// <summary>
        /// Ship used primarily for transporting potable water.
        /// </summary>
        [DomValIx(1000418)]
        [StringValue("AWT")]
        [EnumMember]
        WaterTenderNaval,
		
        /// <summary>
        /// Vessel equipped to prepare whales into commercial products.
        /// </summary>
        [DomValIx(1000419)]
        [StringValue("TUW")]
        [EnumMember]
        WhaleFactoryShip,
		
        /// <summary>
        /// Vessel with one or more sails as primary source of power.
        /// </summary>
        [DomValIx(1000420)]
        [StringValue("YAC")]
        [EnumMember]
        Yacht,
		
        /// <summary>
        /// General designator for floating dry docks.
        /// </summary>
        [DomValIx(1000421)]
        [StringValue("YFD")]
        [EnumMember]
        YardFloatingDrydock,
		
        /// <summary>
        /// Sailing vessel of yawl design.
        /// </summary>
        [DomValIx(1000422)]
        [StringValue("YAWL")]
        [EnumMember]
        Yawl,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000423)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000424)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
