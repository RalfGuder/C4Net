using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of a specific HANDLING-CAPABILITY.
    /// </summary>
    [DomId(100004347)]
    [DataContract]
    public enum HandlingCapabilityActionEnum
    {
		
        /// <summary>
        /// The specific HANDLING-CAPABILITY to raise or haul up.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("HOIST")]
        [EnumMember]
        Hoist,
		
        /// <summary>
        /// The specific HANDLING-CAPABILITY involves loading.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("LOAD")]
        [EnumMember]
        Load,
		
        /// <summary>
        /// The specific HANDLING-CAPABILITY involves both loading and unloading.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LOADUN")]
        [EnumMember]
        LoadOrUnload,
		
        /// <summary>
        /// The specific HANDLING-CAPABILITY involves unloading.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("UNLOAD")]
        [EnumMember]
        Unload,
		
    }
}
