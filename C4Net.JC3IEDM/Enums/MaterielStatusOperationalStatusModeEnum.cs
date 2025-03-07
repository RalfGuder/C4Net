using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the firepower or mobility or communications degradation of a specific MATERIEL.
    /// </summary>
    [DomId(100000257)]
    [DataContract]
    public enum MaterielStatusOperationalStatusModeEnum
    {
		
        /// <summary>
        /// An indication that the associated degraded operational status only applies to the firepower of the specified item of MATERIEL.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("FO")]
        [EnumMember]
        FirepowerOnly,
		
        /// <summary>
        /// An indication that the associated degraded operational status applies to both the mobility and the firepower of the specified item of MATERIEL.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MF")]
        [EnumMember]
        MobilityAndFirepower,
		
        /// <summary>
        /// An indication that the associated degraded operational status only applies to the mobility of the specified item of MATERIEL.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("MO")]
        [EnumMember]
        MobilityOnly,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// An indication that the associated degraded operational status only applies to the communications of the specified item of MATERIEL.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CO")]
        [EnumMember]
        CommunicationsOnly,
		
        /// <summary>
        /// An indication that the associated degraded operational status applies to both the firepower and the communications of the specified item of MATERIEL.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("FC")]
        [EnumMember]
        FirepowerAndCommunications,
		
        /// <summary>
        /// An indication that the associated degraded operational status applies to the firepower, the mobility and the communications of the specified item of MATERIEL.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("FMC")]
        [EnumMember]
        FirepowerMobilityAndCommunications,
		
        /// <summary>
        /// An indication that the associated degraded operational status applies to both the mobility and the communications of the specified item of MATERIEL.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("MC")]
        [EnumMember]
        MobilityAndCommunications,
		
    }
}
