using System;
using C4Net.Data.Definitions;
using C4Net.Data.Interfaces;
using C4Net.JC3IEDM.Enums;
using C4Net.JC3IEDM.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Entities
{
    /// <summary>
    /// Class for the entity LINE that represents the table LINE.
	///
	/// A LOCATION that is defined by two or more POINTs connected by one-dimensional line segments in an ordered sequence.
    /// </summary>
    [Serializable]
    [DefinitionName("Line", "C4Net.JC3IEDM.Definitions.Line.definition.xml")]
    public class Line : Location, ILine
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static new readonly LineExpression _ = new LineExpression();

        #endregion

        #region - Properties -
		
        #endregion
    }
}
