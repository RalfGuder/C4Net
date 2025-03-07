using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of vessels to be serviced.
    /// </summary>
    [DomId(100004288)]
    [DataContract]
    public enum BerthMajorVesselClassEnum
    {
		
        /// <summary>
        /// A long flat-bottomed vessel for carrying freight on canals, rivers, etc.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BARGE")]
        [EnumMember]
        Barge,
		
        /// <summary>
        /// Dry cargo-carrying vessel capable of handling break bulk cargo.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BRKBLK")]
        [EnumMember]
        Breakbulk,
		
        /// <summary>
        /// A vessel specially constructed and equipped to carry standard containers.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CONTNR")]
        [EnumMember]
        Container,
		
        /// <summary>
        /// Vessel 40 metres or more having capability for Roll-on / Roll-off cargo.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("RORO")]
        [EnumMember]
        Roro,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
