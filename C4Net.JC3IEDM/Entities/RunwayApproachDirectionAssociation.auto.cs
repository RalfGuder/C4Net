using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity RUNWAY-APPROACH-DIRECTION-ASSOCIATION that represents the table RUNWAY_APPR_DIR_ASSOC.
	///
	/// A relationship of a subject RUNWAY with an object APPROACH-DIRECTION.
    /// </summary>
    [Serializable]
    [DefinitionName("RunwayApproachDirectionAssociation", "C4Net.JC3IEDM.Definitions.RunwayApproachDirectionAssociation.definition.xml")]
    public class RunwayApproachDirectionAssociation : IEntity, IRunwayApproachDirectionAssociation
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly RunwayApproachDirectionAssociationExpression _ = new RunwayApproachDirectionAssociationExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column runway_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column runway_id
        /// </value>
		public decimal RunwayId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column appr_dir_id
		///
		/// The unique value, or set of characters, assigned to represent a specific OBJECT-ITEM and to distinguish it from all other OBJECT-ITEMs.
        /// </summary>
        /// <value>
        /// Value of the column appr_dir_id
        /// </value>
		public decimal ApproachDirectionId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column slope_rat
		///
		/// The numeric quotient value that represents the incline of the runway seen from the direction of the APPROACH-DIRECTION as proportion of vertical change with respect to the length of the runway. The value must be in the range from -.09 to +.09. Note: A negative value indicates a downward slope.
        /// </summary>
        /// <value>
        /// Value of the column slope_rat
        /// </value>
		public double? SlopeRatio { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column lndg_dist_dim
		///
		/// The one-dimensional linear distance representing the length of the runway that is declared available and suitable for the ground run of an aircraft landing. The unit of measurement is feet.
        /// </summary>
        /// <value>
        /// Value of the column lndg_dist_dim
        /// </value>
		public double? LandingDistanceDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column takeoff_dist_dim
		///
		/// The one-dimensional linear distance representing the length of the available takeoff run plus the length of the overrun, if available, for an aircraft to takeoff. The unit of measurement is feet.
        /// </summary>
        /// <value>
        /// Value of the column takeoff_dist_dim
        /// </value>
		public double? TakeoffDistanceDimension { get; set; }
		
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
