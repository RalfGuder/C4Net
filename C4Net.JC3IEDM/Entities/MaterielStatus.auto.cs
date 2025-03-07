using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity MATERIEL-STATUS that represents the table MAT_STAT.
	///
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific MATERIEL.
    /// </summary>
    [Serializable]
    [DefinitionName("MaterielStatus", "C4Net.JC3IEDM.Definitions.MaterielStatus.definition.xml")]
    public class MaterielStatus : ObjectItemStatus, IMaterielStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly MaterielStatusExpression _ = new MaterielStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column mat_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column mat_stat_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_stat_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-STATUS for a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEM-STATUSs for that OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_stat_ix
        /// </value>
		public decimal ObjectItemStatusIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of MATERIEL-STATUS. It serves as a discriminator that partitions MATERIEL-STATUS into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public MaterielStatusCategoryEnum MaterielStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column body_colour_code
		///
		/// The specific value that represents the current colour scheme of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column body_colour_code
        /// </value>
		public MaterielStatusBodyColourEnum? BodyColour { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column marking_code
		///
		/// The specific value that represents the type of marking of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column marking_code
        /// </value>
		public MaterielStatusMarkingEnum? Marking { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column marking_colour_code
		///
		/// The specific value that represents the colour of the markings of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column marking_colour_code
        /// </value>
		public MaterielStatusMarkingColourEnum? MarkingColour { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dmltn_stat_code
		///
		/// The specific value that represents the status of a specific MATERIEL destined for demolition.
        /// </summary>
        /// <value>
        /// Value of the column dmltn_stat_code
        /// </value>
		public DemolitionStatusEnum? DemolitionStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column imo_compliant_ind_code
		///
		/// The specific value that indicates whether a vessel complies with International Maritime Organisation standards.
        /// </summary>
        /// <value>
        /// Value of the column imo_compliant_ind_code
        /// </value>
		public MaterielStatusImoCompliantIndicatorEnum? ImoCompliantIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_code
		///
		/// The specific value that represents the operational status of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_code
        /// </value>
		public MaterielStatusOperationalStatusEnum OperationalStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_qual_code
		///
		/// The specific value that represents the qualification of the operational status of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_qual_code
        /// </value>
		public MaterielStatusOperationalStatusQualifierEnum? OperationalStatusQualifier { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column operat_stat_mode_code
		///
		/// The specific value that represents the firepower or mobility or communications degradation of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column operat_stat_mode_code
        /// </value>
		public MaterielStatusOperationalStatusModeEnum? OperationalStatusMode { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column reserve_ind_code
		///
		/// The specific value that represents whether a specific MATERIEL has been placed in reserve.
        /// </summary>
        /// <value>
        /// Value of the column reserve_ind_code
        /// </value>
		public MaterielStatusReserveIndicatorEnum? ReserveIndicator { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column safety_stat_code
		///
		/// The specific value that represents the arming state of a specific MATERIEL that is a weapon or ammunition.
        /// </summary>
        /// <value>
        /// Value of the column safety_stat_code
        /// </value>
		public MaterielStatusSafetyStatusEnum? SafetyStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column usage_stat_code
		///
		/// The specific value that represents the usage of a specific MATERIEL.
        /// </summary>
        /// <value>
        /// Value of the column usage_stat_code
        /// </value>
		public UsageStatusEnum? UsageStatus { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column buoy_malf_code
		///
		/// The specific value that represents the type of malfunction of a buoy.
        /// </summary>
        /// <value>
        /// Value of the column buoy_malf_code
        /// </value>
		public MaterielStatusBuoyMalfunctionEnum? BuoyMalfunction { get; set; }
		
        #endregion
    }
}
