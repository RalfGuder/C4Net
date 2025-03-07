using System;
using C4Net.Metamodel.Entities;

namespace MetaModel.Business
{
    /// <summary>
    /// Class for a Metamodel Cardinality Relationship Business Object.
    /// </summary>
    public class CardinalityRelBO : BaseBO
    {
        #region - Fields -

        /// <summary>
        /// The cardrel model
        /// </summary>
        private CardRel cardRel;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets or sets the parent entity.
        /// </summary>
        /// <value>
        /// The parent entity.
        /// </value>
        public EntityBO ParentEntity { get; set; }

        /// <summary>
        /// Gets or sets the child entity.
        /// </summary>
        /// <value>
        /// The child entity.
        /// </value>
        public EntityBO ChildEntity { get; set; }

        /// <summary>
        /// Gets or sets the index of the relationship.
        /// </summary>
        /// <value>
        /// The index of the relationship.
        /// </value>
        public short RelationshipIndex { get; set; }

        /// <summary>
        /// Gets or sets the name of the verb.
        /// </summary>
        /// <value>
        /// The name of the verb.
        /// </value>
        public string VerbName { get; set; }

        /// <summary>
        /// Gets or sets the name of the inverse verb.
        /// </summary>
        /// <value>
        /// The name of the inverse verb.
        /// </value>
        public string InverseVerbName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is identifying.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is identifying; otherwise, <c>false</c>.
        /// </value>
        public bool IsIdentifying { get; set; }

        /// <summary>
        /// Gets or sets the type of the cardinality.
        /// </summary>
        /// <value>
        /// The type of the cardinality.
        /// </value>
        public CardinalityTypeEnum CardinalityType { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="CardinalityRelBO"/> class.
        /// </summary>
        /// <param name="rel">The rel.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="child">The child.</param>
        public CardinalityRelBO(CardRel rel, EntityBO parent, EntityBO child)
        {
            this.cardRel = rel;
            this.ParentEntity = parent;
            this.ChildEntity = child;
            this.Load();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Loads this instance.
        /// </summary>
        public override void Load()
        {
            this.RelationshipIndex = Convert.ToInt16(this.cardRel.RelIx);
            this.VerbName = this.cardRel.VerbNameTxt;
            this.InverseVerbName = this.cardRel.InvVerbNameTxt;
            this.IsIdentifying = this.cardRel.IdentIndCode.Equals("ID");
            if (this.cardRel.PaCardCode.Equals("MA")) // at least one parent
            {
                if (this.cardRel.ChCardCode.Equals("ZM"))
                {
                    this.CardinalityType = CardinalityTypeEnum.OneToMany;
                }
                else
                {
                    this.CardinalityType = CardinalityTypeEnum.OneToOne;
                }
            }
            else
            {
                if (this.cardRel.ChCardCode.Equals("ZM"))
                {
                    this.CardinalityType = CardinalityTypeEnum.ZeroToMany;
                }
                else
                {
                    this.CardinalityType = CardinalityTypeEnum.ZeroToOne;
                }
            }
        }

        #endregion
    }
}
