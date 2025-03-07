using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the major material used in building the specific FACILITY.
    /// </summary>
    [DomId(100004119)]
    [DataContract]
    public enum FacilityPrimaryConstructionMaterialEnum
    {
		
        /// <summary>
        /// The primary construction material used in the FACILITY is reinforced concrete.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("REINCN")]
        [EnumMember]
        ReinforcedConcrete,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is rock.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ROCK")]
        [EnumMember]
        Rock,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is sand.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SAND")]
        [EnumMember]
        Sand,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is silt.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("SILT")]
        [EnumMember]
        Silt,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is snow.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("SNOW")]
        [EnumMember]
        Snow,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is wood/timber.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("WOOD")]
        [EnumMember]
        WoodTimber,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// Pre-constructed pieces from a composition of gravel, sand, cement, and water, used for building.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("CNCRBL")]
        [EnumMember]
        ConcreteBlocks,
		
        /// <summary>
        /// Material especially for road making with successive layers of compacted broken stone.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("MACDAM")]
        [EnumMember]
        Macadam,
		
        /// <summary>
        /// The primary construction materiel used in the FACILITY is pierced steel.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("PSTEEL")]
        [EnumMember]
        PiercedSteel,
		
        /// <summary>
        /// The primary construction materiel used in the FACILITY is rolled earth.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("RLDERT")]
        [EnumMember]
        RolledEarth,
		
        /// <summary>
        /// The primary construction materiel used in the FACILITY is steel mat.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("STELMT")]
        [EnumMember]
        SteelMat,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is bituminous (tar or asphalt mixed in place, oiled).
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("BIT")]
        [EnumMember]
        Bitumen,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is clay.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("CLA")]
        [EnumMember]
        Clay,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is coral.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("COR")]
        [EnumMember]
        Coral,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is laterite.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("LAT")]
        [EnumMember]
        Laterite,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is membrane (plastic or other coated fibre material).
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("MEM")]
        [EnumMember]
        Membrane,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is mixed in place using non-bituminous binders such as portland cement.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("MIX")]
        [EnumMember]
        Mix,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is ice.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("ICE")]
        [EnumMember]
        Ice,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is for hard (permanent) surfaces, made up of part concrete, part asphalt, or part bitumen-bound macadam.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("PEM")]
        [EnumMember]
        PermanentSurfaceMix,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is for hard (permanent) surfaces, but the type is unknown.
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("PER")]
        [EnumMember]
        PermanentSurface,
		
        /// <summary>
        /// The construction material used in the FACILITY is composite, where 50 percent or more of the FACILITY surface length is made up of permanent (hard) surface material.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("COP")]
        [EnumMember]
        CompositePermanent,
		
        /// <summary>
        /// The construction material used in the FACILITY is composite, where less than 50 percent of the FACILITY surface length is made up of permanent (hard) surface material.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("COM")]
        [EnumMember]
        CompositeSoft,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is asphalt.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ASPHLT")]
        [EnumMember]
        Asphalt,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is brick/masonry.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BRKMSN")]
        [EnumMember]
        BrickMasonry,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is cobblestone.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CBLSTN")]
        [EnumMember]
        Cobblestone,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is concrete.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("CNCRTE")]
        [EnumMember]
        Concrete,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is earth.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("EARTH")]
        [EnumMember]
        Earth,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is gravel.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("GRAVEL")]
        [EnumMember]
        Gravel,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is metal.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("METAL")]
        [EnumMember]
        Metal,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is pebble.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("PEBBLE")]
        [EnumMember]
        Pebble,
		
        /// <summary>
        /// The primary construction material used in the FACILITY is pre-stressed concrete.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("PRSTCN")]
        [EnumMember]
        PreStressedConcrete,
		
    }
}
