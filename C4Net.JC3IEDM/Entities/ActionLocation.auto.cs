using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-LOCATION that represents the table ACT_LOC.
	///
	/// An association of an ACTION with a LOCATION that enables the geographic position of the ACTION to be specified.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionLocation", "C4Net.JC3IEDM.Definitions.ActionLocation.definition.xml")]
    public class ActionLocation : IEntity, IActionLocation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionLocationExpression _ = new ActionLocationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column act_id
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION and to distinguish it from all other ACTIONs.
        /// </summary>
        /// <value>
        /// Value of the column act_id
        /// </value>
		public decimal ActionId { get; set; }
		
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
        /// Gets or sets the value of the column act_loc_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-LOCATION for a specific ACTION and a specific LOCATION and to distinguish it from all other ACTION-LOCATIONs for that ACTION and that LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column act_loc_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column acc_dim
		///
		/// The one-dimensional linear distance representing the uncertainty in the estimate of a specific ACTION-LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column acc_dim
        /// </value>
		public double? AccuracyDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column brng_angle
		///
		/// The rotational measurement clockwise from true North to the right side of a horizontal conical section used in defining a specific ACTION-LOCATION.
        /// </summary>
        /// <value>
        /// Value of the column brng_angle
        /// </value>
		public double? BearingAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column rptd_id
		///
		/// The unique value, or set of characters, assigned to represent a specific REPORTING-DATA and to distinguish it from all other REPORTING-DATAs.
        /// </summary>
        /// <value>
        /// Value of the column rptd_id
        /// </value>
		public decimal? ReportingDataId { get; set; }
		
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
