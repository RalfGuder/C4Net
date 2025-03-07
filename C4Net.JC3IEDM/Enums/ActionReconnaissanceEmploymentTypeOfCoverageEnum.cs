using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the type of coverage required.
    /// </summary>
    [DomId(100004335)]
    [DataContract]
    public enum ActionReconnaissanceEmploymentTypeOfCoverageEnum
    {
		
        /// <summary>
        /// Reconnaissance of vessels afloat.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("AFLOA")]
        [EnumMember]
        Afloat,
		
        /// <summary>
        /// Reconnaissance of vessels afloat, at an oblique angle.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("AFLOAO")]
        [EnumMember]
        AfloatOblique,
		
        /// <summary>
        /// Reconnaissance of vessels afloat, at vertical angle.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("AFLOAV")]
        [EnumMember]
        AfloatVertical,
		
        /// <summary>
        /// Photographic coverage of a specific area.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("AREAC")]
        [EnumMember]
        AreaCover,
		
        /// <summary>
        /// Photographic coverage of a specific area, at an oblique angle.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("AREACO")]
        [EnumMember]
        AreaCoverOblique,
		
        /// <summary>
        /// Photographic coverage of a specific area, at vertical angle.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("AREACV")]
        [EnumMember]
        AreaCoverVertical,
		
        /// <summary>
        /// Visual search of a specified area and photographing targets of military significance.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("AREAS")]
        [EnumMember]
        AreaSearch,
		
        /// <summary>
        /// Visual search of a specified area and photographing targets of military significance, at an oblique angle.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("AREASO")]
        [EnumMember]
        AreaSearchOblique,
		
        /// <summary>
        /// Visual search of a specified area and photographing targets of military significance, at vertical angle.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("AREASV")]
        [EnumMember]
        AreaSearchVertical,
		
        /// <summary>
        /// Use this data item when a specific type of coverage need not be specified.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("BP")]
        [EnumMember]
        BestPossible,
		
        /// <summary>
        /// Use this data item when a specific type of coverage need not be specified, except for an oblique angle.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("BPO")]
        [EnumMember]
        BestPossibleOblique,
		
        /// <summary>
        /// Use this data item when a specific type of coverage need not be specified, except for vertical angle.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("BPV")]
        [EnumMember]
        BestPossibleVertical,
		
        /// <summary>
        /// Reconnaissance along a specific line of communications, such as a road, railway or waterway, to detect fleeting targets and activities in general.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("LINESE")]
        [EnumMember]
        LineSearch,
		
        /// <summary>
        /// Reconnaissance of a precisely identified point that locates a very small target.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("PINPT")]
        [EnumMember]
        Pinpoint,
		
        /// <summary>
        /// Reconnaissance of a precisely identified point that locates a very small target, at an oblique angle.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("PINPTO")]
        [EnumMember]
        PinpointOblique,
		
        /// <summary>
        /// Reconnaissance of a precisely identified point that locates a very small target, at vertical angle.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("PINPTV")]
        [EnumMember]
        PinpointVertical,
		
        /// <summary>
        /// Visual reconnaissance of a route or lines of communication with photos of targets of military significance.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("ROUTE")]
        [EnumMember]
        RouteReconnaissance,
		
        /// <summary>
        /// Visual reconnaissance of a route or lines of communication with photos of targets of military significance, at an oblique angle.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("ROUTEO")]
        [EnumMember]
        RouteReconnaissanceOblique,
		
        /// <summary>
        /// Visual reconnaissance of a route or lines of communication with photos of targets of military significance, at vertical angle.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("ROUTEV")]
        [EnumMember]
        RouteReconnaissanceVertical,
		
        /// <summary>
        /// Reconnaissance of a limited number of points for specific information.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("SPECS")]
        [EnumMember]
        SpecificSearch,
		
        /// <summary>
        /// Reconnaissance of a limited number of points for specific information, at an oblique angle.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("SPECSO")]
        [EnumMember]
        SpecificSearchOblique,
		
        /// <summary>
        /// Reconnaissance of a limited number of points for specific information, at vertical angle.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("SPECSV")]
        [EnumMember]
        SpecificSearchVertical,
		
        /// <summary>
        /// Continuous photography of a strip of the earth's surface.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("STRIP")]
        [EnumMember]
        Strip,
		
        /// <summary>
        /// Continuous photography of a strip of the earth's surface, at an oblique angle.
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("STRIPO")]
        [EnumMember]
        StripOblique,
		
        /// <summary>
        /// Continuous photography of a strip of the earth's surface, at vertical angle.
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("STRIPV")]
        [EnumMember]
        StripVertical,
		
    }
}
