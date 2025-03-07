using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of FACILITY-STATUS.
    /// </summary>
    [DomId(100000319)]
    [DataContract]
    public enum FacilityStatusCategoryEnum
    {
		
        /// <summary>
        /// A FACILITY-STATUS that is a record of condition of a specific medical facility.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MEDFST")]
        [EnumMember]
        MedicalFacilityStatus,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// A FACILITY-STATUS that is a record of conditions of a specific AIRFIELD.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AIRFST")]
        [EnumMember]
        AirfieldStatus,
		
        /// <summary>
        /// A FACILITY-STATUS that is a record of condition of a specific MINEFIELD-MARITIME.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MNMAST")]
        [EnumMember]
        MinefieldMaritimeStatus,
		
    }
}
