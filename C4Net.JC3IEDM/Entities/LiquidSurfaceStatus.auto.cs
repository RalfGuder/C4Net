using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity LIQUID-SURFACE-STATUS that represents the table LQD_SURF_STAT.
	///
	/// A GEOGRAPHIC-FEATURE-STATUS that is a record of condition of a specific liquid surface.
    /// </summary>
    [Serializable]
    [DefinitionName("LiquidSurfaceStatus", "C4Net.JC3IEDM.Definitions.LiquidSurfaceStatus.definition.xml")]
    public class LiquidSurfaceStatus : GeographicFeatureStatus, ILiquidSurfaceStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly LiquidSurfaceStatusExpression _ = new LiquidSurfaceStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column sea_state_code
		///
		/// The specific value that represents a range of wave heights on a specific liquid surface.
        /// </summary>
        /// <value>
        /// Value of the column sea_state_code
        /// </value>
		public LiquidSurfaceStatusSeaStateEnum? SeaState { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_cond_code
		///
		/// The specific value that represents the physical status of a liquid surface area.
        /// </summary>
        /// <value>
        /// Value of the column surf_cond_code
        /// </value>
		public LiquidSurfaceStatusSurfaceConditionEnum? SurfaceCondition { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column wave_dir_code
		///
		/// The specific value that represents the direction of waves in a specific liquid surface.
        /// </summary>
        /// <value>
        /// Value of the column wave_dir_code
        /// </value>
		public DirectionEnum? WaveDirection { get; set; }
		
        #endregion
    }
}
