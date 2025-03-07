using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity RAILCAR-TYPE that represents the table RAILCAR_TYPE.
	///
	/// An EQUIPMENT-TYPE that is designed to operate on rail tracks.
    /// </summary>
    [Serializable]
    [DefinitionName("RailcarType", "C4Net.JC3IEDM.Definitions.RailcarType.definition.xml")]
    public class RailcarType : EquipmentType, IRailcarType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly RailcarTypeExpression _ = new RailcarTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of RAILCAR-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public RailcarTypeCategoryEnum RailcarTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column subcat_code
		///
		/// The specific value that represents the detailed class of RAILCAR-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column subcat_code
        /// </value>
		public RailcarTypeSubcategoryEnum? Subcategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column gauge_dim
		///
		/// The one-dimensional linear distance representing the horizontal distance measured from side to side and perpendicular to the central axis of a specific railcar track.
        /// </summary>
        /// <value>
        /// Value of the column gauge_dim
        /// </value>
		public double? GaugeDimension { get; set; }
		
        #endregion
    }
}
