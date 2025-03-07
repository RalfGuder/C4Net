using System.Runtime.Serialization;
using C4Net.Core.Attributes;
using C4Net.Data.Attributes;


namespace C4Net.JC3IEDM.Enums
{
    /// <summary>
    /// The specific value that represents the physical name of the referenced table.
    /// </summary>
    [DomId(100004131)]
    [DataContract]
    public enum RptdEntCatEnum
    {
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000001)]
        [StringValue("ACTEFF")]
        [EnumMember]
        ActEffect,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000002)]
        [StringValue("ACTEVD")]
        [EnumMember]
        ActEventDet,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000003)]
        [StringValue("ACTEVS")]
        [EnumMember]
        ActEventStat,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000004)]
        [StringValue("ACTTST")]
        [EnumMember]
        ActTaskStat,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000005)]
        [StringValue("CTDAUT")]
        [EnumMember]
        CtgtdetAuth,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000006)]
        [StringValue("CTLIST")]
        [EnumMember]
        Ctgtlst,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000007)]
        [StringValue("CTLAUT")]
        [EnumMember]
        CtgtlstAuth,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000012)]
        [StringValue("HOLDNG")]
        [EnumMember]
        Holding,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000013)]
        [StringValue("OICAPA")]
        [EnumMember]
        ObjItemCapab,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000014)]
        [StringValue("OILOCA")]
        [EnumMember]
        ObjItemLoc,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000015)]
        [StringValue("OISTAT")]
        [EnumMember]
        ObjItemStat,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000016)]
        [StringValue("OITYPE")]
        [EnumMember]
        ObjItemType,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000024)]
        [StringValue("REQANS")]
        [EnumMember]
        RequestAns,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000025)]
        [StringValue("TPRSPR")]
        [EnumMember]
        TargetPrsnlProtect,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000026)]
        [StringValue("OIASST")]
        [EnumMember]
        ObjItemAssocStat,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000029)]
        [StringValue("OIADDR")]
        [EnumMember]
        ObjItemAddr,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000030)]
        [StringValue("OIAFFL")]
        [EnumMember]
        ObjItemAffl,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000031)]
        [StringValue("OIGRPA")]
        [EnumMember]
        ObjItemGroupAcct,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000032)]
        [StringValue("ORGSTR")]
        [EnumMember]
        OrgStruct,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000036)]
        [StringValue("ACTLOC")]
        [EnumMember]
        ActLoc,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000037)]
        [StringValue("NTSRST")]
        [EnumMember]
        NetwrkServiceStat,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000038)]
        [StringValue("OIHSTS")]
        [EnumMember]
        ObjItemHstlyStat,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000039)]
        [StringValue("HLDTRF")]
        [EnumMember]
        HoldingTrnsf,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000040)]
        [StringValue("CNTASS")]
        [EnumMember]
        ContxtAssess,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000041)]
        [StringValue("ACTCMT")]
        [EnumMember]
        ActCmt,
		
        /// <summary>
        /// 
        /// </summary>
        [DomValIx(1000042)]
        [StringValue("OICMT")]
        [EnumMember]
        ObjItemCmt,
		
    }
}
