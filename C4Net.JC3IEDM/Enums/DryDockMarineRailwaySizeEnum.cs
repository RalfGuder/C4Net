using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the bearing capacity of the underwater railway in the DRY-DOCK.
    /// </summary>
    [DomId(100004291)]
    [DataContract]
    public enum DryDockMarineRailwaySizeEnum
    {
		
        /// <summary>
        /// Small - Up to 200 tons.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("S")]
        [EnumMember]
        Small,
		
        /// <summary>
        /// Medium - 201 to 1000 tons.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("M")]
        [EnumMember]
        Medium,
		
        /// <summary>
        /// Large - over 1000 tons.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("L")]
        [EnumMember]
        Large,
		
    }
}
