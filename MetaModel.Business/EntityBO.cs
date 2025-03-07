using System;
using System.Collections.Generic;
using C4Net.Metamodel.Entities;

namespace MetaModel.Business
{
    /// <summary>
    /// Class for a Metamodel Entity Business Object.
    /// </summary>
    public class EntityBO : BaseBO
    {
        #region - Fields -

        /// <summary>
        /// The ent model
        /// </summary>
        private Ent ent;

        /// <summary>
        /// The attributes
        /// </summary>
        private List<AttributeBO> attributes = new List<AttributeBO>();

        /// <summary>
        /// The subtypes
        /// </summary>
        private List<EntityBO> subtypes = new List<EntityBO>();

        /// <summary>
        /// The subtypes DOM val ix
        /// </summary>
        private List<long> subtypesDomValIx = new List<long>();

        /// <summary>
        /// The cardinality sons
        /// </summary>
        private List<CardinalityRelBO> cardinalitySons = new List<CardinalityRelBO>();

        /// <summary>
        /// The cardinality parents
        /// </summary>
        private List<CardinalityRelBO> cardinalityParents = new List<CardinalityRelBO>();

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets or sets the ent id.
        /// </summary>
        /// <value>
        /// The ent id.
        /// </value>
        public decimal EntId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the definition.
        /// </summary>
        /// <value>
        /// The definition.
        /// </value>
        public string Definition { get; set; }

        /// <summary>
        /// Gets or sets the dependency.
        /// </summary>
        /// <value>
        /// The dependency.
        /// </value>
        public string Dependency { get; set; }

        /// <summary>
        /// Gets or sets the depth.
        /// </summary>
        /// <value>
        /// The depth.
        /// </value>
        public short Depth { get; set; }

        /// <summary>
        /// Gets or sets the type of the storage.
        /// </summary>
        /// <value>
        /// The type of the storage.
        /// </value>
        public string StorageType { get; set; }

        /// <summary>
        /// Gets or sets the standardisation level.
        /// </summary>
        /// <value>
        /// The standardisation level.
        /// </value>
        public string StandardisationLevel { get; set; }

        /// <summary>
        /// Gets or sets the model level.
        /// </summary>
        /// <value>
        /// The model level.
        /// </value>
        public string ModelLevel { get; set; }

        /// <summary>
        /// Gets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public List<AttributeBO> Attributes
        {
            get { return this.attributes; }
        }

        /// <summary>
        /// Gets or sets the supertype.
        /// </summary>
        /// <value>
        /// The supertype.
        /// </value>
        public EntityBO Supertype { get; set; }

        /// <summary>
        /// Gets or sets the subtype attribute ix.
        /// </summary>
        /// <value>
        /// The subtype attribute ix.
        /// </value>
        public decimal SubtypeAttributeIx { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [subtype is complete].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [subtype is complete]; otherwise, <c>false</c>.
        /// </value>
        public bool SubtypeIsComplete { get; set; }

        /// <summary>
        /// Gets the subtypes.
        /// </summary>
        /// <value>
        /// The subtypes.
        /// </value>
        public List<EntityBO> Subtypes
        {
            get { return this.subtypes; }
        }

        /// <summary>
        /// Gets or sets the subtype DOM id.
        /// </summary>
        /// <value>
        /// The subtype DOM id.
        /// </value>
        public int SubtypeDomId { get; set; }

        /// <summary>
        /// Gets the subtypes DOM val ix.
        /// </summary>
        /// <value>
        /// The subtypes DOM val ix.
        /// </value>
        public List<long> SubtypesDomValIx
        {
            get { return this.subtypesDomValIx; }
        }

        /// <summary>
        /// Gets the cardinality sons.
        /// </summary>
        /// <value>
        /// The cardinality sons.
        /// </value>
        public List<CardinalityRelBO> CardinalitySons
        {
            get { return this.cardinalitySons; }
        }

        /// <summary>
        /// Gets the cardinality parents.
        /// </summary>
        /// <value>
        /// The cardinality parents.
        /// </value>
        public List<CardinalityRelBO> CardinalityParents
        {
            get { return this.cardinalityParents; }
        }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityBO"/> class.
        /// </summary>
        /// <param name="ent">The ent.</param>
        public EntityBO(Ent ent)
            : base()
        {
            this.ent = ent;
            this.Supertype = null;
            this.Load();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Loads this instance.
        /// </summary>
        public override void Load()
        {
            this.EntId = Convert.ToDecimal(this.ent.EntId);
            this.Name = ent.NameTxt;
            this.TableName = ent.TabNameTxt;
            this.Definition = ent.DefTxt;
            this.Dependency = ent.DepenCode;
            this.Depth = Convert.ToInt16(this.ent.DepthCnt);
            this.StorageType = ent.StgTypeCode;
            this.StandardisationLevel = ent.StdnLvlCode;
            this.ModelLevel = ent.ModLvlCode;
        }

        /// <summary>
        /// Adds the attribute.
        /// </summary>
        /// <param name="attribute">The attribute.</param>
        public void AddAttribute(AttributeBO attribute)
        {
            attribute.ParentEntity = this;
            this.attributes.Add(attribute);
        }

        /// <summary>
        /// Adds the subtype.
        /// </summary>
        /// <param name="child">The child.</param>
        /// <param name="domId">The DOM id.</param>
        /// <param name="domValIx">The DOM val ix.</param>
        public void AddSubtype(EntityBO child, int domId, long domValIx)
        {
            child.Supertype = this;
            this.Subtypes.Add(child);
            this.SubtypesDomValIx.Add(domValIx);
            this.SubtypeDomId = domId;
        }

        /// <summary>
        /// Selects this instance.
        /// </summary>
        public void Select()
        {
            this.Selected = true;
            foreach (AttributeBO attribute in this.Attributes)
            {
                attribute.Select();
            }
            foreach (CardinalityRelBO rel in this.cardinalitySons)
            {
                rel.Selected = true;
            }
            foreach (CardinalityRelBO rel in this.cardinalityParents)
            {
                rel.Selected = true;
            }
        }

        #endregion
    }
}
