using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity CONE-VOLUME that represents the table CONE_VOL.
	///
	/// A GEOMETRIC-VOLUME whose boundary is swept by a line that has a fixed point and another that moves along the path defined by the border of a specific SURFACE.
    /// </summary>
    [Serializable]
    [DefinitionName("ConeVolume", "C4Net.JC3IEDM.Definitions.ConeVolume.definition.xml")]
    public class ConeVolume : GeometricVolume, IConeVolume
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly ConeVolumeExpression _ = new ConeVolumeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cone_vol_dfng_surf_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column cone_vol_dfng_surf_id
        /// </value>
		public decimal DefiningSurfaceId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column vertex_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column vertex_point_id
        /// </value>
		public decimal VertexPointId { get; set; }
		
        #endregion
    }
}
