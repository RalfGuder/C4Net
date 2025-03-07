using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the frequency band of a specific NETWORK.
    /// </summary>
    [DomId(100004124)]
    [DataContract]
    public enum NetworkFrequencyBandEnum
    {
		
        /// <summary>
        /// A frequency of 30 - 300 gigahertz. (EHF)
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("EHF")]
        [EnumMember]
        ExtraHighFrequency,
		
        /// <summary>
        /// A frequency of 3 - 30 megahertz. (HF)
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("HF")]
        [EnumMember]
        HighFrequency,
		
        /// <summary>
        /// A frequency of 30 - 300 kilohertz. (LF)
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LF")]
        [EnumMember]
        LowFrequency,
		
        /// <summary>
        /// A frequency of 300 - 3000 kilohertz. (MF)
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("MF")]
        [EnumMember]
        MediumFrequency,
		
        /// <summary>
        /// A frequency of 3 - 30 gigahertz. (SHF)
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SHF")]
        [EnumMember]
        SuperHighFrequency,
		
        /// <summary>
        /// A frequency of 300 - 3000 megahertz. (UHF)
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("UHF")]
        [EnumMember]
        UltraHighFrequency,
		
        /// <summary>
        /// A frequency of 30 - 300 megahertz. (VHF)
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("VHF")]
        [EnumMember]
        VeryHighFrequency,
		
        /// <summary>
        /// A frequency of 3 - 30 kilohertz. (VLF)
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("VLF")]
        [EnumMember]
        VeryLowFrequency,
		
    }
}
