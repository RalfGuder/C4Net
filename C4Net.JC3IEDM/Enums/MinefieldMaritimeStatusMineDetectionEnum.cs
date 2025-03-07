using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the status of the means of detection of a mine in a MINEFIELD-MARITIME.
    /// </summary>
    [DomId(100004342)]
    [DataContract]
    public enum MinefieldMaritimeStatusMineDetectionEnum
    {
		
        /// <summary>
        /// The location of mines in the lane swept by visual means.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("SGHTD")]
        [EnumMember]
        Sighted,
		
        /// <summary>
        /// The location of mines by use of a sweep designed to operate the acoustic firing system of a mine, audio frequency.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SWACAF")]
        [EnumMember]
        SweptAcousticAf,
		
        /// <summary>
        /// The location of mines by use of a sweep designed to operate the acoustic firing system of a mine, MF and LF frequency 30 to 15000HZ.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SWACCO")]
        [EnumMember]
        SweptAcousticCombined,
		
        /// <summary>
        /// The location of mines by use of a sweep using the detonation of explosive charges to actuate the acoustic sensors in the mine.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("SWACEX")]
        [EnumMember]
        SweptAcousticExplosive,
		
        /// <summary>
        /// The location of mines by acoustic detonation of sea mines by the generation of underwater acoustic noise.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SWACIN")]
        [EnumMember]
        SweptAcousticInfluence,
		
        /// <summary>
        /// The location of mines by use of a sweep designed to operate the acoustic firing system of a mine, low frequency, up to 30Hz.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("SWACLF")]
        [EnumMember]
        SweptAcousticLf,
		
        /// <summary>
        /// The location of mines by use of a conducting cable, loop shaped through which is passed a high current, towed behind a minesweeper.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("SWMACL")]
        [EnumMember]
        SweptMagneticClosedLoop,
		
        /// <summary>
        /// A sweep designed to locate the mine by operating the magnetic firing system of a mine.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("SWMAIN")]
        [EnumMember]
        SweptMagneticInfluence,
		
        /// <summary>
        /// The location of mines in the lane swept by mechanical means.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("SWMECH")]
        [EnumMember]
        SweptMechanical,
		
        /// <summary>
        /// The location of mines in the lane swept with either a single or multiple ship rig and is designed to ensure that the sweep wire is not brought into contact with the mines antenna until the mine is a safe distance astern.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("SWMEAN")]
        [EnumMember]
        SweptMechanicalAntenna,
		
        /// <summary>
        /// The location of mines in the lane swept by mechanical means, chains, normally fixed between two or more minesweeping vessels, dragged across the sea bed.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("SWMECN")]
        [EnumMember]
        SweptMechanicalChain,
		
        /// <summary>
        /// The location of mines by use of two buoyant conducting cables, an electrode fitted between each leg, the electrical circuit being completed through the seawater.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SWMEEL")]
        [EnumMember]
        SweptMagneticElectrode,
		
        /// <summary>
        /// The location of mines in the lane swept by mechanical means, nets normally fixed between two or more minesweeping vessels.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("SWMENE")]
        [EnumMember]
        SweptMechanicalNet,
		
        /// <summary>
        /// The location of mines by use of a conducting cable, open loop shaped through which is passed a high current, towed behind a minesweeper.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("SWMEOL")]
        [EnumMember]
        SweptMagneticOpenLoop,
		
        /// <summary>
        /// The location of mines that consists of sweep wires streamed one or both quarters, with a kite to keep them down to a set depth astern of the ship and otters controlled by floats to spread the wires horizontally apart.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("SWMEOR")]
        [EnumMember]
        SweptMechanicalOropesa,
		
        /// <summary>
        /// The location of mines by use of a wire to catch the snagline of a moored mine.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("SWMESN")]
        [EnumMember]
        SweptMechanicalSnagline,
		
        /// <summary>
        /// The location of mines by use of large number of horizontal coils through which a small current is passed.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("SWMESO")]
        [EnumMember]
        SweptMagneticSolenoid,
		
        /// <summary>
        /// The location of mines by towing either a mechanical or influence gear through the liquid with the intention of cutting or destruction of mines. Sweep wire towed between two or more ships using only kites to keep the sweep down.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("SWMETE")]
        [EnumMember]
        SweptMechanicalTeam,
		
        /// <summary>
        /// The location of on the liquid bottom surface by use of divers working as a co-ordinated search group.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("SWBTTS")]
        [EnumMember]
        SweptBottomTeamSweep,
		
        /// <summary>
        /// The location of mines by use of a circular snagline search by divers.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("SWCRSS")]
        [EnumMember]
        SweptCircularSnaglineSearch,
		
        /// <summary>
        /// The location of mines by divers entering the water to neutralize/destroy mines.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("SWDVNG")]
        [EnumMember]
        SweptDiving,
		
        /// <summary>
        /// The location of mines by use of an enclosed water grid search.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("SWENWS")]
        [EnumMember]
        SweptEnclosedWatergridSearch,
		
        /// <summary>
        /// The location of mines by use of a jackstay snagline search by divers.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("SWJASS")]
        [EnumMember]
        SweptJackstaySnaglineSearch,
		
        /// <summary>
        /// The location of mines by use of a progressive grid search.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("SWPRGS")]
        [EnumMember]
        SweptProgressiveGridSearch,
		
        /// <summary>
        /// The location of mines by use of a running jackstay search, diver(s).
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("SWRNJS")]
        [EnumMember]
        SweptRunningJackstaySearch,
		
        /// <summary>
        /// The location of mines by usage of sonar equipment.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("SWSNSE")]
        [EnumMember]
        SweptSonarSearch,
		
        /// <summary>
        /// The location of mines by use of a towed free diver.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("SWTWFD")]
        [EnumMember]
        SweptTowedFreeDiver,
		
        /// <summary>
        /// The location of mines by use of an underwater sled, diver.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("SWUNDS")]
        [EnumMember]
        SweptUnderwaterSled,
		
    }
}
