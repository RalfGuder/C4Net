using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity AmmunitionType.
    /// </summary>
    public class AmmunitionTypeExpression : BaseEntityExpression<AmmunitionTypeExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column ammo_type_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column ammo_type_id.
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
        /// Expression for the property CalibreText that represents the column calibre_txt.
        /// </summary>
        /// <value>
        /// The value of the property CalibreText that represents the column calibre_txt.
        /// </value>
        public ColumnExpression CalibreText 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property MineMaritimeFiring that represents the column mine_mrt_firing_code.
        /// </summary>
        /// <value>
        /// The value of the property MineMaritimeFiring that represents the column mine_mrt_firing_code.
        /// </value>
        public ColumnExpression MineMaritimeFiring 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property ExerciseMineFlareColour that represents the column exer_mine_flare_colour_code.
        /// </summary>
        /// <value>
        /// The value of the property ExerciseMineFlareColour that represents the column exer_mine_flare_colour_code.
        /// </value>
        public ColumnExpression ExerciseMineFlareColour 
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
        /// Initializes a new instance of the <see cref="AmmunitionTypeExpression"/> class.
        /// </summary>
        public AmmunitionTypeExpression()
            : base("AmmunitionType", typeof(IAmmunitionType))
        {
        }

        #endregion
    }
}
