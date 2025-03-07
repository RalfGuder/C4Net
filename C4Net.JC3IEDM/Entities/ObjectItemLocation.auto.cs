using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity OBJECT-ITEM-LOCATION that represents the table OBJ_ITEM_LOC.
	///
	/// An association of an OBJECT-ITEM with a LOCATION that enables the geographic position of the OBJECT-ITEM to be specified. The operational meaning of geometry may also be specified.
    /// </summary>
    [Serializable]
    [DefinitionName("ObjectItemLocation", "C4Net.JC3IEDM.Definitions.ObjectItemLocation.definition.xml")]
    public class ObjectItemLocation : IEntity, IObjectItemLocation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ObjectItemLocationExpression _ = new ObjectItemLocationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_id
        /// </value>
		public decimal ObjectItemId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column loc_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column loc_id
        /// </value>
		public decimal LocationId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column obj_item_loc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM-LOCATION for a specific OBJECT-ITEM and a specific LOCATION and to distinguish it from all other OBJECT-ITEM-LOCATIONs for that OBJECT-ITEM and that LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column obj_item_loc_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ver_acc_dim
		///
		/// The one-dimensional linear distance representing the uncertainty in terms of probable error range for the vertical axis of a specific OBJECT-ITEM-LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column ver_acc_dim
        /// </value>
		public double? VerticalAccuracyDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column horz_acc_dim
		///
		/// The one-dimensional linear distance representing the uncertainty in the horizontal plane in terms of probable circular error for a specific OBJECT-ITEM-LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column horz_acc_dim
        /// </value>
		public double? HorizontalAccuracyDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column brng_angle
		///
		/// The rotational measurement clockwise from the line of true North to the direction of motion in the horizontal plane of a specific OBJECT-ITEM at a specific LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column brng_angle
        /// </value>
		public double? BearingAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column brng_acc_angle
		///
		/// The rotational measurement of a sector that represents the uncertainty range in the estimate of the bearing at a specific OBJECT-ITEM-LOCATION. The sector is bisected by the bearing.
        /// </summary>
        /// <value>
        /// Value of the column brng_acc_angle
        /// </value>
		public double? BearingAccuracyAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column brng_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of a bearing angle.
        /// </summary>
        /// <value>
        /// Value of the column brng_precision_code
        /// </value>
		public AnglePrecisionEnum? BearingPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column incl_angle
		///
		/// The rotational measurement from the horizontal plane to the direction of motion of a specific OBJECT-ITEM at a specific LOCATION (point or shape), where the positive angle is vertically upward.
        /// </summary>
        /// <value>
        /// Value of the column incl_angle
        /// </value>
		public double? InclinationAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column incl_acc_angle
		///
		/// The rotational measurement of a vertical sector that represents the uncertainty range in the estimate of the inclination at a specific OBJECT-ITEM-LOCATION. The sector is bisected by the inclination.
        /// </summary>
        /// <value>
        /// Value of the column incl_acc_angle
        /// </value>
		public double? InclinationAccuracyAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column incl_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of an inclination angle.
        /// </summary>
        /// <value>
        /// Value of the column incl_precision_code
        /// </value>
		public AnglePrecisionEnum? InclinationPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column speed_rate
		///
		/// The numeric value that denotes the motion of a specific OBJECT-ITEM at a specific LOCATION in terms of distance per unit time. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column speed_rate
        /// </value>
		public double? SpeedRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column speed_acc_rate
		///
		/// The numeric value that denotes the uncertainty range in the estimate for the speed at a specific OBJECT-ITEM-LOCATION where the speed estimate falls at the centre of the accuracy range. The unit of measure is kilometres per hour. The specified value must be greater than or equal to 0 (zero).
        /// </summary>
        /// <value>
        /// Value of the column speed_acc_rate
        /// </value>
		public double? SpeedAccuracyRate { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column speed_precision_code
		///
		/// The specific value that represents the maximum resolution used for the expression of speed.
        /// </summary>
        /// <value>
        /// Value of the column speed_precision_code
        /// </value>
		public SpeedPrecisionEnum? SpeedPrecision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column meaning_code
		///
		/// The specific value that represents the meaning of the LOCATION geometry as it pertains to the OBJECT-ITEM.
        /// </summary>
        /// <value>
        /// Value of the column meaning_code
        /// </value>
		public ObjectItemLocationMeaningEnum? Meaning { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rel_speed_code
		///
		/// The specific value that represents the speed of the object relative to its normal speed.
        /// </summary>
        /// <value>
        /// Value of the column rel_speed_code
        /// </value>
		public ObjectItemLocationRelativeSpeedEnum? RelativeSpeed { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal ReportingDataId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column creator_id
		///
		/// A value assigned to the row to identify the organisation which created that row. This is referenced by an application level business rule to an OBJ_ITEM entry with a cat_code = OR and to a corresponding ORG subtype entry.
        /// </summary>
        /// <value>
        /// Value of the column creator_id
        /// </value>
		public decimal CreatorId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column update_seqnr
		///
		/// An absolute sequence number, assigned to represent the validity (in terms of seniority) of a certain data item.
        /// </summary>
        /// <value>
        /// Value of the column update_seqnr
        /// </value>
		public long UpdateSeqnr { get; set; }
		
        #endregion
    }
}
