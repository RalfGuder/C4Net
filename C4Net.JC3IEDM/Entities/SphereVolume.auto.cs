using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity SPHERE-VOLUME that represents the table SPHERE_VOL.
	///
	/// A GEOMETRIC-VOLUME that has its horizontal boundaries defined by the spherical surface determined by the radius and the specified POINT.
    /// </summary>
    [Serializable]
    [DefinitionName("SphereVolume", "C4Net.JC3IEDM.Definitions.SphereVolume.definition.xml")]
    public class SphereVolume : GeometricVolume, ISphereVolume
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly SphereVolumeExpression _ = new SphereVolumeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column radius_dim
		///
		/// The one-dimensional linear distance representing the radius from the centre that defines the surface for a specific SPHERE-VOLUME.
        /// </summary>
        /// <value>
        /// Value of the column radius_dim
        /// </value>
		public double RadiusDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column sphere_vol_centre_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column sphere_vol_centre_point_id
        /// </value>
		public decimal CentrePointId { get; set; }
		
        #endregion
    }
}
