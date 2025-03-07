using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed class or nature of activity prescribed by CBRN-EVENT.
    /// </summary>
    [DomId(100000357)]
    [DataContract]
    public enum CbrnEventSubcategoryEnum
    {
		
        /// <summary>
        /// An explosion of a bomb or projectile above the surface as distinguished from an explosion on contact with the surface or after penetration.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ARBRST")]
        [EnumMember]
        AirBurst,
		
        /// <summary>
        /// The operational action to confirm the presence of a gaseous contaminant.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AIRSMP")]
        [EnumMember]
        AirSampling,
		
        /// <summary>
        /// The action performed to detect a source of Alpha radiation.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ALPRAD")]
        [EnumMember]
        AlphaRadiationSourceDetection,
		
        /// <summary>
        /// The action performed to detect a source of Beta radiation.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("BETRAD")]
        [EnumMember]
        BetaRadiationSourceDetection,
		
        /// <summary>
        /// An event where a fire is consuming materiel and emitting smoke, which may be toxic.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("BRNFIR")]
        [EnumMember]
        BurningFire,
		
        /// <summary>
        /// An event where a continuous flow of possibly toxic liquid is spilled from a container.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CNTFLW")]
        [EnumMember]
        ContinuousFlowFromDamagedPipeOrContainer,
		
        /// <summary>
        /// The action performed to detect a source of Gamma radiation.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("GAMRAD")]
        [EnumMember]
        GammaRadiationSourceDetection,
		
        /// <summary>
        /// An event where a large quantity of possibly toxic liquid is spilled.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("LRGSPL")]
        [EnumMember]
        LargeQuantityOfSpillLiquid,
		
        /// <summary>
        /// The operational action to confirm the presence of a liquid contaminant.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("LQDSMP")]
        [EnumMember]
        LiquidSampling,
		
        /// <summary>
        /// The action performed to detect a source of Neutron particle.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NEUTRN")]
        [EnumMember]
        NeutronRadiationSourceDetection,
		
        /// <summary>
        /// The forensic expertise performed to confirm to commanders the actual occurrence of a chemical or biological event.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("SIBCA")]
        [EnumMember]
        SamplingIdentificationOfBiologicalChemicalAgentSample,
		
        /// <summary>
        /// The forensic expertise performed to confirm to commanders the actual occurrence of a Nuclear event.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SIRA")]
        [EnumMember]
        SamplingAndIdentificationOfRadiologicalAgentSample,
		
        /// <summary>
        /// An event where a small quantity of possibly toxic liquid is spilled.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("SMLSPL")]
        [EnumMember]
        SmallQuantityOfSpillLiquid,
		
        /// <summary>
        /// The explosion of a nuclear weapon in which the centre of the detonation lies at a point beneath the surface of the ground.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("SBSRBU")]
        [EnumMember]
        SubSurfaceBurst,
		
        /// <summary>
        /// An explosion of a nuclear weapon at the surface of land or water; or above the surface at a height less than the maximum radius of the fireball.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("SURBUR")]
        [EnumMember]
        SurfaceBurst,
		
        /// <summary>
        /// The action of detecting a visible NBC (CBRN) cloud.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("CBRNCL")]
        [EnumMember]
        VisibleNbcCloud,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
