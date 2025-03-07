using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the media of transmission and the quality of the photographic product required.
    /// </summary>
    [DomId(100004252)]
    [DataContract]
    public enum ActionObjectiveTypeImageryProductImageTypeEnum
    {
		
        /// <summary>
        /// Hardcopy 10 by 10 inch imagery product.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("10PRNT")]
        [EnumMember]
        _10X10Print,
		
        /// <summary>
        /// Hardcopy 10 by 12 inch imagery product.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("12PRNT")]
        [EnumMember]
        _10X12Print,
		
        /// <summary>
        /// Hardcopy 8 by 10 inch imagery product.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("8PRNT")]
        [EnumMember]
        _8X10Print,
		
        /// <summary>
        /// 3-dimensional imagery print with a 3D viewer.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ANPRNT")]
        [EnumMember]
        AnaglyphPrintWithViewer,
		
        /// <summary>
        /// Hardcopy imagery product using a compact disc format.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CDROM")]
        [EnumMember]
        CdRom,
		
        /// <summary>
        /// A print made from a negative or a diapositive in direct contact with sensitized material.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CNPRNT")]
        [EnumMember]
        ContactPrint,
		
        /// <summary>
        /// A file that is an exact duplicate of an original.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("DUPFLE")]
        [EnumMember]
        DupeFile,
		
        /// <summary>
        /// A duplicate negative reproduced from a negative or a diapositive.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("DUPNEG")]
        [EnumMember]
        DupeNegative,
		
        /// <summary>
        /// A positive copy made from the original negative.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("DUPPOS")]
        [EnumMember]
        DupePositive,
		
        /// <summary>
        /// A tape that is an exact duplicate of an original.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("DUPTAP")]
        [EnumMember]
        DupeTape,
		
        /// <summary>
        /// Hardcopy imagery product using a DVD format.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("DVD")]
        [EnumMember]
        Dvd,
		
        /// <summary>
        /// A photo magnified to the point before the image loses its identity and becomes a random series of tonal impressions.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("MAXENL")]
        [EnumMember]
        MaxEnlargement,
		
        /// <summary>
        /// An assembly of overlapping photographs that have been matched to form a continuous photographic representation of a portion of the surface of the Earth.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("MOSAIC")]
        [EnumMember]
        Mosaic,
		
        /// <summary>
        /// A photo that is prepared for use as a planning graphic.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("PLNGRP")]
        [EnumMember]
        PlanningGraphic,
		
        /// <summary>
        /// A one to one contact photograph on long rolled paper.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("SONNE")]
        [EnumMember]
        Sonne,
		
        /// <summary>
        /// A photo that is prepared for use as a target graphic.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("TGTGRP")]
        [EnumMember]
        TargetGraphic,
		
    }
}
