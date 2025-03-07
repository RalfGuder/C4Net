using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity GEOMETRIC-VOLUME that represents the table GEOM_VOL.
	///
	/// A specific LOCATION that is a three-dimensional bounded space.
    /// </summary>
    [Serializable]
    [DefinitionName("GeometricVolume", "C4Net.JC3IEDM.Definitions.GeometricVolume.definition.xml")]
    public class GeometricVolume : Location, IGeometricVolume
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly GeometricVolumeExpression _ = new GeometricVolumeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of GEOMETRIC-VOLUME. It serves as a discriminator that partitions GEOMETRIC-VOLUME into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public GeometricVolumeCategoryEnum GeometricVolumeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column geom_vol_lower_ver_dist_id
		///
		/// The unique value, or set of characters, assigned to represent a specific VERTICAL-DISTANCE and to distinguish it from all other VERTICAL-DISTANCEs.
        /// </summary>
        /// <value>
        /// Value of the column geom_vol_lower_ver_dist_id
        /// </value>
		public decimal? LowerVerticalDistanceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column geom_vol_upper_ver_dist_id
		///
		/// The unique value, or set of characters, assigned to represent a specific VERTICAL-DISTANCE and to distinguish it from all other VERTICAL-DISTANCEs.
        /// </summary>
        /// <value>
        /// Value of the column geom_vol_upper_ver_dist_id
        /// </value>
		public decimal? UpperVerticalDistanceId { get; set; }
		
        #endregion
    }
}
