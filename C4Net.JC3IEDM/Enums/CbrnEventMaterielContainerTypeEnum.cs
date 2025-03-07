using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of container that stores the materiel (agent) involved in a specific CBRN-EVENT and characterised in ATP-45.
    /// </summary>
    [DomId(100004269)]
    [DataContract]
    public enum CbrnEventMaterielContainerTypeEnum
    {
		
        /// <summary>
        /// A case filled with explosive, inflammable material, poison gas, or smoke, etc., dropped from aircraft, or thrown or deposited by hand.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BOM")]
        [EnumMember]
        Bomb,
		
        /// <summary>
        /// A small munition capable of containing a biological warfare agent; a submunition. Numerous bomblets could be packed inside a larger munition (e.g., a bomb or warhead) that would explode in the air scattering the bomblets over a relatively wide area.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BML")]
        [EnumMember]
        Bomblets,
		
        /// <summary>
        /// No definition provided in ATP-45(B).
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("BUK")]
        [EnumMember]
        Bunker,
		
        /// <summary>
        /// An instrument or machine capable of releasing a substance as a fine spray by subjecting it to pressure.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("GEN")]
        [EnumMember]
        GeneratorAerosol,
		
        /// <summary>
        /// A receptacle in which material is held or carried.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CON")]
        [EnumMember]
        GenericStorageContainer,
		
        /// <summary>
        /// A mine containing a chemical or radiological agent designed to kill, injure, or incapacitate personnel or to contaminate materiel or terrain.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("MNE")]
        [EnumMember]
        MineNbcFilledOnly,
		
        /// <summary>
        /// A weapon that is self-propelled or directed by remote control, carrying conventional or nuclear explosive.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("MSL")]
        [EnumMember]
        Missile,
		
        /// <summary>
        /// A cylindrical container that holds 200 litres.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("DRM")]
        [EnumMember]
        Nominal200LitreStorageDrum,
		
        /// <summary>
        /// A facility that contains a controlled nuclear fission chain reaction. It can be used to generate electricity, conduct research, and produce isotopes and manmade elements such as plutonium.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("RCT")]
        [EnumMember]
        Reactor,
		
        /// <summary>
        /// A large metal cylinder holding liquefied gas under pressure.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("BTL")]
        [EnumMember]
        PressurizedGasBottle,
		
        /// <summary>
        /// A cylindrical projectile that can be propelled to a great height or distance by the combustion of its contents.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("RKT")]
        [EnumMember]
        Rocket,
		
        /// <summary>
        /// An explosive artillery projectile or bomb.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("SHL")]
        [EnumMember]
        Shell,
		
        /// <summary>
        /// A container used to dispense chemical or biological agents.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("SPR")]
        [EnumMember]
        SprayTank,
		
        /// <summary>
        /// No definition provided in ATP-45(B).
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("STK")]
        [EnumMember]
        Stockpile,
		
        /// <summary>
        /// A large receptacle or storage chamber, especially for liquid or gas.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("TNK")]
        [EnumMember]
        Tank,
		
        /// <summary>
        /// A cigar-shaped self-propelled underwater missile designed to be fired from a ship, submarine, or an aircraft.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("TOR")]
        [EnumMember]
        Torpedo,
		
        /// <summary>
        /// A container of wastes that includes materials such as laboratory wastes and protective clothing.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("WST")]
        [EnumMember]
        Waste,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
