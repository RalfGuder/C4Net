using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents whether the port has sufficient facilities for receiving oily or chemically contaminated dirty ballast.
    /// </summary>
    [DomId(100004295)]
    [DataContract]
    public enum HarbourDirtyBallastIndicatorEnum
    {
		
        /// <summary>
        /// The port has not sufficient facilities for receiving dirty ballast.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NO")]
        [EnumMember]
        No,
		
        /// <summary>
        /// The port has sufficient facilities for receiving dirty ballast.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("YES")]
        [EnumMember]
        Yes,
		
    }
}
