using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MATERIEL-TYPE that represents the table MAT_TYPE.
	///
	/// An OBJECT-TYPE that represents equipment, apparatus or supplies of military interest without distinction to its application for administrative or combat purposes.
    /// </summary>
    [Serializable]
    [DefinitionName("MaterielType", "C4Net.JC3IEDM.Definitions.MaterielType.definition.xml")]
    public class MaterielType : ObjectType, IMaterielType
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MaterielTypeExpression _ = new MaterielTypeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MATERIEL-TYPE. It serves as a discriminator that partitions MATERIEL-TYPE into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MaterielTypeCategoryEnum MaterielTypeCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptbl_item_txt
		///
		/// The character string assigned to represent a specific MATERIEL-TYPE, selected from the Reportable Item Code list issued by NATO.
        /// </summary>
        /// <value>
        /// Value of the column rptbl_item_txt
        /// </value>
		public string ReportableItemText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column stock_no_txt
		///
		/// The character string assigned to represent a specific MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column stock_no_txt
        /// </value>
		public string StockNumberText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column supply_class_code
		///
		/// The specific value that represents the NATO supply class of MATERIEL-TYPE.
        /// </summary>
        /// <value>
        /// Value of the column supply_class_code
        /// </value>
		public MaterielTypeSupplyClassEnum? SupplyClass { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_height_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured perpendicular to the base plane of the specific MATERIEL-TYPE when it is prepared for shipment or storage.
        /// </summary>
        /// <value>
        /// Value of the column issuing_height_dim
        /// </value>
		public double? IssuingHeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_length_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured from end to end and parallel to the central axis of specific MATERIEL-TYPE when it is prepared for shipment or storage.
        /// </summary>
        /// <value>
        /// Value of the column issuing_length_dim
        /// </value>
		public double? IssuingLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column issuing_width_dim
		///
		/// The one-dimensional linear distance representing the maximum distance measured from side to side and perpendicular to the central axis of a specific MATERIEL-TYPE when it is prepared for shipment or storage.
        /// </summary>
        /// <value>
        /// Value of the column issuing_width_dim
        /// </value>
		public double? IssuingWidthDimension { get; set; }
		
        #endregion
    }
}
