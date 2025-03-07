using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that characterises the basis for a specific HOLDING-TRANSFER.
    /// </summary>
    [DomId(100004329)]
    [DataContract]
    public enum HoldingTransferReasonEnum
    {
		
        /// <summary>
        /// The perceived count in a specific HOLDING represents OBJECT-TYPEs that are expected to be received.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("TOTDIN")]
        [EnumMember]
        TotalDueIn,
		
        /// <summary>
        /// The perceived count in a specific HOLDING represents OBJECT-TYPEs that are expected to be transferred out.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("TOTDOT")]
        [EnumMember]
        TotalDueOut,
		
        /// <summary>
        /// The specific HOLDING-TRANSFER represents an OBJECT-TYPE that has been destroyed or lost.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("DSTRYD")]
        [EnumMember]
        DestroyedOrLost,
		
        /// <summary>
        /// The specific HOLDING-TRANSFER represents an OBJECT-TYPE that is lent to the receiving OBJECT-ITEM for a period with a fixed term.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("FXDTRM")]
        [EnumMember]
        FixedTermLoan,
		
        /// <summary>
        /// The specific HOLDING-TRANSFER represents an OBJECT-TYPE that is lent to the receiving OBJECT-ITEM for an indefinite period.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("INDFLN")]
        [EnumMember]
        IndefiniteLoan,
		
        /// <summary>
        /// The specific HOLDING-TRANSFER represents an OBJECT-TYPE that is issued to the receiving OBJECT-ITEM as a user.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("ISSUE")]
        [EnumMember]
        Issue,
		
        /// <summary>
        /// The specific HOLDING-TRANSFER represents an OBJECT-TYPE that is issued to the receiving OBJECT-ITEM as permanent custodian.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PRMTRF")]
        [EnumMember]
        PermanentTransfer,
		
        /// <summary>
        /// The specific HOLDING-TRANSFER represents an OBJECT-TYPE that is returned to the receiving OBJECT-ITEM as the custodian.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("RTNCST")]
        [EnumMember]
        ReturnToCustodian,
		
        /// <summary>
        /// The specific HOLDING-TRANSFER represents an OBJECT-TYPE that is scheduled for delivery to the receiving OBJECT-ITEM as the user.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("SCHSPL")]
        [EnumMember]
        ScheduledSupply,
		
        /// <summary>
        /// The specific HOLDING-TRANSFER represents an OBJECT-TYPE that is being scrapped and removed from the custodian’s responsibility.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("SCRPPD")]
        [EnumMember]
        Scrapped,
		
        /// <summary>
        /// The specific HOLDING-TRANSFER represents an OBJECT-TYPE that is sent to the receiving OBJECT-ITEM in order to perform maintenance.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("TRFMNT")]
        [EnumMember]
        TransferForMaintenance,
		
        /// <summary>
        /// The specific HOLDING-TRANSFER represents an OBJECT-TYPE that is sent to the receiving OBJECT-ITEM as the custodian during transportation operations.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("TRFTRN")]
        [EnumMember]
        TransferForTransportation,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
    }
}
