using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the classification of the general content of the artefact cited in a specific REFERENCE.
    /// </summary>
    [DomId(100004232)]
    [DataContract]
    public enum ReferenceContentCategoryEnum
    {
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE provides administrative information.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ADMDOC")]
        [EnumMember]
        AdministrativeDocument,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE constitutes an authorising document.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AUTHRS")]
        [EnumMember]
        Authorisation,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is an official document authorised for a specific use.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CERTFC")]
        [EnumMember]
        Certificate,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE provides compulsory instructions.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DRCTV")]
        [EnumMember]
        Directive,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE provides advisory information.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("GUIDNC")]
        [EnumMember]
        Guidance,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE records medical information.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("HLTDOC")]
        [EnumMember]
        HealthDocument,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE records historical information.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("HISDOC")]
        [EnumMember]
        HistoricalDocument,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is an official document to ascertain identity.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("IDDOC")]
        [EnumMember]
        IdentificationDocument,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE provides information to support learning.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("INSTRC")]
        [EnumMember]
        Instruction,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE records information regarding legal matters.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("LGLDOC")]
        [EnumMember]
        LegalDocument,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE provides graphic geographic information.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("MAP")]
        [EnumMember]
        Map,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is a document that is directive in nature and generally used within the military sphere.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ORDER")]
        [EnumMember]
        Order,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE records information regarding matters affecting personnel.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("PERDOC")]
        [EnumMember]
        PersonnelDocument,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is an authoritative account of an event or situation.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("REPORT")]
        [EnumMember]
        Report,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is a detailed account of the activities of a staff.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("STFFJR")]
        [EnumMember]
        StaffJournalLog,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE provides technical description.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("TECDOC")]
        [EnumMember]
        TechnicalDocument,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE provides a pre-defined guide.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("TEMPLT")]
        [EnumMember]
        Template,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE provides information about test design or test results.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("TSTDOC")]
        [EnumMember]
        TestDocument,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The artefact cited in the specific REFERENCE is composed of several sets ordered in a specified sequence, each set characterized by an identifier and containing information of a specified type, coded and arranged in an ordered sequence of character fields in accordance with the NATO message text formatting rules.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("MTF")]
        [EnumMember]
        MessageTextFormat,
		
    }
}
