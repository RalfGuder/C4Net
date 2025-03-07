using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity GEOGRAPHIC-FEATURE that represents the table GEO_FEAT.
	///
	/// A FEATURE describing terrain characteristics to which military significance is attached.
    /// </summary>
    [Serializable]
    [DefinitionName("GeographicFeature", "C4Net.JC3IEDM.Definitions.GeographicFeature.definition.xml")]
    public class GeographicFeature : Feature, IGeographicFeature
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly GeographicFeatureExpression _ = new GeographicFeatureExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column btm_hardness_code
		///
		/// A specific value that represents the subjective indication obtained by a diver of the hardness of the liquid/solid surface interface and is the result of a single arm thrust.
        /// </summary>
        /// <value>
        /// Value of the column btm_hardness_code
        /// </value>
		public GeographicFeatureBottomHardnessEnum? BottomHardness { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column btm_penetration_qty
		///
		/// The numeric value that represents the depth to which a diver is able to thrust his fist or fingers into the surface of the solid/liquid interface. The unit of measure is metres.
        /// </summary>
        /// <value>
        /// Value of the column btm_penetration_qty
        /// </value>
		public double? BottomPenetrationQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sld_surf_cmps_code
		///
		/// The specific value that represents the composition of the surface of the GEOGRAPHIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column sld_surf_cmps_code
        /// </value>
		public GeographicFeatureSolidSurfaceCompositionEnum? SolidSurfaceComposition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_cat_code
		///
		/// The specific value that represents the type of surface of the GEOGRAPHIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column surf_cat_code
        /// </value>
		public GeographicFeatureSurfaceCategoryEnum? SurfaceCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column trn_code
		///
		/// The specific value that represents a tract of land.
        /// </summary>
        /// <value>
        /// Value of the column trn_code
        /// </value>
		public GeographicFeatureTerrainEnum? Terrain { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column veg_cat_code
		///
		/// The specific value that represents the general vegetation class on a specific GEOGRAPHIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column veg_cat_code
        /// </value>
		public VegetationCategoryEnum? VegetationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column veg_subcat_code
		///
		/// The specific value that represents the detailed vegetation class on a specific GEOGRAPHIC-FEATURE.
        /// </summary>
        /// <value>
        /// Value of the column veg_subcat_code
        /// </value>
		public VegetationSubcategoryEnum? VegetationSubcategory { get; set; }
		
        #endregion
    }
}
