using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity BASIN that represents the table BASIN.
	///
	/// A FACILITY that is an open area of water, usually artificial and enclosed by dock gates lined with wharves, warehouses and berths to enable vessels to load and unload.
    /// </summary>
    [Serializable]
    [DefinitionName("Basin", "C4Net.JC3IEDM.Definitions.Basin.definition.xml")]
    public class Basin : Facility, IBasin
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly BasinExpression _ = new BasinExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ddw_tong_qty
		///
		/// The numeric value that represents the maximum deadweight tonnage that can be accommodated for a vessel at the specific BASIN. The unit of measure is metric ton.
        /// </summary>
        /// <value>
        /// Value of the column ddw_tong_qty
        /// </value>
		public int? DeadweightTonnageQuantity { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column depth_dim
		///
		/// The one-dimensional linear distance representing the depth of water available at the BASIN at low tide.
        /// </summary>
        /// <value>
        /// Value of the column depth_dim
        /// </value>
		public double? DepthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loc_txt
		///
		/// The character string assigned to represent a statement of the details that relate to the specific BASIN.
        /// </summary>
        /// <value>
        /// Value of the column loc_txt
        /// </value>
		public string LocationText { get; set; }
		
        #endregion
    }
}
