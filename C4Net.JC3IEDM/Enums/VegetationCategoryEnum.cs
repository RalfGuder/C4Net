using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the general type of vegetation.
    /// </summary>
    [DomId(100004208)]
    [DataContract]
    public enum VegetationCategoryEnum
    {
		
        /// <summary>
        /// Land devoid of vegetation.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BARE")]
        [EnumMember]
        Bare,
		
        /// <summary>
        /// An area where heat is seldom less than 80°F/27°C, humidity normally 80-95% and rainfall on average at least 80 inches per year and rugged terrain.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("JUNGLE")]
        [EnumMember]
        Jungle,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// An area containing crops or gardens.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("PLANT")]
        [EnumMember]
        PlantCultivation,
		
        /// <summary>
        /// An area containing uncultured plants of low height.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("RNGLND")]
        [EnumMember]
        Rangeland,
		
        /// <summary>
        /// A swamp, marsh, or other usually saturated area containing vegetation adapted to wet conditions.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("WETLND")]
        [EnumMember]
        Wetlands,
		
        /// <summary>
        /// An area containing vegetation composed of tree species which have reached sufficient size for use as timber.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("WODLND")]
        [EnumMember]
        Woodland,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
