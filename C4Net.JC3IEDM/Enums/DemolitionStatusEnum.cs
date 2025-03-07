using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the status of an object destined for demolition.
    /// </summary>
    [DomId(100000367)]
    [DataContract]
    public enum DemolitionStatusEnum
    {
		
        /// <summary>
        /// The object of the demolition was abandoned before the destruction was executed. Demolition devices may still be present.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ABNDIN")]
        [EnumMember]
        AbandonedIncomplete,
		
        /// <summary>
        /// The demolition of the object was cancelled either before demolition devices were attached or these devices were removed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("CANCLD")]
        [EnumMember]
        Cancelled,
		
        /// <summary>
        /// The object is demolished.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("EXECTD")]
        [EnumMember]
        Executed,
		
        /// <summary>
        /// The object of the demolition is planned as a preliminary demolition; execution can proceed without reference to an authorised commander.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("PLNPRL")]
        [EnumMember]
        PlannedPreliminary,
		
        /// <summary>
        /// The object of the demolition is planned as a reserve demolition; execution is to be ordered by a specific authorised commander.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("PLNRES")]
        [EnumMember]
        PlannedReserve,
		
        /// <summary>
        /// The object is prepared for demolition.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("PRPEXE")]
        [EnumMember]
        PreparedForExecution,
		
        /// <summary>
        /// The object is at demolition state 1 (safe). The demolition devices are installed but not armed.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("STATE1")]
        [EnumMember]
        State1,
		
        /// <summary>
        /// The object is at demolition state 2 (armed). The demolition devices are installed and armed; therefore the object is ready for immediate demolition.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("STATE2")]
        [EnumMember]
        State2,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
    }
}
