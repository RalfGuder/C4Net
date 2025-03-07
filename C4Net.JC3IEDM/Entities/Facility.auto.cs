using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity FACILITY that represents the table FAC.
	///
	/// An OBJECT-ITEM that is built, installed or established to serve some particular purpose and is identified by the service it provides rather than by its content.
    /// </summary>
    [Serializable]
    [DefinitionName("Facility", "C4Net.JC3IEDM.Definitions.Facility.definition.xml")]
    public class Facility : ObjectItem, IFacility
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly FacilityExpression _ = new FacilityExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of FACILITY. It serves as a discriminator that partitions FACILITY into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public FacilityCategoryEnum FacilityCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column prim_const_matrl_code
		///
		/// The specific value that represents the major material used in building the specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column prim_const_matrl_code
        /// </value>
		public FacilityPrimaryConstructionMaterialEnum? PrimaryConstructionMaterial { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column base_identific_code_txt
		///
		/// The character string assigned to represent a designation of the common additional reference given to a specific military base/facility.
        /// </summary>
        /// <value>
        /// Value of the column base_identific_code_txt
        /// </value>
		public string BaseIdentificationCodeText { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column height_dim
		///
		/// The one-dimensional linear distance representing the height of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column height_dim
        /// </value>
		public double? HeightDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column length_dim
		///
		/// The one-dimensional linear distance representing the length of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column length_dim
        /// </value>
		public double? LengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column width_dim
		///
		/// The one-dimensional linear distance representing the width of a specific FACILITY.
        /// </summary>
        /// <value>
        /// Value of the column width_dim
        /// </value>
		public double? WidthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column fac_major_building_type_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-TYPE and to distinguish it from all other OBJECT-TYPEs.
        /// </summary>
        /// <value>
        /// Value of the column fac_major_building_type_id
        /// </value>
		public decimal? MajorBuildingTypeId { get; set; }
		
        #endregion
    }
}
