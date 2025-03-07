using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class of MARITIME-EQUIPMENT-TYPE.
    /// </summary>
    [DomId(100004282)]
    [DataContract]
    public enum MaritimeEquipmentTypeSubcategoryEnum
    {
		
        /// <summary>
        /// A temporary marker active buoy used during minesweeping operations to indicate the boundaries of swept paths, swept areas, known hazards or other locations for some specific reason.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BUOYBC")]
        [EnumMember]
        BuoyBeaconDan,
		
        /// <summary>
        /// A temporary marker buoy used during minesweeping operations to indicate the boundaries of swept paths, swept areas, known hazards or other locations of reference points.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BUOYDN")]
        [EnumMember]
        BuoyDan,
		
        /// <summary>
        /// A dan buoy intended as a geographical reference or check, which needs to be more visible and more securely moored than a normal dan buoy.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BUOYDT")]
        [EnumMember]
        BuoyDatumDan,
		
        /// <summary>
        /// A temporary marker active buoy used in deep water during minesweeping operations to indicate the boundaries of swept paths, swept areas, known hazards or other locations for some specific reason.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("BUOYDP")]
        [EnumMember]
        BuoyDeepDan,
		
        /// <summary>
        /// A floating object fastened in a particular place to point out the position of a specific hazard or obstacle or act as a marker for some specific purpose.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("BUOYMR")]
        [EnumMember]
        BuoyMarker,
		
        /// <summary>
        /// A floating object fastened in a particular place to point out the position acting as a reference marker for MCM operations.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("BUOYMS")]
        [EnumMember]
        BuoyMasterReference,
		
        /// <summary>
        /// A floating object fastened in a particular place to point out the position of a specific hazard or obstacle for navigation purposes.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("BUOYNV")]
        [EnumMember]
        BuoyNavigation,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1196/1.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("BUOYPM")]
        [EnumMember]
        BuoyPm5,
		
        /// <summary>
        /// A marked floating object fastened in a particular place to point out the position of a specific hazard or obstacle or act as a marker for some specific reason.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("BUOYPS")]
        [EnumMember]
        BuoyPositionNumber,
		
        /// <summary>
        /// A buoy used as a navigational reference that remains nearly vertical over its sinker.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("BUOYSS")]
        [EnumMember]
        BuoyShortScope,
		
        /// <summary>
        /// A temporary marker active buoy used during minesweeping operations to indicate the boundaries of swept paths, swept areas, known hazards or other locations for some specific reason.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("BUOYSD")]
        [EnumMember]
        BuoyStandardDan,
		
        /// <summary>
        /// In naval mine warfare a device fitted to the end of a sweep wire to cut or part the mooring of mines or obstructors; it may also be fitted in, or to, the mooring of a mine or obstructors to part a sweep wire.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("CUTTEN")]
        [EnumMember]
        CutterEnd,
		
        /// <summary>
        /// In naval mine warfare an explosive device fitted to a sweep wire to cut or part the mooring of mines or obstructors; it may also be fitted in, or to, the mooring of a mine or obstructors to part a sweep wire.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("CUTTEX")]
        [EnumMember]
        CutterExplosive,
		
        /// <summary>
        /// A device that is static and cuts the cable by use of mechanical forces.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("CUTTST")]
        [EnumMember]
        CutterStatic,
		
        /// <summary>
        /// A system that projects acoustic energy into the water and measures the speed of its return from a reflective surface as an echo to detect an underwater object and determine its range and bearing.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("SONRAC")]
        [EnumMember]
        SonarActive,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("SONRCR")]
        [EnumMember]
        SonarCriticalAngleTowedArray,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("SONRDT")]
        [EnumMember]
        SonarDepressedAngleTowedArray,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("SONRDA")]
        [EnumMember]
        SonarDippingActive,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("SONRDP")]
        [EnumMember]
        SonarDippingPassive,
		
        /// <summary>
        /// A hand held acoustic device used primarily for the detection and location of underwater objects.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("SONRHH")]
        [EnumMember]
        SonarHandHeld,
		
        /// <summary>
        /// A system that detects acoustic radiation from another vessel or object.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("SONRPS")]
        [EnumMember]
        SonarPassive,
		
        /// <summary>
        /// A device to make a training mine appear larger or for use during diving conning run ICOS 42+ sides etc.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("SONRRD")]
        [EnumMember]
        SonarReflectorDiablo,
		
        /// <summary>
        /// Equipment mounted on a ship that uses acoustic or SOund Navigation And Ranging (SONAR) technology.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("SONRSH")]
        [EnumMember]
        SonarShip,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("SONRVA")]
        [EnumMember]
        SonarVariableDepthActive,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("SONRVP")]
        [EnumMember]
        SonarVariableDepthPassive,
		
        /// <summary>
        /// No definition provided in ADatP-3 BL 11.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("SONARB")]
        [EnumMember]
        Sonarbuoy,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("SONOAC")]
        [EnumMember]
        SonobuoyActive,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("SONOCA")]
        [EnumMember]
        SonobuoyCommandActivatedSystem,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("SONODC")]
        [EnumMember]
        SonobuoyDirectionalCommandActivatedSystem,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("SONOPA")]
        [EnumMember]
        SonobuoyPassive,
		
        /// <summary>
        /// A part of the buoy equipment.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("STAFF")]
        [EnumMember]
        StaffStave,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("SUBTWA")]
        [EnumMember]
        SubmarineTowedArray,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("SUBTSS")]
        [EnumMember]
        SubmarineTowedArraySurveillanceSystem,
		
        /// <summary>
        /// No definition provided in ADatP-3 Baseline 13.1 FFIRN/FUD 1434/1.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("SUBTAS")]
        [EnumMember]
        SurveillanceTowedArrayLongRangeSystem,
		
        /// <summary>
        /// Equipment designed to be used in minesweeping operations, utilizing the acoustic firing mechanisms of the target mines.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("SWPACO")]
        [EnumMember]
        SweepAcoustic,
		
        /// <summary>
        /// Equipment designed to locate mines by use of a sweep designed to operate the acoustic firing system of a mine, audio frequency.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("SWPAAF")]
        [EnumMember]
        SweepAcousticAf,
		
        /// <summary>
        /// Equipment designed to locate mines by use of a sweep designed to operate the acoustic firing system of a mine, MF and LF frequency 30 to 15000HZ.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("SWPACC")]
        [EnumMember]
        SweepAcousticCombined,
		
        /// <summary>
        /// Equipment designed to locate mines by use of a sweep using the detonation of explosive charges to actuate the acoustic sensors in the mine.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("SWPACE")]
        [EnumMember]
        SweepAcousticExplosive,
		
        /// <summary>
        /// Equipment designed to locate mines by use of a sweep designed to operate the acoustic firing system of a mine, low frequency, up to 30Hz.
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("SWPACL")]
        [EnumMember]
        SweepAcousticLf,
		
        /// <summary>
        /// Equipment mounted on a helicopter designed to be used in minesweeping operations, utilizing the acoustic firing mechanisms of the target mines.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("SWPHAC")]
        [EnumMember]
        SweepHelicopterAcoustic,
		
        /// <summary>
        /// Equipment mounted on a helicopter designed to locate mines by use of a conducting cable through which is passed a high current, towed behind a minesweeper helicopter.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("SWPHMA")]
        [EnumMember]
        SweepHelicopterMagnetic,
		
        /// <summary>
        /// Equipment mounted on a helicopter designed to locate mines in the lane swept by mechanical means.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("SWPHME")]
        [EnumMember]
        SweepHelicopterMechanical,
		
        /// <summary>
        /// Equipment mounted on a hovercraft designed to be used in minesweeping operations, utilising the acoustic firing mechanisms of the target mines.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("SWPHVA")]
        [EnumMember]
        SweepHovercraftAcoustic,
		
        /// <summary>
        /// Equipment mounted on a hovercraft designed to locate mines by use of a conducting cable through which is passed a high current, towed behind a minesweeper hovercraft.
        /// </summary>
        [DomValIx(1000044)]
        [StringValue("SWPHVM")]
        [EnumMember]
        SweepHovercraftMagnetic,
		
        /// <summary>
        /// Equipment mounted on a hovercraft designed to locate mines in the lane swept by mechanical means.
        /// </summary>
        [DomValIx(1000045)]
        [StringValue("SWPHVE")]
        [EnumMember]
        SweepHovercraftMechanical,
		
        /// <summary>
        /// Equipment designed to locate mines in the lane swept with either a single or multiple ship rig and is designed to ensure that the sweep wire is not brought into contact with the mines antenna until the mine is a safe distance astern.
        /// </summary>
        [DomValIx(1000046)]
        [StringValue("SWPMGA")]
        [EnumMember]
        SweepMagneticAntenna,
		
        /// <summary>
        /// Equipment designed to locate mines by use of a conducting cable, loop shaped through which is passed a high current, towed behind a minesweeper.
        /// </summary>
        [DomValIx(1000047)]
        [StringValue("SWPMGC")]
        [EnumMember]
        SweepMagneticClosedLoop,
		
        /// <summary>
        /// Equipment designed to locate mines by use of two buoyant conducting cable an electrode fitted between each leg, the electrical circuit being completed through the seawater.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("SWPMGE")]
        [EnumMember]
        SweepMagneticElectrode,
		
        /// <summary>
        /// Equipment designed to locate mines by use of a conducting cable, open loop shaped through which is passed a high current, towed behind a minesweeper.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("SWPMGO")]
        [EnumMember]
        SweepMagneticOpenLoop,
		
        /// <summary>
        /// Equipment designed to locate mines by use of large number of horizontal coils through which a small current is passed.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("SWPMGS")]
        [EnumMember]
        SweepMagneticSolenoid,
		
        /// <summary>
        /// Equipment designed to locate mines in the lane swept by mechanical means.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("SWPMEC")]
        [EnumMember]
        SweepMechanical,
		
        /// <summary>
        /// Equipment designed to locate mines in the lane swept by mechanical means, chains, normally fixed between two or more minesweeping vessels, dragged across the sea-bed.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("SWPMCC")]
        [EnumMember]
        SweepMechanicalChain,
		
        /// <summary>
        /// Equipment designed to locate mines in the lane swept by mechanical means; nets normally fixed between two or more minesweeping vessels.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("SWPMCN")]
        [EnumMember]
        SweepMechanicalNet,
		
        /// <summary>
        /// Equipment designed to locate mines by use of a wire to catch the snagline of a moored mine.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("SWPMCS")]
        [EnumMember]
        SweepMechanicalSnagline,
		
        /// <summary>
        /// Equipment designed to locate mines by towing either a mechanical or influence gear through the liquid with the intention of cutting or destruction of mines. Sweep wire towed between two or more ships using only kites to keep the sweep down.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("SWPMCT")]
        [EnumMember]
        SweepMechanicalTeam,
		
        /// <summary>
        /// Equipment designed to locate mines using a length of sweep wire that is towed by a single ship, lateral displacement being caused by an Otter and depth being controlled at the ship end by a Kite at the Otter end by a float and float wire.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("SWPORO")]
        [EnumMember]
        SweepOropesa,
		
        /// <summary>
        /// Equipment designed to locate mine by use of pressure differentials.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("SWPPRS")]
        [EnumMember]
        SweepPressure,
		
        /// <summary>
        /// Equipment designed to locate mines by use of a sweep designed to operate the acoustic firing system of a mine, MF and LF frequency 30 to 15000HZ.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("SWPPRT")]
        [EnumMember]
        SweepProtectiveCombination,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A relaying Directional Frequency Ranging sonobuoy with 4-64 Channels.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("MCDFRR")]
        [EnumMember]
        MultiChannelDifarRelay,
		
        /// <summary>
        /// A relaying air dropped sonobuoy with 4-64 channels.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("MCJZBR")]
        [EnumMember]
        MultiChannelJezebelRelay,
		
        /// <summary>
        /// A relaying air dropped sonobuoy 4-64 channels.
        /// </summary>
        [DomValIx(1000062)]
        [StringValue("SHF")]
        [EnumMember]
        Shf,
		
    }
}
