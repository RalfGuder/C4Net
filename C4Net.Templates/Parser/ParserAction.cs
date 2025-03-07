
namespace C4Net.Templates.Parser
{
    /// <summary>
    /// An action over the state machine. When "pattern" then add a token of the given token type and change the state of the
    /// machine to NewState.
    /// </summary>
    public class ParserAction
    {
        #region - Properties -

        /// <summary>
        /// Gets or sets the pattern.
        /// </summary>
        /// <value>
        /// The pattern.
        /// </value>
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or sets the type of the token.
        /// </summary>
        /// <value>
        /// The type of the token.
        /// </value>
        public int TokenType { get; set; }

        /// <summary>
        /// Gets or sets the new state.
        /// </summary>
        /// <value>
        /// The new state.
        /// </value>
        public int NewState { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="ParserAction"/> class.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <param name="tokenType">Type of the token.</param>
        /// <param name="newState">The new state.</param>
        public ParserAction(string pattern, int tokenType, int newState)
        {
            this.Pattern = pattern;
            this.TokenType = tokenType;
            this.NewState = newState;
        }

        #endregion
    }
}
