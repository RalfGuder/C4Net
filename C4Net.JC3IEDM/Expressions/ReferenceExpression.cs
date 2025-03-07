using C4Net.Core.Expressions;
using C4Net.JC3IEDM.Interfaces;

namespace C4Net.JC3IEDM.Expressions
{
    /// <summary>
    /// Expression class for query the entity Reference.
    /// </summary>
    public class ReferenceExpression : BaseEntityExpression<ReferenceExpression>
    {
        #region - Properties -
		
        /// <summary>
        /// Expression for the property Id that represents the column ref_id.
        /// </summary>
        /// <value>
        /// The value of the property Id that represents the column ref_id.
        /// </value>
        public ColumnExpression Id 
        { 
            get { return this.columns[0]; } 
        }
		
        /// <summary>
        /// Expression for the property ApprovalDatetime that represents the column app_dttm.
        /// </summary>
        /// <value>
        /// The value of the property ApprovalDatetime that represents the column app_dttm.
        /// </value>
        public ColumnExpression ApprovalDatetime 
        { 
            get { return this.columns[1]; } 
        }
		
        /// <summary>
        /// Expression for the property ContentCategory that represents the column cntnt_cat_code.
        /// </summary>
        /// <value>
        /// The value of the property ContentCategory that represents the column cntnt_cat_code.
        /// </value>
        public ColumnExpression ContentCategory 
        { 
            get { return this.columns[2]; } 
        }
		
        /// <summary>
        /// Expression for the property CreationDatetime that represents the column creation_dttm.
        /// </summary>
        /// <value>
        /// The value of the property CreationDatetime that represents the column creation_dttm.
        /// </value>
        public ColumnExpression CreationDatetime 
        { 
            get { return this.columns[3]; } 
        }
		
        /// <summary>
        /// Expression for the property DescriptionText that represents the column descr_txt.
        /// </summary>
        /// <value>
        /// The value of the property DescriptionText that represents the column descr_txt.
        /// </value>
        public ColumnExpression DescriptionText 
        { 
            get { return this.columns[4]; } 
        }
		
        /// <summary>
        /// Expression for the property ElectronicSourceText that represents the column elctrnc_source_txt.
        /// </summary>
        /// <value>
        /// The value of the property ElectronicSourceText that represents the column elctrnc_source_txt.
        /// </value>
        public ColumnExpression ElectronicSourceText 
        { 
            get { return this.columns[5]; } 
        }
		
        /// <summary>
        /// Expression for the property FileSizeQuantity that represents the column file_size_qty.
        /// </summary>
        /// <value>
        /// The value of the property FileSizeQuantity that represents the column file_size_qty.
        /// </value>
        public ColumnExpression FileSizeQuantity 
        { 
            get { return this.columns[6]; } 
        }
		
        /// <summary>
        /// Expression for the property FormatText that represents the column format_txt.
        /// </summary>
        /// <value>
        /// The value of the property FormatText that represents the column format_txt.
        /// </value>
        public ColumnExpression FormatText 
        { 
            get { return this.columns[7]; } 
        }
		
        /// <summary>
        /// Expression for the property Language that represents the column lang_code.
        /// </summary>
        /// <value>
        /// The value of the property Language that represents the column lang_code.
        /// </value>
        public ColumnExpression Language 
        { 
            get { return this.columns[8]; } 
        }
		
        /// <summary>
        /// Expression for the property Lifecycle that represents the column lifecycle_code.
        /// </summary>
        /// <value>
        /// The value of the property Lifecycle that represents the column lifecycle_code.
        /// </value>
        public ColumnExpression Lifecycle 
        { 
            get { return this.columns[9]; } 
        }
		
        /// <summary>
        /// Expression for the property MediumType that represents the column medium_type_code.
        /// </summary>
        /// <value>
        /// The value of the property MediumType that represents the column medium_type_code.
        /// </value>
        public ColumnExpression MediumType 
        { 
            get { return this.columns[10]; } 
        }
		
        /// <summary>
        /// Expression for the property OriginatorText that represents the column originator_txt.
        /// </summary>
        /// <value>
        /// The value of the property OriginatorText that represents the column originator_txt.
        /// </value>
        public ColumnExpression OriginatorText 
        { 
            get { return this.columns[11]; } 
        }
		
        /// <summary>
        /// Expression for the property PhysicalSizeText that represents the column physcl_size_txt.
        /// </summary>
        /// <value>
        /// The value of the property PhysicalSizeText that represents the column physcl_size_txt.
        /// </value>
        public ColumnExpression PhysicalSizeText 
        { 
            get { return this.columns[12]; } 
        }
		
