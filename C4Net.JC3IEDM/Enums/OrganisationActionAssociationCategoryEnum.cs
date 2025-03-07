using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of relationship between a specific ORGANISATION and a specific ACTION for a specific ORGANISATION-ACTION-ASSOCIATION.
    /// </summary>
    [DomId(100000310)]
    [DataContract]
    public enum OrganisationActionAssociationCategoryEnum
    {
		
        /// <summary>
        /// Performs the detailing of a specific ACTION.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("PLAN")]
        [EnumMember]
        Plans,
		
        /// <summary>
        /// Starts the planning or execution of a specific ACTION.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("INIT")]
        [EnumMember]
        Initiates,
		
        /// <summary>
        /// Responsible for coordinating the ACTION when two, or more, resources are involved.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("COOR")]
        [EnumMember]
        IsCoordinatingAgentFor,
		
        /// <summary>
        /// Authorises a specific ACTION.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("APPR")]
        [EnumMember]
        Approves,
		
        /// <summary>
        /// The specific ORGANISATION that is in charge of the direction, coordination and execution of a specific ACTION-TASK.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CONTRL")]
        [EnumMember]
        Controls,
		
        /// <summary>
        /// Denotes the organisation to be contacted in connection with an ACTION.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("POC")]
        [EnumMember]
        IsPointOfContactFor,
		
        /// <summary>
        /// States the commander's guidance or intent for.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("PROVDR")]
        [EnumMember]
        ProvidesDirectionFor,
		
        /// <summary>
        /// Indicates a need for.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("REQUST")]
        [EnumMember]
        Requests,
		
        /// <summary>
        /// The specific ORGANISATION has witnessed the specific ACTION.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("OBSRVD")]
        [EnumMember]
        Observed,
		
        /// <summary>
        /// The specific ORGANISATION inclines to think that the specific ACTION has occurred, is occurring or will occur.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("SSPCTD")]
        [EnumMember]
        Suspected,
		
        /// <summary>
        /// The specific ORGANISATION accounts for its specific ACTION.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("REP")]
        [EnumMember]
        Reported,
		
        /// <summary>
        /// The specific ORGANISATION takes an interest in the specific ACTION.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("INTRST")]
        [EnumMember]
        IsInterestedIn,
		
        /// <summary>
        /// Denotes the ORGANISATION that acts as the liaison in connection with an ACTION.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("LIAISN")]
        [EnumMember]
        IsLiaisonFor,
		
        /// <summary>
        /// An agency that has the authority to issue an order directing take-off of aircraft as quickly as possible usually followed by mission instructions.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("ISSCRM")]
        [EnumMember]
        IsScrambleAgencyFor,
		
    }
}
