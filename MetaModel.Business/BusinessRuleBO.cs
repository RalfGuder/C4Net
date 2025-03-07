using System;
using System.Collections.Generic;
using C4Net.Metamodel.Entities;

namespace MetaModel.Business
{
    /// <summary>
    /// Class for a Metamodel Business Rule Business Object
    /// </summary>
    public class BusinessRuleBO : BaseBO
    {
        #region - Fields -

        /// <summary>
        /// The br model
        /// </summary>
        private Br br;

        /// <summary>
        /// The cursor index
        /// </summary>
        private int cursorIndex = 0;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets or sets the rule id.
        /// </summary>
        /// <value>
        /// The rule id.
        /// </value>
        public long RuleId { get; set; }

        /// <summary>
        /// Gets or sets the section.
        /// </summary>
        /// <value>
        /// The section.
        /// </value>
        public string Section { get; set; }

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
        /// Gets or sets the table reference.
        /// </summary>
        /// <value>
        /// The table reference.
        /// </value>
        public string TableReference { get; set; }

        /// <summary>
        /// Gets or sets the ent id of interest.
        /// </summary>
        /// <value>
        /// The ent id of interest.
        /// </value>
        public decimal EntIdOfInterest { get; set; }

        /// <summary>
        /// Gets or sets the entity of interest.
        /// </summary>
        /// <value>
        /// The entity of interest.
        /// </value>
        public EntityBO EntityOfInterest { get; set; }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public List<AttributeBO> Attributes { get; set; }

        /// <summary>
        /// Gets or sets the attributes nullable.
        /// </summary>
        /// <value>
        /// The attributes nullable.
        /// </value>
        public List<bool> AttributesNullable { get; set; }

        /// <summary>
        /// Gets or sets the allowed values.
        /// </summary>
        /// <value>
        /// The allowed values.
        /// </value>
        public List<List<DomainValueBO>> AllowedValues { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessRuleBO"/> class.
        /// </summary>
        /// <param name="br">The br.</param>
        public BusinessRuleBO(Br br)
        {
            this.br = br;
            this.EntIdOfInterest = 0;
            this.EntityOfInterest = null;
            this.Attributes = new List<AttributeBO>();
            this.AttributesNullable = new List<bool>();
            this.AllowedValues = new List<List<DomainValueBO>>();
            this.Load();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Loads this instance.
        /// </summary>
        public override void Load()
        {
            this.RuleId = Convert.ToInt64(br.BrId);
            this.Section = br.SectionXrefTxt;
            this.Name = br.NameTxt;
            this.Definition = br.DefTxt;
            this.TableReference = br.TabXrefTxt;
        }

        /// <summary>
        /// Loads the ent.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void LoadEnt(EntityBO entity)
        {
            if (this.EntityOfInterest == null)
            {
                this.EntIdOfInterest = entity.EntId;
                this.EntityOfInterest = entity;
            }
        }

        /// <summary>
        /// Loads the attribute.
        /// </summary>
        /// <param name="attribute">The attribute.</param>
        /// <param name="isNullable">if set to <c>true</c> [is nullable].</param>
        public void LoadAttribute(AttributeBO attribute, bool isNullable)
        {
            this.Attributes.Add(attribute);
            this.AttributesNullable.Add(isNullable);
        }

        /// <summary>
        /// Adds the value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void AddValue(DomainValueBO value)
        {
            if (this.cursorIndex == 0)
            {
                this.AllowedValues.Add(new List<DomainValueBO>());
            }
            List<DomainValueBO> values = this.AllowedValues[this.AllowedValues.Count - 1];
            values.Add(value);
            this.cursorIndex++;
            if (cursorIndex >= this.Attributes.Count)
            {
                this.cursorIndex = 0;
            }
        }

        #endregion
    }
}
