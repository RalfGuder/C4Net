using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity PhysicalAddress.
    /// </summary>
    public class PhysicalAddressExpression : BaseEntityExpression<PhysicalAddressExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property AddressId that represents the column addr_id.
        /// </summary>
        /// <value>
        /// The value of the property AddressId that represents the column addr_id.
        /// </value>
        public ColumnExpression AddressId 
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
        /// Expression for the property ResidenceText that represents the column rsdnc_txt.
        /// </summary>
        /// <value>
        /// The value of the property ResidenceText that represents the column rsdnc_txt.
        /// </value>
        public ColumnExpression ResidenceText 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property StreetText that represents the column street_txt.
        /// </summary>
        /// <value>
        /// The value of the property StreetText that represents the column street_txt.
        /// </value>
        public ColumnExpression StreetText 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property StreetAdditionalText that represents the column street_addtnl_txt.
        /// </summary>
        /// <value>
        /// The value of the property StreetAdditionalText that represents the column street_addtnl_txt.
        /// </value>
        public ColumnExpression StreetAdditionalText 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property PostalBoxText that represents the column postal_box_txt.
        /// </summary>
        /// <value>
        /// The value of the property PostalBoxText that represents the column postal_box_txt.
        /// </value>
        public ColumnExpression PostalBoxText 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property PostboxIdentifierText that represents the column postbox_id_txt.
        /// </summary>
        /// <value>
        /// The value of the property PostboxIdentifierText that represents the column postbox_id_txt.
        /// </value>
        public ColumnExpression PostboxIdentifierText 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property CityText that represents the column city_txt.
        /// </summary>
        /// <value>
        /// The value of the property CityText that represents the column city_txt.
        /// </value>
        public ColumnExpression CityText 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property GeographicText that represents the column geo_txt.
        /// </summary>
        /// <value>
        /// The value of the property GeographicText that represents the column geo_txt.
        /// </value>
        public ColumnExpression GeographicText 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property PostalCodeText that represents the column postal_code_txt.
        /// </summary>
        /// <value>
        /// The value of the property PostalCodeText that represents the column postal_code_txt.
        /// </value>
        public ColumnExpression PostalCodeText 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property ProvinceText that represents the column province_txt.
        /// </summary>
        /// <value>
        /// The value of the property ProvinceText that represents the column province_txt.
        /// </value>
        public ColumnExpression ProvinceText 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property DistrictText that represents the column district_txt.
        /// </summary>
        /// <value>
        /// The value of the property DistrictText that represents the column district_txt.
        /// </value>
        public ColumnExpression DistrictText 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[13]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalAddressExpression"/> class.
        /// </summary>
        public PhysicalAddressExpression()
            : base("PhysicalAddress", typeof(IPhysicalAddress))
        {
        }

        #endregion
    }
}
