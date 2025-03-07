using System.Collections.Generic;

namespace C4Net.Templates.Parser
{
    /// <summary>
    /// List of actions for a state of the parser state machine.
    /// </summary>
    public class ParserStateActions
    {
        #region - Properties -

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public int State { get; set; }

        /// <summary>
        /// Gets or sets the actions.
        /// </summary>
        /// <value>
        /// The actions.
        /// </value>
        public List<ParserAction> Actions { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="ParserStateActions"/> class.
        /// </summary>
        /// <param name="state">The state.</param>
        public ParserStateActions(int state)
        {
            this.State = state;
            this.Actions = new List<ParserAction>();
        }

        #endregion
    }
}
