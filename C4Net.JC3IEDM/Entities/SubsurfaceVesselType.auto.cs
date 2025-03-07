using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity SUBSURFACE-VESSEL-TYPE that represents the table SUBSURF_VESSEL_TYPE.
	///
	/// A vessel principally designed to operate under the water surface.
    /// </summary>
    [Serializable]
    [DefinitionName("SubsurfaceVesselType", "C4Net.JC3IEDM.Definitions.SubsurfaceVesselType.definition.xml")]
    public class SubsurfaceVesselType : VesselType, ISubsurfaceVesselType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly SubsurfaceVesselTypeExpression _ = new SubsurfaceVesselTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of subsurface vessel.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public SubsurfaceVesselTypeCategoryEnum SubsurfaceVesselTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dived_displ_qty
		///
		/// The numeric value that represents the volume of water that is moved by the subsurface vessel when it is entirely below the surface. The unit of measure is ton.
        /// </summary>
        /// <value>
        /// Value of the column dived_displ_qty
        /// </value>
		public int? DivedDisplacementQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column speed_cavitation_qty
		///
		/// The numeric value that represents the speed at which the subsurface vessel will form bubbles or a vacuum in the water. The unit of measure is knots.
        /// </summary>
        /// <value>
        /// Value of the column speed_cavitation_qty
        /// </value>
		public short? SpeedCavitationQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column torpedo_loading_gear_ind_code
		///
		/// The specific value that indicates whether a subsurface vessel has torpedo loading rails and lifting bands.
        /// </summary>
        /// <value>
        /// Value of the column torpedo_loading_gear_ind_code
        /// </value>
		public SubsurfaceVesselTypeTorpedoLoadingGearIndicatorEnum? TorpedoLoadingGearIndicator { get; set; }
		
        #endregion
    }
}
