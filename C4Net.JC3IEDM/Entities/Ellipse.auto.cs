using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity ELLIPSE that represents the table ELPS.
	///
	/// A planar SURFACE in the form of an ellipse.
    /// </summary>
    [Serializable]
    [DefinitionName("Ellipse", "C4Net.JC3IEDM.Definitions.Ellipse.definition.xml")]
    public class Ellipse : Surface, IEllipse
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly EllipseExpression _ = new EllipseExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column elps_centre_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column elps_centre_point_id
        /// </value>
		public decimal CentrePointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column elps_first_cnjg_diam_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column elps_first_cnjg_diam_point_id
        /// </value>
		public decimal FirstConjugateDiameterPointId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column elps_scnd_cnjg_diam_point_id
		///
		/// The unique value, or set of characters, assigned to represent a specific LOCATION and to distinguish it from all other LOCATIONs.
        /// </summary>
        /// <value>
        /// Value of the column elps_scnd_cnjg_diam_point_id
        /// </value>
		public decimal SecondConjugateDiameterPointId { get; set; }
		
        #endregion
    }
}
