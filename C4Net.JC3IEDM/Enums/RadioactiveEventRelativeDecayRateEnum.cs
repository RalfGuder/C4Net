using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the rate of decay of fallout relative to the assumed normal value of 1.2 in the Kaufmann equation.
    /// </summary>
    [DomId(100004380)]
    [DataContract]
    public enum RadioactiveEventRelativeDecayRateEnum
    {
		
        /// <summary>
        /// A faster than natural decrease in the radiation intensity of any radioactive material with respect to time.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("DF")]
        [EnumMember]
        DecayFasterThanNormal,
		
        /// <summary>
        /// A natural decrease in the radiation intensity of any radioactive material with respect to time.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("DN")]
        [EnumMember]
        DecayNormal,
		
        /// <summary>
        /// A slower than natural decrease in the radiation intensity of any radioactive material with respect to time.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("DS")]
        [EnumMember]
        DecaySlowerThanNormal,
		
    }
}
