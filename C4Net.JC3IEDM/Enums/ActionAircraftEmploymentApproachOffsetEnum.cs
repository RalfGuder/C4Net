using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the side of the initial point-to-target line that the attack aircraft is cleared to manoeuvre in during the target run.
    /// </summary>
    [DomId(100000221)]
    [DataContract]
    public enum ActionAircraftEmploymentApproachOffsetEnum
    {
		
        /// <summary>
        /// A turn 90 degrees counter clockwise.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("LEFT")]
        [EnumMember]
        Left,
		
        /// <summary>
        /// A turn 90 degrees clockwise.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("RIGHT")]
        [EnumMember]
        Right,
		
        /// <summary>
        /// A turn 90 degrees either clockwise or counter clockwise.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("RL")]
        [EnumMember]
        RightOrLeft,
		
    }
}
