using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity SURFACE that represents the table SURF.
	///
	/// A two-dimensional LOCATION.
    /// </summary>
    [Serializable]
    [DefinitionName("Surface", "C4Net.JC3IEDM.Definitions.Surface.definition.xml")]
    public class Surface : Location, ISurface
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly SurfaceExpression _ = new SurfaceExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of SURFACE. It serves as a discriminator that partitions SURFACE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public SurfaceCategoryEnum SurfaceCategory { get; set; }
		
        #endregion
    }
}
