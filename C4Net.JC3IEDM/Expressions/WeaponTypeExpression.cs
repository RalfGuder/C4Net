using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity WeaponType.
    /// </summary>
    public class WeaponTypeExpression : BaseEntityExpression<WeaponTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column weapon_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column weapon_type_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property Category that represents the column cat_code.
        /// </summary>
        /// <value>
        /// The value of the property Category that represents the column cat_code.
        /// </value>
        public ColumnExpression Category 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property Subcategory that represents the column subcat_code.
        /// </summary>
        /// <value>
        /// The value of the property Subcategory that represents the column subcat_code.
        /// </value>
        public ColumnExpression Subcategory 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CalibreText that represents the column calibre_txt.
        /// </summary>
        /// <value>
        /// The value of the property CalibreText that represents the column calibre_txt.
        /// </value>
        public ColumnExpression CalibreText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property FireGuidanceIndicator that represents the column fire_guidance_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property FireGuidanceIndicator that represents the column fire_guidance_ind_code.
        /// </value>
        public ColumnExpression FireGuidanceIndicator 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[6]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponTypeExpression"/> class.
        /// </summary>
        public WeaponTypeExpression()
            : base("WeaponType", typeof(IWeaponType))
        {
        }

        #endregion
    }
}
