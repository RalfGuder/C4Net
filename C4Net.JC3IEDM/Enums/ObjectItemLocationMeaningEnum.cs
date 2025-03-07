using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the meaning of the LOCATION geometry as it pertains to the OBJECT-ITEM.
    /// </summary>
    [DomId(100004144)]
    [DataContract]
    public enum ObjectItemLocationMeaningEnum
    {
		
        /// <summary>
        /// A point representing the mean position of an OBJECT-ITEM. It is derived by manual means.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("CEOFMA")]
        [EnumMember]
        CentreOfMassManualDerivation,
		
        /// <summary>
        /// A location describing the external geometry of an OBJECT-ITEM.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("SHAPE")]
        [EnumMember]
        Shape,
		
        /// <summary>
        /// A specific LOCATION representing the direction from an observer to the specific OBJECT-ITEM. The direction is specified by means of FAN-AREA geometry using the observer's position as the vertex.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("LNBRNG")]
        [EnumMember]
        LineOfBearing,
		
        /// <summary>
        /// The point representing the location of the ORGANISATION is the same as that of its command post.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ASSCP")]
        [EnumMember]
        AssociationWithCommandPost,
		
        /// <summary>
        /// A point representing the mean position of an OBJECT-ITEM. It is calculated by automated means.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("COM")]
        [EnumMember]
        CentreOfMassAutomatedDerivation,
		
        /// <summary>
        /// A point representing the position of an OBJECT-ITEM in accordance to criteria specified by competent authority.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CMDDET")]
        [EnumMember]
        CommanderDetermined,
		
        /// <summary>
        /// A measured water depth or spot depth which has been reduced to chart datum.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("SOUND")]
        [EnumMember]
        Sounding,
		
        /// <summary>
        /// The central position of a maritime force disposition.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("DSPCTR")]
        [EnumMember]
        DispositionCentre,
		
        /// <summary>
        /// The central point of a maritime force formation.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("FRMCTR")]
        [EnumMember]
        FormationCentre,
		
        /// <summary>
        /// The pre-planned movement of a unit or force between designated points detailed by either time, position, course and speed.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("POSOIM")]
        [EnumMember]
        PositionOfIntendedMovement,
		
        /// <summary>
        /// A position in the centre of the front line of a force or convoy when the convoy is not in circular formation.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("CTRMNB")]
        [EnumMember]
        CentreFrontOfForceConvoy,
		
        /// <summary>
        /// Originators current position.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("ORGPRL")]
        [EnumMember]
        OriginatorSPresentLocation,
		
        /// <summary>
        /// A position designated by the OTC in which all positional reports are to be based upon.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("STDPOS")]
        [EnumMember]
        StandardPositionEstabByOtc,
		
        /// <summary>
        /// The current position of an addressee.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("ADRPRP")]
        [EnumMember]
        AddresseeSPresentPosition,
		
    }
}
