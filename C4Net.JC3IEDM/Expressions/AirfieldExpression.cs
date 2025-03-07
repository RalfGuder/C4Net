using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Airfield.
    /// </summary>
    public class AirfieldExpression : BaseEntityExpression<AirfieldExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column airfield_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column airfield_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property AirTrafficControlPresenceIndicator that represents the column atc_prsnc_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property AirTrafficControlPresenceIndicator that represents the column atc_prsnc_ind_code.
        /// </value>
        public ColumnExpression AirTrafficControlPresenceIndicator 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property HangarAreaQuantity that represents the column hngr_area_qty.
        /// </summary>
        /// <value>
        /// The value of the property HangarAreaQuantity that represents the column hngr_area_qty.
        /// </value>
        public ColumnExpression HangarAreaQuantity 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property InstrumentLandingSystemPresenceIndicator that represents the column ils_prsnc_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property InstrumentLandingSystemPresenceIndicator that represents the column ils_prsnc_ind_code.
        /// </value>
        public ColumnExpression InstrumentLandingSystemPresenceIndicator 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property InternationalCivilAviationOrganisationText that represents the column intl_civil_avtn_org_txt.
        /// </summary>
        /// <value>
        /// The value of the property InternationalCivilAviationOrganisationText that represents the column intl_civil_avtn_org_txt.
        /// </value>
        public ColumnExpression InternationalCivilAviationOrganisationText 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property VisualNavigationalAidIndicator that represents the column visual_nvtgl_aid_ind_code.
        /// </summary>
        /// <value>
        /// The value of the property VisualNavigationalAidIndicator that represents the column visual_nvtgl_aid_ind_code.
        /// </value>
        public ColumnExpression VisualNavigationalAidIndicator 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[7]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AirfieldExpression"/> class.
        /// </summary>
        public AirfieldExpression()
            : base("Airfield", typeof(IAirfield))
        {
        }

        #endregion
    }
}
