using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the detailed type of vegetation.
    /// </summary>
    [DomId(100004328)]
    [DataContract]
    public enum VegetationSubcategoryEnum
    {
		
        /// <summary>
        /// Woody, treelike grass.
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("BAMBOO")]
        [EnumMember]
        BambooCane,
		
        /// <summary>
        /// A cultural area where plants and/or trees are displayed.
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("BTNCLG")]
        [EnumMember]
        BotanicalGarden,
		
        /// <summary>
        /// An area that has been tilled for the planting of crops.
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("CRPLND")]
        [EnumMember]
        Cropland,
		
        /// <summary>
        /// A waterless, desolate area of land with little or no vegetation typically covered with sand.
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("DESERT")]
        [EnumMember]
        Desert,
		
        /// <summary>
        /// A dense growth of trees, plants and underbrush covering a large area.
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("FOREST")]
        [EnumMember]
        Forest,
		
        /// <summary>
        /// An area composed of uncultured plants which have little or no woody tissue.
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("GRSLND")]
        [EnumMember]
        Grassland,
		
        /// <summary>
        /// Area composed of uncultured plants which may have some woody tissue.
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("GRASS")]
        [EnumMember]
        GrassScrubBrush,
		
        /// <summary>
        /// A continuous growth of shrubbery planted as a fence, a boundary, or a wind break.
        /// </summary>
        [DomValIx(1000008)]
        [StringValue("HDGERW")]
        [EnumMember]
        Hedgerow,
		
        /// <summary>
        /// An area covered by the systematic planting of hop vines.
        /// </summary>
        [DomValIx(1000009)]
        [StringValue("HOPS")]
        [EnumMember]
        Hops,
		
        /// <summary>
        /// An area of jungle on generally swampy ground where movement is slow and difficult.
        /// </summary>
        [DomValIx(1000010)]
        [StringValue("JUNGCE")]
        [EnumMember]
        JungleCoastalEstuary,
		
        /// <summary>
        /// Areas which include areas such as rice paddies which will tend to be open, flat, dirty and swampy to areas such as rubber plantations which offer similar characteristics to primary jungle except for the fact that the trees will be in straight lines.
        /// </summary>
        [DomValIx(1000011)]
        [StringValue("JUNGC")]
        [EnumMember]
        JungleCultivation,
		
        /// <summary>
        /// An area in lowland tropics, which has heavy rainfall. It has a thick 3 tier canopy up to 60m high and a reasonably clear floor that may permit some vehicular movement. Visibility may not exceed 50m.
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("JUNGP")]
        [EnumMember]
        JunglePrimary,
		
        /// <summary>
        /// An area that has thick undergrowth created through rapid growth after an area of primary jungle has been cleared, movement will be slow and noisy, heat increased due to a lack of canopy and visibility will be reduced to around 20m.
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("JUNGS")]
        [EnumMember]
        JungleSecondary,
		
        /// <summary>
        /// An area of wet, often spongy ground that is subject to frequent or tidal inundations, but not considered to be continually under water. It is characterized by the growth of non woody plants and by the lack of trees.
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("MARSH")]
        [EnumMember]
        Marsh,
		
        /// <summary>
        /// A place where shrubs, flowers, plants and trees are grown for transplanting, seed or grafting.
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("NURSRY")]
        [EnumMember]
        Nursery,
		
        /// <summary>
        /// A small, isolated, fertile or green area in a desert region usually having a spring or well.
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("OASIS")]
        [EnumMember]
        Oasis,
		
        /// <summary>
        /// An area covered by systematic plantings of trees which yield fruits, nuts or other products.
        /// </summary>
        [DomValIx(1000017)]
        [StringValue("ORCHRD")]
        [EnumMember]
        OrchardPlantation,
		
        /// <summary>
        /// A grassy plain in tropical and subtropical regions, with few trees.
        /// </summary>
        [DomValIx(1000018)]
        [StringValue("SAVNNH")]
        [EnumMember]
        Savannah,
		
        /// <summary>
        /// A characterisation of an area with low-growing woody plants.
        /// </summary>
        [DomValIx(1000019)]
        [StringValue("SCRUB")]
        [EnumMember]
        ScrubBrushBush,
		
        /// <summary>
        /// A low lying saturated area covered with water all or most of the year, where accumulating dead vegetation does not rapidly decay. It can exist on flat-lying areas created by certain geomorphic environments. The vegetation mainly consists of hydrophytic trees and/or scrubs whose roots are adapted to wet conditions, with an open to very dense canopy closure.
        /// </summary>
        [DomValIx(1000020)]
        [StringValue("SWAMP")]
        [EnumMember]
        Swamp,
		
        /// <summary>
        /// Woody-perennial plants, having a self-supporting main stem or trunk.
        /// </summary>
        [DomValIx(1000021)]
        [StringValue("TREES")]
        [EnumMember]
        Trees,
		
        /// <summary>
        /// A prairie-like region in the Arctic and Subarctic zones which sustains a growth of low vegetation.
        /// </summary>
        [DomValIx(1000022)]
        [StringValue("TUNDRA")]
        [EnumMember]
        Tundra,
		
        /// <summary>
        /// An area covered by the systematic planting of grape vines.
        /// </summary>
        [DomValIx(1000023)]
        [StringValue("VNEYRD")]
        [EnumMember]
        Vineyard,
		
    }
}