        /// <summary>
        /// Expression for the property PrimaryLocationText that represents the column prim_loc_txt.
        /// </summary>
        /// <value>
        /// The value of the property PrimaryLocationText that represents the column prim_loc_txt.
        /// </value>
        public ColumnExpression PrimaryLocationText 
        { 
            get { return this.columns[13]; } 
        }
		
        /// <summary>
        /// Expression for the property PublicationDatetime that represents the column publication_dttm.
        /// </summary>
        /// <value>
        /// The value of the property PublicationDatetime that represents the column publication_dttm.
        /// </value>
        public ColumnExpression PublicationDatetime 
        { 
            get { return this.columns[14]; } 
        }
		
        /// <summary>
        /// Expression for the property ReleasabilityText that represents the column releasability_txt.
        /// </summary>
        /// <value>
        /// The value of the property ReleasabilityText that represents the column releasability_txt.
        /// </value>
        public ColumnExpression ReleasabilityText 
        { 
            get { return this.columns[15]; } 
        }
		
        /// <summary>
        /// Expression for the property ShortTitleText that represents the column short_title_txt.
        /// </summary>
        /// <value>
        /// The value of the property ShortTitleText that represents the column short_title_txt.
        /// </value>
        public ColumnExpression ShortTitleText 
        { 
            get { return this.columns[16]; } 
        }
		
        /// <summary>
        /// Expression for the property TitleText that represents the column title_txt.
        /// </summary>
        /// <value>
        /// The value of the property TitleText that represents the column title_txt.
        /// </value>
        public ColumnExpression TitleText 
        { 
            get { return this.columns[17]; } 
        }
		
        /// <summary>
        /// Expression for the property TransmittalType that represents the column trans_type_code.
        /// </summary>
        /// <value>
        /// The value of the property TransmittalType that represents the column trans_type_code.
        /// </value>
        public ColumnExpression TransmittalType 
        { 
            get { return this.columns[18]; } 
        }
		
        /// <summary>
        /// Expression for the property ValidityPeriodBeginDatetime that represents the column validity_period_begin_dttm.
        /// </summary>
        /// <value>
        /// The value of the property ValidityPeriodBeginDatetime that represents the column validity_period_begin_dttm.
        /// </value>
        public ColumnExpression ValidityPeriodBeginDatetime 
        { 
            get { return this.columns[19]; } 
        }
		
        /// <summary>
        /// Expression for the property ValidityPeriodEndDatetime that represents the column validity_period_end_dttm.
        /// </summary>
        /// <value>
        /// The value of the property ValidityPeriodEndDatetime that represents the column validity_period_end_dttm.
        /// </value>
        public ColumnExpression ValidityPeriodEndDatetime 
        { 
            get { return this.columns[20]; } 
        }
		
        /// <summary>
        /// Expression for the property Verification that represents the column verf_code.
        /// </summary>
        /// <value>
        /// The value of the property Verification that represents the column verf_code.
        /// </value>
        public ColumnExpression Verification 
        { 
            get { return this.columns[21]; } 
        }
		
        /// <summary>
        /// Expression for the property VersionText that represents the column version_txt.
        /// </summary>
        /// <value>
        /// The value of the property VersionText that represents the column version_txt.
        /// </value>
        public ColumnExpression VersionText 
        { 
            get { return this.columns[22]; } 
        }
		
        /// <summary>
        /// Expression for the property SecurityClassificationId that represents the column security_clsfc_id.
        /// </summary>
        /// <value>
        /// The value of the property SecurityClassificationId that represents the column security_clsfc_id.
        /// </value>
        public ColumnExpression SecurityClassificationId 
        { 
            get { return this.columns[23]; } 
        }
		
        /// <summary>
        /// Expression for the property CreatorId that represents the column creator_id.
        /// </summary>
        /// <value>
        /// The value of the property CreatorId that represents the column creator_id.
        /// </value>
        public ColumnExpression CreatorId 
        { 
            get { return this.columns[24]; } 
        }
		
        /// <summary>
        /// Expression for the property UpdateSeqnr that represents the column update_seqnr.
        /// </summary>
        /// <value>
        /// The value of the property UpdateSeqnr that represents the column update_seqnr.
        /// </value>
        public ColumnExpression UpdateSeqnr 
        { 
            get { return this.columns[25]; } 
        }
		
        #endregion 

        #region - Constructors -
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceExpression"/> class.
        /// </summary>
        public ReferenceExpression()
            : base("Reference", typeof(IReference))
        {
        }

        #endregion
    }
}
