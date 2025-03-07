using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity VERTICAL-DISTANCE that represents the table VER_DIST.
	///
	/// A specification of the altitude or height of a point or a level as measured with respect to a specified reference datum in the direction normal to the plane that is tangent to the WGS84 ellipsoid of revolution.
    /// </summary>
    [Serializable]
    [DefinitionName("VerticalDistance", "C4Net.JC3IEDM.Definitions.VerticalDistance.definition.xml")]
    public class VerticalDistance : IEntity, IVerticalDistance
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly VerticalDistanceExpression _ = new VerticalDistanceExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column ver_dist_id
		///
		/// The unique value, or set of characters, assigned to represent a specific VERTICAL-DISTANCE and to distinguish it from all other VERTICAL-DISTANCEs.
        /// </summary>
        /// <value>
        /// Value of the column ver_dist_id
        /// </value>
		public decimal Id { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ref_code
		///
		/// The specific value that represents the reference system for a specific VERTICAL-DISTANCE.
        /// </summary>
        /// <value>
        /// Value of the column ref_code
        /// </value>
		public VerticalDistanceReferenceEnum Reference { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column dim
		///
		/// The one-dimensional linear distance representing the distance with respect to the specified vertical datum.
        /// </summary>
        /// <value>
        /// Value of the column dim
        /// </value>
		public double Dimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column precision_code
		///
		/// The specific value that denotes the precision of specifying a VERTICAL-DISTANCE.
        /// </summary>
        /// <value>
        /// Value of the column precision_code
        /// </value>
		public DistancePrecisionEnum? Precision { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column datum_txt
		///
		/// The character string assigned to represent a specific vertical reference datum.
        /// </summary>
        /// <value>
        /// Value of the column datum_txt
        /// </value>
		public string DatumText { get; set; }
		
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
