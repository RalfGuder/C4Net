using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity LINE-POINT that represents the table LINE_POINT.
	///
	/// A specification of one of an ordered sequence of POINTs used to define the specific LINE.
    /// </summary>
    [Serializable]
    [DefinitionName("LinePoint", "C4Net.JC3IEDM.Definitions.LinePoint.definition.xml")]
    public class LinePoint : IEntity, ILinePoint
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly LinePointExpression _ = new LinePointExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column line_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column line_id
        /// </value>
		public decimal LineId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column line_point_ix
		///
		/// The unique value, or set of characters, assigned to represent a specific LINE-POINT for a specific LINE and to distinguish it from all other LINE-POINTs for that LINE.
        /// </summary>
        /// <value>
        /// Value of the column line_point_ix
        /// </value>
		public decimal Index { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column seq_ord
		///
		/// The integer value that indicates the relative order of a LINE-POINT among the set of LINE-POINTs associated with a specific LINE.
        /// </summary>
        /// <value>
        /// Value of the column seq_ord
        /// </value>
		public int SequenceOrdinal { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column point_id
        /// </value>
		public decimal PointId { get; set; }
		
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
