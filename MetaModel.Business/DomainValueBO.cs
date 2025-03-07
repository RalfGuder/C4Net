using System;
using C4Net.Metamodel.Entities;

namespace MetaModel.Business
{
    /// <summary>
    /// Class for a Metamodel Domain Value Business Object.
    /// </summary>
    public class DomainValueBO : BaseBO
    {
        #region - Fields -

        /// <summary>
        /// The domval model
        /// </summary>
        private DomVal domVal;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets or sets the domain id.
        /// </summary>
        /// <value>
        /// The domain id.
        /// </value>
        public int DomainId { get; set; }

        /// <summary>
        /// Gets or sets the DOM val ix.
        /// </summary>
        /// <value>
        /// The DOM val ix.
        /// </value>
        public long DomValIx { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the definition.
        /// </summary>
        /// <value>
        /// The definition.
        /// </value>
        public string Definition { get; set; }

        /// <summary>
        /// Gets or sets the standardisation level.
        /// </summary>
        /// <value>
        /// The standardisation level.
        /// </value>
        public string StandardisationLevel { get; set; }

        /// <summary>
        /// Gets or sets the source text.
        /// </summary>
        /// <value>
        /// The source text.
        /// </value>
        public string SourceText { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainValueBO"/> class.
        /// </summary>
        /// <param name="domVal">The DOM val.</param>
        public DomainValueBO(DomVal domVal)
        {
            this.domVal = domVal;
            this.Load();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Loads this instance.
        /// </summary>
        public override void Load()
        {
            this.DomainId = Convert.ToInt32(this.domVal.DomId);
            this.DomValIx = Convert.ToInt64(this.domVal.DomValIx);
            this.Description = this.domVal.DescrTxt;
            this.Name = this.domVal.NameTxt;
            this.Definition = this.domVal.DefTxt;
            this.StandardisationLevel = this.domVal.StdnLvlCode;
            this.SourceText = this.domVal.SrcTxt;
        }

        #endregion
    }
}
