using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of relationship between the subject OBJECT-ITEM and the object OBJECT-ITEM in a specific OBJECT-ITEM-ASSOCIATION.
    /// </summary>
    [DomId(100004142)]
    [DataContract]
    public enum ObjectItemAssociationCategoryEnum
    {
		
        /// <summary>
        /// The subject PERSON has equal standing with the object PERSON.
        /// </summary>
        [DomValIx(1000082)]
        [StringValue("ISPEER")]
        [EnumMember]
        IsAPeerOf,
		
        /// <summary>
        /// The subject ORGANISATION is designated for duty at the object FACILITY.
        /// </summary>
        [DomValIx(1000083)]
        [StringValue("ISASTO")]
        [EnumMember]
        IsAssignedTo,
		
        /// <summary>
        /// The subject FACILITY, ORGANISATION or PERSON is granted formal entitlement to the object MATERIEL.
        /// </summary>
        [DomValIx(1000084)]
        [StringValue("ISAUTO")]
        [EnumMember]
        IsAuthorisedTo,
		
        /// <summary>
        /// The subject ORGANISATION has taken possession, as a result of forceful means, of the space associated with the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000085)]
        [StringValue("ISCPTS")]
        [EnumMember]
        IsCaptorOfSpaceDefinedBy,
		
        /// <summary>
        /// Part of the subject CONTROL-FEATURE is described or delineated by the whole of the object GEOGRAPHIC-FEATURE.
        /// </summary>
        [DomValIx(1000086)]
        [StringValue("ISPPRA")]
        [EnumMember]
        IsPhysicallyPartiallyRepresentedByAllOf,
		
        /// <summary>
        /// Part of the subject CONTROL-FEATURE is described or delineated by part of the object GEOGRAPHIC-FEATURE.
        /// </summary>
        [DomValIx(1000087)]
        [StringValue("ISPPRP")]
        [EnumMember]
        IsPhysicallyPartiallyRepresentedByPartOf,
		
        /// <summary>
        /// The whole of the subject CONTROL-FEATURE is described by the whole of the object GEOGRAPHIC-FEATURE.
        /// </summary>
        [DomValIx(1000088)]
        [StringValue("ISPREA")]
        [EnumMember]
        IsPhysicallyRepresentedInItsEntiretyByAllOf,
		
        /// <summary>
        /// The whole of the subject CONTROL-FEATURE is described by part of the object GEOGRAPHIC-FEATURE.
        /// </summary>
        [DomValIx(1000089)]
        [StringValue("ISPREP")]
        [EnumMember]
        IsPhysicallyRepresentedInItsEntiretyByPartOf,
		
        /// <summary>
        /// The subject OBJECT-ITEM is kept from harm or attack by the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000090)]
        [StringValue("ISPRTC")]
        [EnumMember]
        IsProtectedBy,
		
        /// <summary>
        /// The subject OBJECT-ITEM is located within the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000091)]
        [StringValue("ISSITU")]
        [EnumMember]
        IsSituatedIn,
		
        /// <summary>
        /// The subject PERSON is higher in rank, station or authority than the object PERSON.
        /// </summary>
        [DomValIx(1000092)]
        [StringValue("ISSUPR")]
        [EnumMember]
        IsSuperiorOf,
		
        /// <summary>
        /// The subject OBJECT-ITEM draws its provisions from the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000093)]
        [StringValue("ISSPPL")]
        [EnumMember]
        IsSuppliedBy,
		
        /// <summary>
        /// The subject OBJECT-ITEM depends on the object OBJECT-ITEM for its logistics or other assistance in the course of its functioning.
        /// </summary>
        [DomValIx(1000094)]
        [StringValue("ISSPRT")]
        [EnumMember]
        IsSupportedBy,
		
        /// <summary>
        /// The subject OBJECT-ITEM keeps the object MATERIEL in good repair or efficiency on a routine basis.
        /// </summary>
        [DomValIx(1000095)]
        [StringValue("MAINTN")]
        [EnumMember]
        Maintains,
		
        /// <summary>
        /// The subject OBJECT-ITEM perceives the object OBJECT-ITEM by visual or electro-optical imaging means.
        /// </summary>
        [DomValIx(1000096)]
        [StringValue("OBSRVS")]
        [EnumMember]
        Observes,
		
        /// <summary>
        /// The subject ORGANISATION is responsible for the operation of the object FACILITY.
        /// </summary>
        [DomValIx(1000097)]
        [StringValue("OPERAT")]
        [EnumMember]
        Operates,
		
        /// <summary>
        /// The subject OBJECT-ITEM encompasses part the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000098)]
        [StringValue("PRTENC")]
        [EnumMember]
        PartiallyEncloses,
		
        /// <summary>
        /// The subject ORGANISATION has physical control of the object MATERIEL with or without authorisation.
        /// </summary>
        [DomValIx(1000099)]
        [StringValue("POSESS")]
        [EnumMember]
        Possesses,
		
        /// <summary>
        /// The subject PERSON provides performance evaluations of the object PERSON.
        /// </summary>
        [DomValIx(1000100)]
        [StringValue("RATES")]
        [EnumMember]
        RatesOrAssesses,
		
        /// <summary>
        /// The subject OBJECT-ITEM restores the object MATERIEL to sound condition after damage or failure.
        /// </summary>
        [DomValIx(1000101)]
        [StringValue("REPAIR")]
        [EnumMember]
        Repairs,
		
        /// <summary>
        /// The subject PERSON is under the direction of the object PERSON for tasking.
        /// </summary>
        [DomValIx(1000102)]
        [StringValue("REPORT")]
        [EnumMember]
        ReportsTo,
		
        /// <summary>
        /// The subject ORGANISATION has command responsibility for all administrative and logistic services provided to the object ORGANISATION.
        /// </summary>
        [DomValIx(1000103)]
        [StringValue("HSADMI")]
        [EnumMember]
        HasUnderCommandForAdmin,
		
        /// <summary>
        /// The subject ORGANISATION has command responsibility for daily maintenance services provided to the object ORGANISATION. The object ORGANISATION retains full responsibility for all other administrative functions.
        /// </summary>
        [DomValIx(1000104)]
        [StringValue("HSMAIN")]
        [EnumMember]
        HasUnderCommandForMaint,
		
        /// <summary>
        /// The subject ORGANISATION provides materiel and transportation for the sustainment and movement of the object ORGANISATION.
        /// </summary>
        [DomValIx(1000105)]
        [StringValue("PRVLOG")]
        [EnumMember]
        ProvidesLogisticServicesTo,
		
        /// <summary>
        /// A subject MATERIEL holds an object MATERIEL.
        /// </summary>
        [DomValIx(1000106)]
        [StringValue("CONTNS")]
        [EnumMember]
        Contains,
		
        /// <summary>
        /// The subject MATERIEL is the conveyance for the specified object MATERIEL.
        /// </summary>
        [DomValIx(1000107)]
        [StringValue("ISCNVY")]
        [EnumMember]
        IsConveyanceFor,
		
        /// <summary>
        /// A subject MATERIEL is temporarily attached to an object MATERIEL.
        /// </summary>
        [DomValIx(1000108)]
        [StringValue("ISFSTN")]
        [EnumMember]
        IsFastenedTo,
		
        /// <summary>
        /// A subject MATERIEL is loaded on the object MATERIEL.
        /// </summary>
        [DomValIx(1000109)]
        [StringValue("ISLOAD")]
        [EnumMember]
        IsLoadedOn,
		
        /// <summary>
        /// A subject OBJECT-ITEM is designated as secondary to an object OBJECT-ITEM in the order that it is expected to be used.
        /// </summary>
        [DomValIx(1000110)]
        [StringValue("ISSECN")]
        [EnumMember]
        IsSecondaryTo,
		
        /// <summary>
        /// The subject ORGANISATION aids, protects, complements, or sustains the object ORGANISATION.
        /// </summary>
        [DomValIx(1000111)]
        [StringValue("SUPPRT")]
        [EnumMember]
        Supports,
		
        /// <summary>
        /// The subject ORGANISATION is responsible for the administration of the object FACILITY.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ADMINS")]
        [EnumMember]
        Administers,
		
        /// <summary>
        /// The subject PERSON is the aunt of the object PERSON.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ISAUNT")]
        [EnumMember]
        IsAuntOf,
		
        /// <summary>
        /// The subject PERSON is the brother of the object PERSON.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ISBRTH")]
        [EnumMember]
        IsBrotherOf,
		
        /// <summary>
        /// The subject ORGANISATION has a command and control association with the object ORGANISATION.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("CMDCTL")]
        [EnumMember]
        CommandAndControl,
		
        /// <summary>
        /// The subject FACILITY is connected to the object FACILITY (e.g. a barracks connected to a command post).
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("ISCNNC")]
        [EnumMember]
        IsConnectedTo,
		
        /// <summary>
        /// The subject OBJECT-ITEM has authority over the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("CONTRL")]
        [EnumMember]
        Controls,
		
        /// <summary>
        /// The subject PERSON is the cousin of the object PERSON.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("ISCOUS")]
        [EnumMember]
        IsCousinOf,
		
        /// <summary>
        /// The subject PERSON is the daughter of the object PERSON.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ISDAUG")]
        [EnumMember]
        IsDaughterOf,
		
        /// <summary>
        /// The subject ORGANISATION terminates the function or physical presence of the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("DISE")]
        [EnumMember]
        Disestablishes,
		
        /// <summary>
        /// The subject OBJECT-ITEM is the permanent or temporary user of the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("EMPLOY")]
        [EnumMember]
        Employs,
		
        /// <summary>
        /// The subject OBJECT-ITEM encompasses the whole of object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("ENCLOS")]
        [EnumMember]
        Encloses,
		
        /// <summary>
        /// The subject ORGANISATION sets up the function or physical presence of the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("ESTA")]
        [EnumMember]
        Establishes,
		
        /// <summary>
        /// The subject PERSON is the father of the object PERSON.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("ISFATH")]
        [EnumMember]
        IsFatherOf,
		
        /// <summary>
        /// The subject PERSON is the father-in-law of the object PERSON.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("ISFTLW")]
        [EnumMember]
        IsFatherInLawOf,
		
        /// <summary>
        /// The subject ORGANISATION has a fire unit and combat support association with the object ORGANISATION.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("FUCS")]
        [EnumMember]
        FireUnitAndCombatSupport,
		
        /// <summary>
        /// The subject PERSON is the granddaughter of the object PERSON.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("ISGRDD")]
        [EnumMember]
        IsGranddaughterOf,
		
        /// <summary>
        /// The subject PERSON is the grandfather of the object PERSON.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("ISGRDF")]
        [EnumMember]
        IsGrandfatherOf,
		
        /// <summary>
        /// The subject PERSON is the grandmother of the object PERSON.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("ISGRDM")]
        [EnumMember]
        IsGrandmotherOf,
		
        /// <summary>
        /// The subject PERSON is the grandson of the object PERSON.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("ISGRDS")]
        [EnumMember]
        IsGrandsonOf,
		
        /// <summary>
        /// The subject ORGANISATION has in place the object PERSON on a temporary basis with the objective of coordinating actions.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("HSLOFF")]
        [EnumMember]
        HasAsALiaisonOfficer,
		
        /// <summary>
        /// The subject ORGANISATION has as a member the object PERSON.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("HSMMBR")]
        [EnumMember]
        HasAsAMember,
		
        /// <summary>
        /// The subject ORGANISATION has on call the object PERSON with the objective of coordinating details for each element of support required.
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("HSPOC")]
        [EnumMember]
        HasAsPointOfContact,
		
        /// <summary>
        /// The subject ORGANISATION has the object PERSON assigned on a long-term basis.
        /// </summary>
        [DomValIx(1000027)]
        [StringValue("HSASGN")]
        [EnumMember]
        HasOnAssignment,
		
        /// <summary>
        /// The subject ORGANISATION has the object PERSON assigned on a temporary basis.
        /// </summary>
        [DomValIx(1000028)]
        [StringValue("HSATCH")]
        [EnumMember]
        HasOnAttachment,
		
        /// <summary>
        /// The subject PERSON is the husband of the object PERSON.
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("ISHUSB")]
        [EnumMember]
        IsHusbandOf,
		
        /// <summary>
        /// The subject OBJECT-ITEM has the object OBJECT-ITEM on its account.
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("ISACAU")]
        [EnumMember]
        IsAccountingAuthorityFor,
		
        /// <summary>
        /// The subject FACILITY is affected by the object FEATURE (applies to METEOROLOGICAL-FEATURE).
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("ISAFBY")]
        [EnumMember]
        IsAffectedBy,
		
        /// <summary>
        /// The subject OBJECT-ITEM has its boundaries defined by the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("ISBOND")]
        [EnumMember]
        IsBoundedBy,
		
        /// <summary>
        /// The subject ORGANISATION has part or all of its frontal boundary specified by the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000033)]
        [StringValue("ISBDFR")]
        [EnumMember]
        IsBoundedInTheFrontBy,
		
        /// <summary>
        /// The subject ORGANISATION has part or all of its rear boundary specified by the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000034)]
        [StringValue("ISBDRR")]
        [EnumMember]
        IsBoundedInTheRearBy,
		
        /// <summary>
        /// The subject ORGANISATION has part or all of its left-flank boundary specified by the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000035)]
        [StringValue("ISBDLE")]
        [EnumMember]
        IsBoundedOnTheLeftBy,
		
        /// <summary>
        /// The subject ORGANISATION has part or all of its right-flank boundary specified by the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("ISBDRT")]
        [EnumMember]
        IsBoundedOnTheRightBy,
		
        /// <summary>
        /// The subject ORGANISATION or PERSON has taken possession, as a result of forceful means, of the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("ISCPTR")]
        [EnumMember]
        IsCaptorOf,
		
        /// <summary>
        /// The subject OBJECT-ITEM operates in accordance with procedures implied by the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("ISCONS")]
        [EnumMember]
        IsConstrainedOrEnabledBy,
		
        /// <summary>
        /// A relationship between CONTROL-FEATUREs that denotes that the subject CONTROL-FEATURE defines an end point or objective line for the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("ISEND")]
        [EnumMember]
        IsEndOf,
		
        /// <summary>
        /// The subject OBJECT-ITEM is the owner of the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("ISOWNR")]
        [EnumMember]
        IsOwnerOf,
		
        /// <summary>
        /// The subject OBJECT-ITEM is a constituent of the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("ISPART")]
        [EnumMember]
        IsPartOf,
		
        /// <summary>
        /// The subject OBJECT-ITEM is partially bounded by the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000043)]
        [StringValue("ISPABD")]
        [EnumMember]
        IsPartiallyBoundedBy,
		
        /// <summary>
        /// The subject ORGANISATION provides resources in support of the object FACILITY without being responsible for its administration.
        /// </summary>
        [DomValIx(1000048)]
        [StringValue("ISSPNR")]
        [EnumMember]
        IsSponsorFor,
		
        /// <summary>
        /// A relationship between CONTROL-FEATUREs that denotes that the subject CONTROL-FEATURE defines a starting point or departure line for the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000049)]
        [StringValue("ISSTRT")]
        [EnumMember]
        IsStartOf,
		
        /// <summary>
        /// A relationship between CONTROL-FEATUREs that denotes an ordering in which the subject CONTROL-FEATURE is the successor of the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000050)]
        [StringValue("ISSCSR")]
        [EnumMember]
        IsSuccessorOf,
		
        /// <summary>
        /// The subject ORGANISATION is located on the left side of the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000051)]
        [StringValue("ISLOF")]
        [EnumMember]
        IsToTheLeftOf,
		
        /// <summary>
        /// The subject ORGANISATION is located on the right side of the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000052)]
        [StringValue("ISROF")]
        [EnumMember]
        IsToTheRightOf,
		
        /// <summary>
        /// The subject ORGANISATION or PERSON is under control or authority of the object PERSON.
        /// </summary>
        [DomValIx(1000053)]
        [StringValue("ISUCOM")]
        [EnumMember]
        IsUnderCommandOf,
		
        /// <summary>
        /// The subject PERSON is the legal father of the object PERSON.
        /// </summary>
        [DomValIx(1000054)]
        [StringValue("ISLGLF")]
        [EnumMember]
        IsLegalFatherOf,
		
        /// <summary>
        /// The subject PERSON is the legal mother of the object PERSON.
        /// </summary>
        [DomValIx(1000055)]
        [StringValue("ISLGLM")]
        [EnumMember]
        IsLegalMotherOf,
		
        /// <summary>
        /// The subject PERSON is the mother of the object PERSON.
        /// </summary>
        [DomValIx(1000056)]
        [StringValue("ISMOTH")]
        [EnumMember]
        IsMotherOf,
		
        /// <summary>
        /// The subject PERSON is the mother-in-law of the object PERSON.
        /// </summary>
        [DomValIx(1000057)]
        [StringValue("ISMTLW")]
        [EnumMember]
        IsMotherInLawOf,
		
        /// <summary>
        /// The subject PERSON is the nephew of the object PERSON.
        /// </summary>
        [DomValIx(1000058)]
        [StringValue("ISNEPH")]
        [EnumMember]
        IsNephewOf,
		
        /// <summary>
        /// The subject PERSON is the niece of the object PERSON.
        /// </summary>
        [DomValIx(1000059)]
        [StringValue("ISNIEC")]
        [EnumMember]
        IsNieceOf,
		
        /// <summary>
        /// It is not possible to determine which value is most applicable.
        /// </summary>
        [DomValIx(1000060)]
        [StringValue("NKN")]
        [EnumMember]
        NotKnown,
		
        /// <summary>
        /// The appropriate value is not in the set of specified values.
        /// </summary>
        [DomValIx(1000061)]
        [StringValue("NOS")]
        [EnumMember]
        NotOtherwiseSpecified,
		
        /// <summary>
        /// The subject OBJECT-ITEM is used for a role that is characterised by the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000064)]
        [StringValue("SERVES")]
        [EnumMember]
        ServesAs,
		
        /// <summary>
        /// The subject PERSON is the sister of the object PERSON.
        /// </summary>
        [DomValIx(1000065)]
        [StringValue("ISSIST")]
        [EnumMember]
        IsSisterOf,
		
        /// <summary>
        /// The subject PERSON is the son of the object PERSON.
        /// </summary>
        [DomValIx(1000066)]
        [StringValue("ISSON")]
        [EnumMember]
        IsSonOf,
		
        /// <summary>
        /// The subject ORGANISATION and the object ORGANISATION have additional relationships other than command and control or fire unit and combat support or administrative and combat service support relationships.
        /// </summary>
        [DomValIx(1000067)]
        [StringValue("SUPPL")]
        [EnumMember]
        Supplementary,
		
        /// <summary>
        /// The subject OBJECT-ITEM is responsible for the movement of the object OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000068)]
        [StringValue("TRNSPT")]
        [EnumMember]
        Transports,
		
        /// <summary>
        /// The subject PERSON is the uncle of the object PERSON.
        /// </summary>
        [DomValIx(1000069)]
        [StringValue("ISUNCL")]
        [EnumMember]
        IsUncleOf,
		
        /// <summary>
        /// The subject OBJECT-ITEM uses the object OBJECT-ITEM for its intended function while it is controlled by another organisation.
        /// </summary>
        [DomValIx(1000070)]
        [StringValue("USES")]
        [EnumMember]
        Uses,
		
        /// <summary>
        /// The subject PERSON is the wife of the object PERSON.
        /// </summary>
        [DomValIx(1000071)]
        [StringValue("ISWIFE")]
        [EnumMember]
        IsWifeOf,
		
        /// <summary>
        /// The subject PERSON extends the capacity of the object PERSON in his tasks.
        /// </summary>
        [DomValIx(1000072)]
        [StringValue("AUGMNT")]
        [EnumMember]
        Augments,
		
        /// <summary>
        /// The subject ORGANISATION expends the object MATERIEL.
        /// </summary>
        [DomValIx(1000073)]
        [StringValue("CONSUM")]
        [EnumMember]
        Consumes,
		
        /// <summary>
        /// The subject ORGANISATION arranges the scheduling for the object FACILITY.
        /// </summary>
        [DomValIx(1000074)]
        [StringValue("COORDN")]
        [EnumMember]
        CoordinatesUseOf,
		
        /// <summary>
        /// The subject OBJECT-ITEM perceives the object OBJECT-ITEM as being of possible military interest but without being able to recognise it.
        /// </summary>
        [DomValIx(1000075)]
        [StringValue("DETECT")]
        [EnumMember]
        Detects,
		
        /// <summary>
        /// The subject PERSON takes advantage of the object PERSON.
        /// </summary>
        [DomValIx(1000076)]
        [StringValue("EXPLOT")]
        [EnumMember]
        Exploits,
		
        /// <summary>
        /// The subject ORGANISATION uses the object PERSON to provide expert of professional advice.
        /// </summary>
        [DomValIx(1000077)]
        [StringValue("HSCNSL")]
        [EnumMember]
        HasAsAConsultant,
		
        /// <summary>
        /// The subject ORGANISATION uses the object PERSON as a secret or trusted agent.
        /// </summary>
        [DomValIx(1000078)]
        [StringValue("HSOPER")]
        [EnumMember]
        HasAsAnOperative,
		
        /// <summary>
        /// The subject CONTROL-FEATURE has its function embodied by the object FACILITY or MATERIEL.
        /// </summary>
        [DomValIx(1000079)]
        [StringValue("HSFPEM")]
        [EnumMember]
        HasItsFunctionPhysicallyEmbodiedBy,
		
        /// <summary>
        /// The subject ORGANISATION or PERSON places the object MATERIEL in position and connects or adjusts it for use.
        /// </summary>
        [DomValIx(1000080)]
        [StringValue("INSTAL")]
        [EnumMember]
        Installs,
		
        /// <summary>
        /// The subject CONTROL-FEATURE cuts across or overlaps the object CONTROL-FEATURE.
        /// </summary>
        [DomValIx(1000081)]
        [StringValue("INTRST")]
        [EnumMember]
        Intersects,
		
    }
}
