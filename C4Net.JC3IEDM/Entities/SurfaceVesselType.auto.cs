using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity SURFACE-VESSEL-TYPE that represents the table SURF_VESSEL_TYPE.
	///
	/// A vessel principally designed to operate on the water surface.
    /// </summary>
    [Serializable]
    [DefinitionName("SurfaceVesselType", "C4Net.JC3IEDM.Definitions.SurfaceVesselType.definition.xml")]
    public class SurfaceVesselType : VesselType, ISurfaceVesselType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly SurfaceVesselTypeExpression _ = new SurfaceVesselTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of surface vessel.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public SurfaceVesselTypeCategoryEnum SurfaceVesselTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column displ_qty
		///
		/// The numeric value that represents the maximum volume of water moved by the vessel when it is fully loaded. The unit of measure is cubic metre.
        /// </summary>
        /// <value>
        /// Value of the column displ_qty
        /// </value>
		public int? DisplacementQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column max_deck_load_qty
		///
		/// The numeric value that represents the Ship's maximum allowable deck load. The unit of measure is kilogram.
        /// </summary>
        /// <value>
        /// Value of the column max_deck_load_qty
        /// </value>
		public int? MaximumDeckLoadQuantity { get; set; }
		
        #endregion
    }
}
