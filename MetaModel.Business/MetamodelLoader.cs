using C4Net.Core.IoC;
using C4Net.Data;
using C4Net.Data.Adapters;
using C4Net.Data.Connections;
using C4Net.Data.Entity;
using C4Net.Metamodel.Entities;

namespace MetaModel.Business
{
    /// <summary>
    /// Class for the metamodel loader.
    /// </summary>
    public class MetamodelLoader : AllEntityDict
    {
        #region - Fields -

        /// <summary>
        /// The adapter
        /// </summary>
        private DataContext adapter = null;

        /// <summary>
        /// The MDB file name
        /// </summary>
        private string mdbFileName = string.Empty;

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="MetamodelLoader"/> class.
        /// </summary>
        public MetamodelLoader()
        {
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Sets the connection.
        /// </summary>
        /// <param name="mdbFileName">Name of the MDB file.</param>
        private void SetConnection(string mdbFileName) 
        {
            this.mdbFileName = mdbFileName;
            IDbConnectionManager connectionManager = DefaultContainer.Get<IDbConnectionManager>();
            DbConnectionInfo info = connectionManager.GetConnectionInfo("mdb");
            if (info == null)
            {
                info = new DbConnectionInfo();
                info.Name = "mdb";
                info.IsDefault = false;
                info.ProviderName = "OleDb";
                connectionManager.RegisterConnection(info);
            }
            info.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mdbFileName + ";Persist Security Info=False;";
            info.Initialize();
            adapter = new DataContext("mdb");
        }

        /// <summary>
        /// Loads the tables from.
        /// </summary>
        /// <param name="mdbFileName">Name of the MDB file.</param>
        /// <param name="includeMeta">if set to <c>true</c> [include meta].</param>
        public void LoadTablesFrom(string mdbFileName, bool includeMeta)
        {
            this.SetConnection(mdbFileName);
            this.Clear();
            if (includeMeta)
            {
                this.AddEntities(adapter.SelectList<Ent>(Ent._.OrderBy(Ent._.DepthCnt).OrderBy(Ent._.NameTxt)));
            }
            else
            {
                this.AddEntities(adapter.SelectList<Ent>(Ent._.ModLvlCode != "META" ^Ent._.DepthCnt ^Ent._.NameTxt));
            }
            this.AddEntities(adapter.SelectList<SubtRel>());
        }

        /// <summary>
        /// Loads the metamodel.
        /// </summary>
        public void LoadMetamodel()
        {
            this.Clear();
            this.AddEntities(adapter.SelectList<AkAttr>());
            this.AddEntities(adapter.SelectList<Attr>(Attr._.OrderBy(Attr._.EntId).OrderBy(Attr._.AttrSeqnrOrd)));
            this.AddEntities(adapter.SelectList<BaseAttr>());
            this.AddEntities(adapter.SelectList<Br>(Br._.OrderBy(Br._.BrId)));
            this.AddEntities(adapter.SelectList<BrEnt>(BrEnt._.OrderBy(BrEnt._.BrId).OrderBy(BrEnt._.BrEntIx)));
            this.AddEntities(adapter.SelectList<BrEntAttrComp>(BrEntAttrComp._.OrderBy(BrEntAttrComp._.BrId).OrderBy(BrEntAttrComp._.BrEntIx).OrderBy(BrEntAttrComp._.BrEntAttrCompIx)));
            this.AddEntities(adapter.SelectList<BrEntAttrCompDomVal>(BrEntAttrCompDomVal._.OrderBy(BrEntAttrCompDomVal._.BrId).OrderBy(BrEntAttrCompDomVal._.BrEntIx).OrderBy(BrEntAttrCompDomVal._.BrEntAttrCompIx).OrderBy(BrEntAttrCompDomVal._.BrEntAttrCompDomValIx)));
            this.AddEntities(adapter.SelectList<CardRel>());
            this.AddEntities(adapter.SelectList<Cat>());
            this.AddEntities(adapter.SelectList<CreatorUpdateIdentific>());
            this.AddEntities(adapter.SelectList<Dom>());
            this.AddEntities(adapter.SelectList<DomVal>());
            this.AddEntities(adapter.SelectList<Ent>(Ent._.OrderBy(Ent._.DepthCnt).OrderBy(Ent._.EntId)));
            this.AddEntities(adapter.SelectList<FkAttr>());
            this.AddEntities(adapter.SelectList<NkAttr>());
            this.AddEntities(adapter.SelectList<PkAttr>());
            this.AddEntities(adapter.SelectList<Rel>());
            this.AddEntities(adapter.SelectList<SubtRel>());
        }

        /// <summary>
        /// Gets the structured BO.
        /// </summary>
        /// <returns></returns>
        public StructuredBO GetStructuredBO()
        {
            StructuredBO result = new StructuredBO();
            // Load entities.
            foreach (Ent ent in this.GetDict<Ent>().Values)
            {
                result.AddEntity(ent);
            }
            // Load attributes
            foreach (Attr attr in this.GetDict<Attr>().Values)
            {
                result.AddAttribute(attr);
            }
            foreach (NkAttr nkAttr in this.GetDict<NkAttr>().Values)
            {
                result.AddNkAttribute(nkAttr);
            }
            foreach (FkAttr fkAttr in this.GetDict<FkAttr>().Values)
            {
                result.AddFkAttribute(fkAttr);
            }
            foreach (BaseAttr baseAttr in this.GetDict<BaseAttr>().Values)
            {
                result.AddBaseAttribute(baseAttr);
            }
            // Load domains
            foreach (Dom dom in this.GetDict<Dom>().Values)
            {
                result.AddDomain(dom);
            }
            foreach (DomVal domVal in this.GetDict<DomVal>().Values)
            {
                result.AddDomainValue(domVal);
            }
            // Load SubtypeRelations 
            foreach (SubtRel subtRel in this.GetDict<SubtRel>().Values)
            {
                result.AddSubtypeRelationship(subtRel);
            }
            foreach (Cat cat in this.GetDict<Cat>().Values)
            {
                result.AddCategory(cat);
            }
            foreach (CardRel rel in this.GetDict<CardRel>().Values)
            {
                result.AddCardinality(rel);
            }
            // Load business rules
            foreach (Br rule in this.GetDict<Br>().Values)
            {
                result.AddBusinessRule(rule);
            }
            foreach (BrEnt ruleEnt in this.GetDict<BrEnt>().Values)
            {
                result.AddBusinessRuleEnt(ruleEnt);
            }
            foreach (BrEntAttrComp ruleComp in this.GetDict<BrEntAttrComp>().Values)
            {
                result.AddBusinessRuleComposite(ruleComp);
            }
            foreach (BrEntAttrCompDomVal ruleVal in this.GetDict<BrEntAttrCompDomVal>().Values)
            {
                result.AddBusinessRuleValue(ruleVal);
            }
            result.BuildAttributes();
            return result;
        }

        #endregion
    }
}
