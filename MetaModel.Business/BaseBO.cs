
namespace MetaModel.Business
{
    /// <summary>
    /// Base class for a Metamodel Business Object.
    /// </summary>
    public abstract class BaseBO
    {
        #region - Fields -

        /// <summary>
        /// Indicates if the BO is selected
        /// </summary>
        private bool selected = false;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BaseBO"/> is selected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if selected; otherwise, <c>false</c>.
        /// </value>
        public bool Selected
        {
            get { return this.selected; }
            set { this.selected = value; }
        }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseBO"/> class.
        /// </summary>
        public BaseBO()
        {
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Loads this instance.
        /// </summary>
        public abstract void Load();

        #endregion
    }
}
