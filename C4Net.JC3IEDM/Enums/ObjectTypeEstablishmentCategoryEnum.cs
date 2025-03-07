using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of OBJECT-TYPE-ESTABLISHMENT when the established and detail OBJECT-TYPEs are instances of MATERIEL-TYPE.
    /// </summary>
    [DomId(100004190)]
    [DataContract]
    public enum ObjectTypeEstablishmentCategoryEnum
    {
		
        /// <summary>
        /// A list of the associated ancillaries, accessories, tools, literature and spares which, when scheduled together, form a composite vehicle, equipment or store.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CES")]
        [EnumMember]
        CompleteEquipmentSchedule,
		
        /// <summary>
        /// A list showing the disassembly build order of an equipment, identifying the assemblies, sub-assemblies and components which comprise the equipment (or assemblies and sub-assemblies).
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("PCG")]
        [EnumMember]
        PartsCatalogue,
		
    }
}
