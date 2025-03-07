using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of storage facilities available at a specific QUAY.
    /// </summary>
    [DomId(100004183)]
    [DataContract]
    public enum QuayStorageEnum
    {
		
        /// <summary>
        /// A tower or towers for the storage of grain, typically accompanied by loading/offloading facilities for grain.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("GRNSIL")]
        [EnumMember]
        GrainSilo,
		
        /// <summary>
        /// The equipment and resources to securely store, in transit, any cargo that contains a substance that is harmful to humans or living organisms and poses a physical hazard, health hazard or environmental hazard. This includes substances that are toxic, explosive, corrosive, nuclear, ignitable or chemically reactive.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("HAZCAR")]
        [EnumMember]
        HazardousCargo,
		
        /// <summary>
        /// The equipment and resources to hold and store a liquid in transit, and normally has inloading and discharging facilities.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LQDSTR")]
        [EnumMember]
        LiquidStorage,
		
        /// <summary>
        /// The equipment and resources to load/unload, keep temporarily and to manage in a correct way military weapons, ammunition, explosives and associated equipment.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MNTEXP")]
        [EnumMember]
        MunitionsAndExplosives,
		
        /// <summary>
        /// The equipment and resources to load/unload, keep temporarily and to manage in a correct way military chemical, biological, radiological, or nuclear materiel and associated equipment.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CBRN")]
        [EnumMember]
        Cbrn,
		
        /// <summary>
        /// A flat open area, prepared (tarmac, concrete) or natural, on which cargo can be loaded/offloaded from vessels and stored whilst in transit.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("OPENAR")]
        [EnumMember]
        OpenArea,
		
        /// <summary>
        /// A building, usually insulated, with a cooled or chilled inside environment, normally used for keeping in transit anything that is perishable, such as, foodstuffs.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("RFRGTD")]
        [EnumMember]
        Refrigerated,
		
        /// <summary>
        /// The equipment and resources for storing road vehicles in transit. This may be an open area or a multi storey building having several storeys or floors or both, accessible to vehicles by means of ramps.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("VEHCLE")]
        [EnumMember]
        Vehicle,
		
        /// <summary>
        /// A large structure used for the storage of goods or material in transit.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("WARHSE")]
        [EnumMember]
        Warehouse,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
