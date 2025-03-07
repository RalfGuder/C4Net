using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of power used to move the vessel.
    /// </summary>
    [DomId(100004283)]
    [DataContract]
    public enum VesselTypePropulsionTypeEnum
    {
		
        /// <summary>
        /// The VESSEL-TYPE is powered by air independent propulsion.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIP")]
        [EnumMember]
        AirIndependentPropulsion,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by combined diesel and gas turbine.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CODAG")]
        [EnumMember]
        CombinedDieselAndGasTurbine,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by combined diesel or gas turbine.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CODOG")]
        [EnumMember]
        CombinedDieselOrGasTurbine,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by combined gas or gas turbine.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("COGOG")]
        [EnumMember]
        CombinedGasOrGasTurbine,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by combined nuclear and steam.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CONAS")]
        [EnumMember]
        CombinedNuclearAndSteam,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by combined steam and gas turbine.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("COSAG")]
        [EnumMember]
        CombinedSteamAndGasTurbine,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by diesel electric.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("DE")]
        [EnumMember]
        DieselElectric,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by diesel engine.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("DG")]
        [EnumMember]
        DieselEngine,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by diesel generator.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("DM")]
        [EnumMember]
        DieselGenerator,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by diesel engine/water jet.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("DMWJ")]
        [EnumMember]
        DieselEngineWaterJet,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by electric motor.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("EM")]
        [EnumMember]
        ElectricMotor,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by gasoline engine.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("GTU")]
        [EnumMember]
        GasolineEngine,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by gas turbine.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("NUC")]
        [EnumMember]
        GasTurbine,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by nuclear.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("NUCE")]
        [EnumMember]
        Nuclear,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by nuclear turbo-electric.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("OARS")]
        [EnumMember]
        NuclearTurboElectric,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by oars.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("PJ")]
        [EnumMember]
        Oars,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by pump jet.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("PM")]
        [EnumMember]
        PumpJet,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by Sail.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("SAIL")]
        [EnumMember]
        Sail,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by turbo-electric.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("TE")]
        [EnumMember]
        TurboElectric,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by turbine.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("TU")]
        [EnumMember]
        Turbine,
		
        /// <summary>
        /// The VESSEL-TYPE is powered by water jet.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("WJ")]
        [EnumMember]
        WaterJet,
		
    }
}
