using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value indicating an airport's main use.
    /// </summary>
    [DomId(100004256)]
    [DataContract]
    public enum AirfieldTypeUseCategoryEnum
    {
		
        /// <summary>
        /// Civil airports controlled and operated by civil authorities primarily used by civil aircrafts although military aircrafts may have landing privileges and/or contract rights.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("A")]
        [EnumMember]
        Civil,
		
        /// <summary>
        /// Joint (civil and military) airports jointly controlled, used or operated by both civil and military agencies.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("B")]
        [EnumMember]
        Joint,
		
        /// <summary>
        /// Airfields having permanent type surface runways with less than the minimum facilities required for civil, joint or military airports.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("D")]
        [EnumMember]
        Limited,
		
        /// <summary>
        /// Military airports controlled and operated by military authorities primarily used by military aircrafts although civil aircrafts may have landing privileges and/or contract rights.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("C")]
        [EnumMember]
        Military,
		
    }
}
