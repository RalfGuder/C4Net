using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the option for terminating the effectiveness of a specific MINEFIELD-LAND.
    /// </summary>
    [DomId(100000142)]
    [DataContract]
    public enum MinefieldLandPersistenceEnum
    {
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// A minefield, already existing and effective, until somebody clears it.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("PERMAN")]
        [EnumMember]
        Permanent,
		
        /// <summary>
        /// A minefield that can be destroyed by remote control.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("REMOTE")]
        [EnumMember]
        RemoteActivatedDestruction,
		
        /// <summary>
        /// A minefield that is in place for a certain period of time after which it destroys itself.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("SLFDST")]
        [EnumMember]
        TimedAutomaticDestruction,
		
    }
}
