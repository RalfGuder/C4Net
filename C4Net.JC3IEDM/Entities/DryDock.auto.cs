using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity DRY-DOCK that represents the table DRY_DOCK.
	///
	/// A FACILITY that provides an enclosure for maintenance, building or repairing ships, from which water can be pumped out.
    /// </summary>
    [Serializable]
    [DefinitionName("DryDock", "C4Net.JC3IEDM.Definitions.DryDock.definition.xml")]
    public class DryDock : Facility, IDryDock
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly DryDockExpression _ = new DryDockExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column boat_lift_cap_qty
		///
		/// The numeric value that represents the maximum tonnage of a boat-lift that can be utilised to remove a vessel from a specific DRY-DOCK. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column boat_lift_cap_qty
        /// </value>
		public int? BoatLiftCapacityQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column depth_dim
		///
		/// The one-dimensional linear distance representing the depth of water available at the DRY-DOCK when the dock is full of water.
        /// </summary>
        /// <value>
        /// Value of the column depth_dim
        /// </value>
		public double? DepthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loc_txt
		///
		/// The character string assigned to represent a statement of the details that relate to the specific DRY-DOCK.
        /// </summary>
        /// <value>
        /// Value of the column loc_txt
        /// </value>
		public string LocationText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column marine_railway_size_code
		///
		/// The specific value that represents the bearing capacity of the underwater railway in the DRY-DOCK.
        /// </summary>
        /// <value>
        /// Value of the column marine_railway_size_code
        /// </value>
		public DryDockMarineRailwaySizeEnum? MarineRailwaySize { get; set; }
		
        #endregion
    }
}
