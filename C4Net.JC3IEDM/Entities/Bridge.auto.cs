using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity BRIDGE that represents the table BRIDGE.
	///
	/// A FACILITY that is a structure (including overpass and viaduct), fixed or moveable, spanning and/or providing passage over an object.
    /// </summary>
    [Serializable]
    [DefinitionName("Bridge", "C4Net.JC3IEDM.Definitions.Bridge.definition.xml")]
    public class Bridge : Facility, IBridge
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly BridgeExpression _ = new BridgeExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column longest_span_length_dim
		///
		/// The one-dimensional linear distance representing the longest span´s length in a specific BRIDGE.
        /// </summary>
        /// <value>
        /// Value of the column longest_span_length_dim
        /// </value>
		public double? LongestSpanLengthDimension { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column span_cnt
		///
		/// The integer value representing the number of sections that a specific BRIDGE may have.
        /// </summary>
        /// <value>
        /// Value of the column span_cnt
        /// </value>
		public short? SpanCount { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column usage_code
		///
		/// The specific value that represents the usage of a specific BRIDGE.
        /// </summary>
        /// <value>
        /// Value of the column usage_code
        /// </value>
		public BridgeUsageEnum? Usage { get; set; }
		
        #endregion
    }
}
