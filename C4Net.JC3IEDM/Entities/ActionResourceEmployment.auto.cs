using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ACTION-RESOURCE-EMPLOYMENT that represents the table ACT_RES_EMPLOY.
	///
	/// The procedure for using a specific ACTION-RESOURCE with or without dependence upon a specific ACTION-OBJECTIVE.
    /// </summary>
    [Serializable]
    [DefinitionName("ActionResourceEmployment", "C4Net.JC3IEDM.Definitions.ActionResourceEmployment.definition.xml")]
    public class ActionResourceEmployment : IEntity, IActionResourceEmployment
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly ActionResourceEmploymentExpression _ = new ActionResourceEmploymentExpression();

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
        /// Gets or sets the value of the column act_res_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-RESOURCE for a specific ACTION and to distinguish it from all other ACTION-RESOURCEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_res_ix
        /// </value>
		public decimal ActionResourceIndex { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_res_employ_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-RESOURCE-EMPLOYMENT for a specific ACTION-RESOURCE and to distinguish it from all other ACTION-RESOURCE-EMPLOYMENTs for that ACTION-RESOURCE.
        /// </summary>
        /// <value>
        /// Value of the column act_res_employ_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column cat_code
		///
		/// The specific value that represents the class of ACTION-RESOURCE-EMPLOYMENT. It serves as a discriminator that partitions ACTION-RESOURCE-EMPLOYMENT into subtypes.
        /// </summary>
        /// <value>
        /// Value of the column cat_code
        /// </value>
		public ActionResourceEmploymentCategoryEnum ActionResourceEmploymentCategory { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column azimuth_fire_angle
		///
		/// The rotational measurement clockwise from the line of true North specifying the direction of fire for the ACTION-RESOURCE.
        /// </summary>
        /// <value>
        /// Value of the column azimuth_fire_angle
        /// </value>
		public double? AzimuthFireAngle { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column method_of_ctrl_code
		///
		/// The specific value that represents the standard procedure to be used in controlling the employment of a specific ACTION-RESOURCE in support of a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column method_of_ctrl_code
        /// </value>
		public ActionResourceEmploymentMethodOfControlEnum? MethodOfControl { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column trajectory_fire_code
		///
		/// The specific value that represents the type of trajectory to be used in firing of a specific ACTION-RESOURCE in support of a specific ACTION.
        /// </summary>
        /// <value>
        /// Value of the column trajectory_fire_code
        /// </value>
		public ActionResourceEmploymentTrajectoryFireEnum? TrajectoryFire { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column act_objve_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific ACTION-OBJECTIVE for a specific ACTION and to distinguish it from all other ACTION-OBJECTIVEs for that ACTION.
        /// </summary>
        /// <value>
        /// Value of the column act_objve_ix
        /// </value>
		public decimal? ActionObjectiveIndex { get; set; }
		
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
