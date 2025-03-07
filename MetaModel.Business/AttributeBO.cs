using System;
using C4Net.Metamodel.Entities;

namespace MetaModel.Business
{
    /// <summary>
    /// Class for a Metamodel Attribute Business Object.
    /// </summary>
    public class AttributeBO : BaseBO
    {
        #region - Fields -

        /// <summary>
        /// The Attr model.
        /// </summary>
        private Attr attr;

        /// <summary>
        /// The NkAttr model.
        /// </summary>
        private NkAttr nkAttr;

        /// <summary>
        /// The FkAttr model.
        /// </summary>
        private FkAttr fkAttr;

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
        /// Gets or sets the ent id.
        /// </summary>
        /// <value>
        /// The ent id.
        /// </value>
        public decimal EntId { get; set; }

        /// <summary>
        /// Gets or sets the attr ix.
        /// </summary>
        /// <value>
        /// The attr ix.
        /// </value>
        public decimal AttrIx { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the column.
        /// </summary>
        /// <value>
        /// The name of the column.
        /// </value>
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        /// <value>
        /// The sequence number.
        /// </value>
        public short SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is primary key.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is primary key; otherwise, <c>false</c>.
        /// </value>
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is foreign key.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is foreign key; otherwise, <c>false</c>.
        /// </value>
        public bool IsForeignKey { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is mandatory.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is mandatory; otherwise, <c>false</c>.
        /// </value>
        public bool IsMandatory { get; set; }

        /// <summary>
        /// Gets or sets the standardisation level.
        /// </summary>
        /// <value>
        /// The standardisation level.
        /// </value>
        public string StandardisationLevel { get; set; }

        /// <summary>
        /// Gets or sets the base ent id.
        /// </summary>
        /// <value>
        /// The base ent id.
        /// </value>
        public decimal BaseEntId { get; set; }

        /// <summary>
        /// Gets or sets the base attr ix.
        /// </summary>
        /// <value>
        /// The base attr ix.
        /// </value>
        public decimal BaseAttrIx { get; set; }

        /// <summary>
        /// Gets or sets the SRC ent id.
        /// </summary>
        /// <value>
        /// The SRC ent id.
        /// </value>
        public decimal SrcEntId { get; set; }

        /// <summary>
        /// Gets or sets the SRC attr ix.
        /// </summary>
        /// <value>
        /// The SRC attr ix.
        /// </value>
        public decimal SrcAttrIx { get; set; }

        /// <summary>
        /// Gets or sets the migr rel ix.
        /// </summary>
        /// <value>
        /// The migr rel ix.
        /// </value>
        public short MigrRelIx { get; set; }

        /// <summary>
        /// Gets or sets the role def TXT.
        /// </summary>
        /// <value>
        /// The role def TXT.
        /// </value>
        public string RoleDefTxt { get; set; }

        /// <summary>
        /// Gets or sets the base definition.
        /// </summary>
        /// <value>
        /// The base definition.
        /// </value>
        public string BaseDefinition { get; set; }

        /// <summary>
        /// Gets or sets the type of the base data.
        /// </summary>
        /// <value>
        /// The type of the base data.
        /// </value>
        public string BaseDataType { get; set; }

        /// <summary>
        /// Gets or sets the base data decimals.
        /// </summary>
        /// <value>
        /// The base data decimals.
        /// </value>
        public int BaseDataDecimals { get; set; }

        /// <summary>
        /// Gets or sets the length of the base data.
        /// </summary>
        /// <value>
        /// The length of the base data.
        /// </value>
        public int BaseDataLength { get; set; }

        /// <summary>
        /// Gets or sets the base DOM id.
        /// </summary>
        /// <value>
        /// The base DOM id.
        /// </value>
        public int BaseDomId { get; set; }

        /// <summary>
        /// Gets or sets the base attribute.
        /// </summary>
        /// <value>
        /// The base attribute.
        /// </value>
        public AttributeBO BaseAttribute { get; set; }

        /// <summary>
        /// Gets or sets the source attribute.
        /// </summary>
        /// <value>
        /// The source attribute.
        /// </value>
        public AttributeBO SourceAttribute { get; set; }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>
        /// The domain.
        /// </value>
        public DomainBO Domain { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeBO"/> class.
        /// </summary>
        /// <param name="attr">The attr.</param>
        public AttributeBO(Attr attr)
        {
            this.ParentEntity = null;
            this.attr = attr;
            this.Load();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Loads this instance.
        /// </summary>
        public override void Load()
        {
            this.EntId = Convert.ToDecimal(this.attr.EntId);
            this.AttrIx = Convert.ToDecimal(this.attr.AttrIx);
            this.Name = this.attr.NameTxt;
            this.ColumnName = this.attr.ColNameTxt;
            this.SequenceNumber = Convert.ToInt16(this.attr.AttrSeqnrOrd);
            this.IsPrimaryKey = this.attr.PkIndCode.Equals("PK");
            this.IsForeignKey = this.attr.FkIndCode.Equals("FK");
            if (this.IsPrimaryKey)
            {
                this.IsMandatory = true;
            }
            this.StandardisationLevel = this.attr.StdnLvlCode;
        }

        /// <summary>
        /// Loads the nk attr.
        /// </summary>
        /// <param name="nkAttr">The nk attr.</param>
        public void LoadNkAttr(NkAttr nkAttr)
        {
            this.nkAttr = nkAttr;
            this.IsMandatory = this.nkAttr.OptIndCode.Equals("MA");           
        }

        /// <summary>
        /// Loads the fk attr.
        /// </summary>
        /// <param name="fkAttr">The fk attr.</param>
        public void LoadFkAttr(FkAttr fkAttr)
        {
            this.fkAttr = fkAttr;
            this.BaseEntId = Convert.ToDecimal(fkAttr.BaseEntId);
            this.BaseAttrIx = Convert.ToDecimal(fkAttr.BaseAttrIx);
            this.SrcEntId = Convert.ToDecimal(fkAttr.SrcEntId);
            this.SrcAttrIx = Convert.ToDecimal(fkAttr.SrcAttrIx);
            this.MigrRelIx = Convert.ToInt16(fkAttr.MigrRelIx);
            this.RoleDefTxt = fkAttr.RoleDefTxt;
        }

        /// <summary>
        /// Loads the base attr.
        /// </summary>
        /// <param name="baseAttr">The base attr.</param>
        public void LoadBaseAttr(BaseAttr baseAttr)
        {
            this.BaseDefinition = baseAttr.DefTxt;
            this.BaseDataType = baseAttr.DataTypeCode;
            this.BaseDataDecimals = Convert.ToInt32(baseAttr.DataDecCnt);
            this.BaseDataLength = Convert.ToInt32(baseAttr.DataLenCnt);
            this.BaseDomId = Convert.ToInt32(baseAttr.DomId);
        }

        /// <summary>
        /// Selects this instance.
        /// </summary>
        public void Select()
        {
            this.Selected = true;
            this.Domain.Selected = true;
        }

        #endregion
    }
}
