using System;
using C4Net.Data.Definitions;
using C4Net.Metamodel.Expressions;
using C4Net.Metamodel.Interfaces;

namespace C4Net.Metamodel.Entities
{
    /// <summary>
    /// Class for the table BR_ENT.
    /// </summary>
    [Serializable]
    [DefinitionName("BrEnt", "C4Net.Metamodel.Definitions.BrEnt.definition.xml")]
    public partial class BrEnt : IBrEnt
    {
        #region - Fields - 

        /// <summary>
        /// Expression builder for this entity.
        /// </summary>
        public static readonly BrEntExpression _ = new BrEntExpression();

        #endregion

        #region - Properties -
		
        /// <summary>
        /// Gets or sets the value of the column br_id
        /// </summary>
        /// <value>
        /// Value of the column br_id
        /// </value>
        public double BrId { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column br_ent_ix
        /// </summary>
        /// <value>
        /// Value of the column br_ent_ix
        /// </value>
        public double BrEntIx { get; set; }
		
        /// <summary>
        /// Gets or sets the value of the column ent_of_interest_id
        /// </summary>
        /// <value>
        /// Value of the column ent_of_interest_id
        /// </value>
        public double EntOfInterestId { get; set; }
		
        #endregion
    }
}
