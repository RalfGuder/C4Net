using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that gives the commitment status of an ORGANISATION.
    /// </summary>
    [DomId(100004116)]
    [DataContract]
    public enum OrganisationStatusCommitmentStatusEnum
    {
		
        /// <summary>
        /// A status indicating that an ORGANISATION is currently tasked.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("COMM")]
        [EnumMember]
        Committed,
		
        /// <summary>
        /// A status indicating that an ORGANISATION is not currently tasked and is available for tasking.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("UNCOMM")]
        [EnumMember]
        Uncommitted,
		
    }
}
