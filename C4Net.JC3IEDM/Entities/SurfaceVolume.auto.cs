using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity SURFACE-VOLUME that represents the table SURF_VOL.
	///
	/// A GEOMETRIC-VOLUME that has its horizontal boundaries defined by a specific SURFACE.
    /// </summary>
    [Serializable]
    [DefinitionName("SurfaceVolume", "C4Net.JC3IEDM.Definitions.SurfaceVolume.definition.xml")]
    public class SurfaceVolume : GeometricVolume, ISurfaceVolume
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly SurfaceVolumeExpression _ = new SurfaceVolumeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column surf_vol_dfng_surf_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column surf_vol_dfng_surf_id
        /// </value>
		public decimal DefiningSurfaceId { get; set; }
		
        #endregion
    }
}
