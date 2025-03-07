using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the class of MINEFIELD.
    /// </summary>
    [DomId(100004195)]
    [DataContract]
    public enum MinefieldCategoryEnum
    {
		
        /// <summary>
        /// A MINEFIELD that is an area of land containing mines.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("MNFLND")]
        [EnumMember]
        MinefieldLand,
		
        /// <summary>
        /// A MINEFIELD that is an area or volume of water containing mines.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("MNFMRT")]
        [EnumMember]
        MinefieldMaritime,
		
    }
}
