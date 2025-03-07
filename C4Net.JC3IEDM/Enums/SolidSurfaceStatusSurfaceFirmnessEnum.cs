using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the firmness of a surface area, in terms of its ability to support land vehicles or helicopters.
    /// </summary>
    [DomId(100000308)]
    [DataContract]
    public enum SolidSurfaceStatusSurfaceFirmnessEnum
    {
		
        /// <summary>
        /// The surface area can be used by three or four ton vehicles which should be able to start from rest using four-wheel drive.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MODER")]
        [EnumMember]
        Moderate,
		
        /// <summary>
        /// On the surface area, four-wheel drive vehicles cannot start from rest but might be able to cross if already on the move.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("SOFT")]
        [EnumMember]
        Soft,
		
        /// <summary>
        /// The surface area is able to support the helicopter and can be used by two-wheel drive vehicles or four-wheel drive vehicles and trailers.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("HARD")]
        [EnumMember]
        Hard,
		
        /// <summary>
        /// Wheeled vehicles cannot progress across the surface.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("VSOFT")]
        [EnumMember]
        VerySoft,
		
    }
}
