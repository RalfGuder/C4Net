using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity GEOGRAPHIC-FEATURE-STATUS that represents the table GFEAT_STAT.
	///
	/// An OBJECT-ITEM-STATUS that is a record of condition of a specific GEOGRAPHIC-FEATURE.
    /// </summary>
    [Serializable]
    [DefinitionName("GeographicFeatureStatus", "C4Net.JC3IEDM.Definitions.GeographicFeatureStatus.definition.xml")]
    public class GeographicFeatureStatus : ObjectItemStatus, IGeographicFeatureStatus
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly GeographicFeatureStatusExpression _ = new GeographicFeatureStatusExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column gfeat_stat_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column gfeat_stat_id
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
		/// The specific value that represents the class of GEOGRAPHIC-FEATURE-STATUS. It serves as a discriminator that partitions GEOGRAPHIC-FEATURE-STATUS into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public GeographicFeatureStatusCategoryEnum GeographicFeatureStatusCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column mine_prsnc_code
		///
		/// The specific value that indicates whether a specific GEOGRAPHIC-FEATURE contains mines.
        /// </summary>
        /// <value>
        /// Value of the column mine_prsnc_code
        /// </value>
		public MinePresenceEnum? MinePresence { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column surf_recirc_ind_code
		///
		/// The specific value that indicates whether the surface will recirculate as a result of rotor downwash.
        /// </summary>
        /// <value>
        /// Value of the column surf_recirc_ind_code
        /// </value>
		public GeographicFeatureStatusSurfaceRecirculationIndicatorEnum? SurfaceRecirculationIndicator { get; set; }
		
        #endregion
    }
}
