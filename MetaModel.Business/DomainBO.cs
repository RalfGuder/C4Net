using System;
using System.Collections.Generic;
using C4Net.Metamodel.Entities;

namespace MetaModel.Business
{
    /// <summary>
    /// Class for a Metamodel Domain Business Object.
    /// </summary>
    public class DomainBO : BaseBO
    {
        #region - Fields -

        /// <summary>
        /// The dom model
        /// </summary>
        private Dom dom;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets or sets the DOM id.
        /// </summary>
        /// <value>
        /// The DOM id.
        /// </value>
        public int DomId { get; set; }

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
        /// Gets or sets the name of the class.
        /// </summary>
        /// <value>
        /// The name of the class.
        /// </value>
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets the type of the restriction.
        /// </summary>
        /// <value>
        /// The type of the restriction.
        /// </value>
        public string RestrictionType { get; set; }

        /// <summary>
        /// Gets or sets the measurement unit.
        /// </summary>
        /// <value>
        /// The measurement unit.
        /// </value>
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// Gets or sets the parent DOM id.
        /// </summary>
        /// <value>
        /// The parent DOM id.
        /// </value>
        public int ParentDomId { get; set; }

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
        /// Gets or sets the definition source.
        /// </summary>
        /// <value>
        /// The definition source.
        /// </value>
        public string DefinitionSource { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is range.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is range; otherwise, <c>false</c>.
        /// </value>
        public bool IsRange { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is enumerated.
        /// </summary>
        /// <value>
        ///  <c>true</c> if this instance is enumerated; otherwise, <c>false</c>.
        /// </value>
        public bool IsEnumerated { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is simple.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is simple; otherwise, <c>false</c>.
        /// </value>
        public bool IsSimple { get; set; }

        /// <summary>
        /// Gets or sets the min value.
        /// </summary>
        /// <value>
        /// The min value.
        /// </value>
        public string MinValue { get; set; }

        /// <summary>
        /// Gets or sets the max value.
        /// </summary>
        /// <value>
        /// The max value.
        /// </value>
        public string MaxValue { get; set; }

        /// <summary>
        /// Gets or sets the enumerateds.
        /// </summary>
        /// <value>
        /// The enumerateds.
        /// </value>
        public List<DomainValueBO> Enumerateds { get; set; }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainBO"/> class.
        /// </summary>
        /// <param name="dom">The DOM.</param>
        public DomainBO(Dom dom)
        {
            this.dom = dom;
            this.Enumerateds = new List<DomainValueBO>();
            this.Load();
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Loads this instance.
        /// </summary>
        public override void Load()
        {
            this.DomId = Convert.ToInt32(this.dom.DomId);
            this.Name = this.dom.NameTxt;
            this.Definition = this.dom.DefTxt;
            this.ClassName = this.dom.ClassNameTxt;
            this.RestrictionType = this.dom.RestrTypeCode;
            this.MeasurementUnit = this.dom.MeasUnitDescrTxt;
            this.ParentDomId = Convert.ToInt32(this.dom.PaDomId);
            this.StandardisationLevel = this.dom.StdnLvlCode;
            this.ModelLevel = this.dom.ModLvlCode;
            this.DefinitionSource = this.dom.DefSrcTxt;
            this.IsRange = false;
            this.IsEnumerated = false;
            this.IsSimple = true;
            if (!string.IsNullOrEmpty(this.RestrictionType))
            {
                if (this.RestrictionType.Equals("RA"))
                {
                    this.IsRange = true;
                    this.IsEnumerated = false;
                    this.IsSimple = false;
                }
                else if (this.RestrictionType.Equals("EN"))
                {
                    this.IsRange = false;
                    this.IsEnumerated = true;
                    this.IsSimple = false;
                }
            }
        }

        /// <summary>
        /// Adds the min.
        /// </summary>
        /// <param name="domVal">The DOM val.</param>
        public void AddMin(DomVal domVal)
        {
            this.MinValue = domVal.DescrTxt;
        }

        /// <summary>
        /// Adds the max.
        /// </summary>
        /// <param name="domVal">The DOM val.</param>
        public void AddMax(DomVal domVal)
        {
            this.MaxValue = domVal.DescrTxt;
        }

        /// <summary>
        /// Adds the enum.
        /// </summary>
        /// <param name="domVal">The DOM val.</param>
        public void AddEnum(DomVal domVal)
        {
            this.Enumerateds.Add(new DomainValueBO(domVal));
        }

        /// <summary>
        /// Gets the domain value.
        /// </summary>
        /// <param name="domValIx">The DOM val ix.</param>
        /// <returns></returns>
        public DomainValueBO GetDomainValue(int domValIx)
        {
            foreach (DomainValueBO domVal in this.Enumerateds)
            {
                if (domVal.DomValIx == domValIx)
                {
                    return domVal;
                }
            }
            return null;
        }

        #endregion
    }
}
