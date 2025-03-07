using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity SOLID-SURFACE-STATUS that represents the table SLD_SURF_STAT.
	///
	/// A GEOGRAPHIC-FEATURE-STATUS that is a record of condition of a specific solid surface.
    /// </summary>
    [Serializable]
    [DefinitionName("SolidSurfaceStatus", "C4Net.JC3IEDM.Definitions.SolidSurfaceStatus.definition.xml")]
    public class SolidSurfaceStatus : GeographicFeatureStatus, ISolidSurfaceStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly SolidSurfaceStatusExpression _ = new SolidSurfaceStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column code
		///
		/// The specific value that represents the status of a specific solid surface.
        /// </summary>
        /// <value>
        /// Value of the column code
        /// </value>
		public SolidSurfaceStatusEnum SolidSurfaceStatusCode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dmltn_stat_code
		///
		/// The specific value that represents the status of an object destined for demolition.
        /// </summary>
        /// <value>
        /// Value of the column dmltn_stat_code
        /// </value>
		public DemolitionStatusEnum? DemolitionStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_cond_code
		///
		/// The specific value that represents the physical status of a solid surface area.
        /// </summary>
        /// <value>
        /// Value of the column surf_cond_code
        /// </value>
		public SolidSurfaceStatusSurfaceConditionEnum? SurfaceCondition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_firm_code
		///
		/// The specific value that represents the firmness of a surface area, in terms of its ability to support land vehicles or helicopters.
        /// </summary>
        /// <value>
        /// Value of the column surf_firm_code
        /// </value>
		public SolidSurfaceStatusSurfaceFirmnessEnum? SurfaceFirmness { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column veg_cat_code
		///
		/// The specific value that represents the general vegetation class of a specific SOLID-SURFACE-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column veg_cat_code
        /// </value>
		public VegetationCategoryEnum? VegetationCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column veg_subcat_code
		///
		/// The specific value that represents the detailed vegetation class of a specific SOLID-SURFACE-STATUS.
        /// </summary>
        /// <value>
        /// Value of the column veg_subcat_code
        /// </value>
		public VegetationSubcategoryEnum? VegetationSubcategory { get; set; }
		
        #endregion
    }
}
