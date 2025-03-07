using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value providing lead through instructions for a convoy or vessel to pass through a maritime minefield.
    /// </summary>
    [DomId(100004377)]
    [DataContract]
    public enum ActionMaritimeEmploymentVesselTransitInstructionEnum
    {
		
        /// <summary>
        /// Lead through.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LEAD")]
        [EnumMember]
        Lead,
		
        /// <summary>
        /// Proceed independently.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("INFORM")]
        [EnumMember]
        Inform,
		
        /// <summary>
        /// No passage allowed.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("STOP")]
        [EnumMember]
        Stop,
		
    }
}
