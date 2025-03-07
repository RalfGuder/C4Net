using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of ACTION-RESOURCE-EMPLOYMENT.
    /// </summary>
    [DomId(100000207)]
    [DataContract]
    public enum ActionResourceEmploymentCategoryEnum
    {
		
        /// <summary>
        /// The procedure that guides the use of an ACTION-RESOURCE that is capable of atmospheric flight.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AIREMP")]
        [EnumMember]
        ActionAircraftEmployment,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The parameters that guide the use of an ACTION-RESOURCE that is employed in a reconnaissance role.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RECEMP")]
        [EnumMember]
        ActionReconnaissanceEmployment,
		
        /// <summary>
        /// The technique used by an ACTION-RESOURCE for Electronic Warfare by electronic or mechanical means.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ELCEMP")]
        [EnumMember]
        ActionElectronicWarfareEmployment,
		
        /// <summary>
        /// The procedure that guides the use of an ACTION-RESOURCE in a maritime environment.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("MAREMP")]
        [EnumMember]
        ActionMaritimeEmployment,
		
    }
}
