using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MINEFIELD-LAND that represents the table MNFLD_LAND.
	///
	/// A MINEFIELD that is an area of land containing mines.
    /// </summary>
    [Serializable]
    [DefinitionName("MinefieldLand", "C4Net.JC3IEDM.Definitions.MinefieldLand.definition.xml")]
    public class MinefieldLand : Minefield, IMinefieldLand
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MinefieldLandExpression _ = new MinefieldLandExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column depth_plcmnt_code
		///
		/// The specific value that indicates the placement of mines with respect to the surface.
        /// </summary>
        /// <value>
        /// Value of the column depth_plcmnt_code
        /// </value>
		public MinefieldLandDepthPlacementEnum? DepthPlacement { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column func_code
		///
		/// The specific value that represents the intended function of the specific MINEFIELD-LAND.
        /// </summary>
        /// <value>
        /// Value of the column func_code
        /// </value>
		public MinefieldLandFunctionEnum? Function { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column pattern_code
		///
		/// The specific value that represents the pattern of a specific MINEFIELD-LAND.
        /// </summary>
        /// <value>
        /// Value of the column pattern_code
        /// </value>
		public MinefieldLandPatternEnum? Pattern { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column persistence_code
		///
		/// The specific value that represents the option for terminating the effectiveness of a specific MINEFIELD-LAND.
        /// </summary>
        /// <value>
        /// Value of the column persistence_code
        /// </value>
		public MinefieldLandPersistenceEnum? Persistence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column stopping_power_code
		///
		/// The specific value that represents the stopping power of a particular MINEFIELD-LAND.
        /// </summary>
        /// <value>
        /// Value of the column stopping_power_code
        /// </value>
		public MinefieldLandStoppingPowerEnum? StoppingPower { get; set; }
		
        #endregion
    }
}
