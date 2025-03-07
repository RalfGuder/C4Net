using System.Collections.Generic;
using C4Net.Core.Utils;
using C4Net.Data;
using C4Net.Data.Adapters;
using C4Net.Metamodel.Entities;
using C4Net.Templates;

namespace C4Net.Metamodel
{
    /// <summary>
    /// Class for loading the metamodel to structured classes, and then build a Template Container for being able
    /// to use the metamodel information with our template engine.
    /// </summary>
    public class ModelLoader
    {
        #region - Fields -

        /// <summary>
        /// The adapter.
        /// </summary>
        private DataContext adapter;

        /// <summary>
        /// The domain dictionary. The key is the primary key of each domain.
        /// </summary>
        private Dictionary<string, Dom> domains = new Dictionary<string, Dom>();

        /// <summary>
        /// The entity dictionary. The key is the primary key of each entity.
        /// </summary>
        private Dictionary<string, Ent> entities = new Dictionary<string, Ent>();

        /// <summary>
        /// The attribute dictionary. The key is the primary key of each attribute.
        /// </summary>
        private Dictionary<string, Attr> attributes = new Dictionary<string, Attr>();

        private Dictionary<string, CardRel> cardRelations = new Dictionary<string, CardRel>();

        private Dictionary<string, SubtRel> subtRelations = new Dictionary<string, SubtRel>();

        private Dictionary<string, Cat> categories = new Dictionary<string, Cat>();

        #endregion

        #region - Constructor -

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelLoader"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public ModelLoader(string connectionString = null)
        {
            adapter = new DataContext(connectionString);
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Loads the domains.
        /// </summary>
        private void LoadDomains()
        {
            IList<Dom> list = (IList<Dom>)adapter.SelectList<Dom>(Dom._.OrderBy(Dom._.DomId));
            foreach (Dom dom in list)
            {
                domains.Add(adapter.GetPrimaryKeyStr<Dom>(dom), dom);
            }
            this.LoadDomainValues();
        }

        /// <summary>
        /// Loads the domain values.
        /// </summary>
        private void LoadDomainValues()
        {
            IList<DomVal> list = (IList<DomVal>)adapter.SelectList<DomVal>(DomVal._.OrderBy(DomVal._.DomId).OrderBy(DomVal._.DomValIx));
            foreach (DomVal val in list)
            {
                string key = adapter.GetOneKeyStr(val.DomId);
                if (domains.ContainsKey(key))
                {
                    domains[key].DomVals.Add(val);
                }
            }
        }

        /// <summary>
        /// Loads the entities.
        /// </summary>
        private void LoadEntities()
        {
            IList<Ent> list = (IList<Ent>)adapter.SelectList<Ent>(Ent._.OrderBy(Ent._.EntId));
            foreach (Ent item in list)
            {
                entities.Add(adapter.GetPrimaryKeyStr<Ent>(item), item);
            }
            this.LoadAttributes();
        }

        /// <summary>
        /// Loads the attributes.
        /// </summary>
        private void LoadAttributes()
        {
            IList<Attr> list = (IList<Attr>)adapter.SelectList<Attr>(Attr._.OrderBy(Attr._.EntId).OrderBy(Attr._.AttrSeqnrOrd).OrderBy(Attr._.AttrIx));
            Attr lastAttr = null;
            foreach (Attr item in list)
            {
                if (lastAttr != null)
                {
                    if ((item.EntId == lastAttr.EntId) && (item.AttrSeqnrOrd == lastAttr.AttrSeqnrOrd))
                    {
                        continue;
                    }
                }
                lastAttr = item;
                attributes.Add(adapter.GetPrimaryKeyStr<Attr>(item), item);
                string key = adapter.GetOneKeyStr(item.EntId);
                if (entities.ContainsKey(key))
                {
                    entities[key].Attributes.Add(item);
                }
            }
            this.LoadBaseAttributes();
            this.LoadFKAttributes();
            this.LoadNKAttributes();
        }

        /// <summary>
        /// Loads the base attributes.
        /// </summary>
        private void LoadBaseAttributes()
        {
            IList<BaseAttr> list = (IList<BaseAttr>)adapter.SelectList<BaseAttr>();
            foreach (BaseAttr item in list)
            {
                string key = adapter.GetPrimaryKeyStr<BaseAttr>(item);
                if (attributes.ContainsKey(key))
                {
                    attributes[key].BaseAttr = item;
                }
            }
        }

        /// <summary>
        /// Loads the FK attributes.
        /// </summary>
        private void LoadFKAttributes()
        {
            IList<FkAttr> list = (IList<FkAttr>)adapter.SelectList<FkAttr>();
            foreach (FkAttr item in list)
            {
                string key = adapter.GetPrimaryKeyStr<FkAttr>(item);
                if (attributes.ContainsKey(key))
                {
                    attributes[key].FkAttr = item;
                }
            }
        }

        /// <summary>
        /// Loads the NK attributes.
        /// </summary>
        private void LoadNKAttributes()
        {
            IList<NkAttr> list = (IList<NkAttr>)adapter.SelectList<NkAttr>();
            foreach (NkAttr item in list)
            {
                string key = adapter.GetPrimaryKeyStr<NkAttr>(item);
                if (attributes.ContainsKey(key))
                {
                    attributes[key].NkAttr = item;
                }
            }
        }

        private void LoadSubtRelations()
        {
            IList<SubtRel> list = (IList<SubtRel>)adapter.SelectList<SubtRel>(SubtRel._.RelIx == 1 & SubtRel._.CatIx == 1 ^ SubtRel._.SupEntId ^ SubtRel._.SubEntId);
            foreach (SubtRel item in list)
            {
                string key = adapter.GetPrimaryKeyStr<SubtRel>(item);
                this.subtRelations.Add(key, item);
            }
        }

        private void LoadCardRelations()
        {
            IList<CardRel> list = (IList<CardRel>)adapter.SelectList<CardRel>();
            foreach (CardRel item in list)
            {
                string key = adapter.GetPrimaryKeyStr<CardRel>(item);
                this.cardRelations.Add(key, item);
            }
        }

        private void LoadCategories()
        {
            IList<Cat> list = (IList<Cat>)adapter.SelectList<Cat>(Cat._.CatIx == 1 ^ Cat._.SupEntId);
            foreach (Cat item in list)
            {
                string key = adapter.GetPrimaryKeyStr<Cat>(item);
                this.categories.Add(key, item);
            }
        }

        private void LoadRelations()
        {
            this.LoadSubtRelations();
            this.LoadCardRelations();
            this.LoadCategories();
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            this.domains.Clear();
            this.entities.Clear();
            this.subtRelations.Clear();
            this.cardRelations.Clear();
        }

        /// <summary>
        /// Loads this instance.
        /// </summary>
        public void Load()
        {
            this.Clear();
            this.LoadDomains();
            this.LoadEntities();
            this.LoadRelations();
        }

        /// <summary>
        /// Fills one enumerated domain into the container.
        /// </summary>
        /// <param name="dom">The enumerated domain.</param>
        /// <param name="container">The container.</param>
        private void FillEnumerated(Dom dom, TemplateContainer container)
        {
            container.AddAttribute("DomId", dom.DomId.ToString());
            container.AddAttribute("LogicalName", dom.NameTxt);
            if (dom.NameTxt.EndsWith("-code"))
            {
                container.AddAttribute("Name", StringUtil.Pascalize(dom.NameTxt.Remove(dom.NameTxt.Length - 5, 5)) + "Enum");
            }
            else
            {
                container.AddAttribute("Name", StringUtil.Pascalize(dom.NameTxt) + "Enum");
            }
            container.AddAttribute("Definition", dom.DefTxt);
            container.AddAttribute("ClassName", dom.ClassNameTxt);
            container.AddAttribute("MeasurementUnit", dom.MeasUnitDescrTxt);
            container.AddAttribute("ParentDomId", dom.PaDomId.ToString());
            container.AddAttribute("StandardisationLevel", dom.StdnLvlCode);
            container.AddAttribute("ModelLevel", dom.ModLvlCode);
            container.AddAttribute("DefinitionSource", dom.DefSrcTxt);
            TemplateContainer rootvalContainer = container.AddSon("Values");
            foreach (DomVal val in dom.DomVals)
            {
                TemplateContainer valContainer = rootvalContainer.AddArrayValue();
                valContainer.AddAttribute("DomId", val.DomId.ToString());
                valContainer.AddAttribute("DomValIx", val.DomValIx.ToString());
                valContainer.AddAttribute("Description", val.DescrTxt);
                valContainer.AddAttribute("LogicalName", val.NameTxt);
                string name = StringUtil.Pascalize(val.NameTxt);
                int number;
                if (int.TryParse(name.Substring(0, 1), out number))
                {
                    name = "_" + name;
                }
                valContainer.AddAttribute("Name", name);
                valContainer.AddAttribute("Definition", val.DefTxt);
                container.AddAttribute("StandardisationLevel", val.StdnLvlCode);
                container.AddAttribute("Source", val.SrcTxt);
            }
        }

        /// <summary>
        /// Fills the enumerated domains into a container.
        /// </summary>
        /// <param name="root">The root.</param>
        private void FillEnumeratedDomains(TemplateContainer root)
        {
            TemplateContainer enumDomainsContainer = root.AddSon("Enumerateds");
            foreach (Dom dom in domains.Values)
            {
                if ((dom.RestrTypeCode != null) && (dom.RestrTypeCode.Equals("EN")) && (dom.DomVals.Count > 0))
                {
                    this.FillEnumerated(dom, enumDomainsContainer.AddArrayValue());
                }
            }
        }

        private string GetBaseNetType(BaseAttr attr)
        {
            if (attr.DataTypeCode.Equals("VARCHAR"))
            {
                return "string";
            }
            if (attr.DataTypeCode.Equals("NUMBER"))
            {
                if (attr.DataDecCnt > 0)
                {
                    return "double";
                }
                else
                {
                    if (attr.DataLenCnt > 18)
                    {
                        return "decimal";
                    }
                    else if (attr.DataLenCnt > 9)
                    {
                        return "long";
                    }
                    else if (attr.DataLenCnt > 4)
                    {
                        return "int";
                    }
                    else
                    {
                        return "short";
                    }
                }
            }
            return "string";
        }

        private string GetSQLServerType(BaseAttr attr)
        {
            if (attr.DataTypeCode.Equals("VARCHAR"))
            {
                return "[NVARCHAR](" + attr.DataLenCnt.ToString() + ")";
            }
            if (attr.DataTypeCode.Equals("NUMBER"))
            {
                return "[NUMERIC](" + attr.DataLenCnt.ToString() + "," + attr.DataDecCnt.ToString() + ")";
            }
            if (attr.DataTypeCode.Equals("CHAR"))
            {
                return "[CHAR](" + attr.DataLenCnt.ToString() + ")";
            }
            return "";
        }

        private string GetNetType(BaseAttr baseAttr)
        {
            string domKey = adapter.GetOneKeyStr(baseAttr.DomId);
            if (this.domains.ContainsKey(domKey))
            {
                Dom dom = this.domains[domKey];
                if ((dom.RestrTypeCode != null) && (dom.RestrTypeCode.Equals("EN")) && (dom.DomVals.Count > 0))
                {
                    if (dom.NameTxt.EndsWith("-code"))
                    {
                        return StringUtil.Pascalize(dom.NameTxt.Remove(dom.NameTxt.Length - 5, 5)) + "Enum";
                    }
                    else
                    {
                        return StringUtil.Pascalize(dom.NameTxt) + "Enum";
                    }
                }
            }
            if (baseAttr.DataTypeCode.Equals("VARCHAR"))
            {
                return "string";
            }
            if (baseAttr.DataTypeCode.Equals("NUMBER"))
            {
                if (baseAttr.DataDecCnt > 0)
                {
                    return "double";
                }
                else
                {
                    if (baseAttr.DataLenCnt > 18)
                    {
                        return "decimal";
                    }
                    else if (baseAttr.DataLenCnt > 9)
                    {
                        return "long";
                    }
                    else if (baseAttr.DataLenCnt > 4)
                    {
                        return "int";
                    }
                    else
                    {
                        return "short";
                    }
                }
            }
            return "string";
        }

        private string GetNetType(Attr attr, BaseAttr baseAttr)
        {
            string result = this.GetNetType(baseAttr);
            if ((result.Equals("string")) || (attr.PkIndCode.Equals("PK")) || (attr.NkAttr.OptIndCode.Equals("MA")))
            {
                return result;
            }
            return result + "?";
        }

        private string GetAttributeName(Attr attr, BaseAttr baseAttr)
        {
            string result = StringUtil.Pascalize(attr.NameTxt);
            if (attr.NameTxt.Equals("physical model only"))
            {
                return StringUtil.Pascalize(attr.ColNameTxt);
            }
            string domKey = adapter.GetOneKeyStr(baseAttr.DomId);
            if (this.domains.ContainsKey(domKey))
            {
                Dom dom = this.domains[domKey];
                if ((dom.RestrTypeCode != null) && (dom.RestrTypeCode.Equals("EN")) && (dom.DomVals.Count > 0))
                {
                    if (attr.NameTxt.EndsWith("-code"))
                    {
                        result = StringUtil.Pascalize(attr.NameTxt.Remove(attr.NameTxt.Length - 5, 5));
                    }
                }
            }
            string entPk = adapter.GetOneKeyStr(attr.EntId);
            if (this.entities.ContainsKey(entPk))
            {
                Ent ent = this.entities[entPk];
                string entName = StringUtil.Pascalize(ent.NameTxt);
                if (result.StartsWith(entName))
                {
                    string newResult = result.Remove(0, entName.Length);
                    if (newResult != string.Empty)
                    {
                        result = newResult;
                    }
                }
                if (result.Equals(entName))
                {
                    result = result + "Code";
                }
            }
            return result;
        }

        private bool AttributeExistsInParent(string name, Ent paEnt)
        {
            if (paEnt == null)
            {
                return false;
            }
            foreach (Attr attr in paEnt.Attributes)
            {
                BaseAttr baseAttr;
                if (attr.FkIndCode.Equals("FK"))
                {
                    baseAttr = this.attributes[adapter.GetKeyStr(new object[] { attr.FkAttr.BaseEntId, attr.FkAttr.BaseAttrIx })].BaseAttr;
                }
                else
                {
                    baseAttr = attr.BaseAttr;
                }
                string attrName = this.GetAttributeName(attr, baseAttr);
                if (name.Equals(attrName))
                {
                    return true;
                }
            }
            return false;
        }

        private void FillAttribute(Attr attr, TemplateContainer container, Ent paEnt)
        {
            container.AddAttribute("EntId", attr.EntId.ToString());
            container.AddAttribute("AttrIx", attr.AttrIx.ToString());
            container.AddAttribute("LogicalName", attr.NameTxt);
            container.AddAttribute("PhysicalName", attr.ColNameTxt);
            container.AddAttribute("SequenceNumber", attr.AttrSeqnrOrd.ToString());
            container.AddAttribute("StandardisationLevel", attr.StdnLvlCode);
            if (attr.PkIndCode.Equals("PK"))
            {
                container.AddAttribute("IsPrimaryKey", "true");
                container.AddAttribute("IsMandatory", "true");
            }
            else
            {
                container.AddAttribute("IsPrimaryKey", "false");
                container.AddAttribute("IsMandatory", attr.NkAttr.OptIndCode.Equals("MA").ToString().ToLower());
            }
            BaseAttr baseAttr;
            if (attr.FkIndCode.Equals("FK"))
            {
                container.AddAttribute("IsForeignKey", "true");
                string baseAttrPk = adapter.GetKeyStr(new object[] { attr.FkAttr.BaseEntId, attr.FkAttr.BaseAttrIx });
                if (this.attributes.ContainsKey(baseAttrPk))
                {
                    baseAttr = this.attributes[baseAttrPk].BaseAttr;
                }
                else
                {
                    baseAttr = null;
                }
            }
            else
            {
                container.AddAttribute("IsForeignKey", "false");
                baseAttr = attr.BaseAttr;
            }
            container.AddAttribute("BaseEntId", baseAttr.EntId.ToString());
            container.AddAttribute("BaseAttrIx", baseAttr.AttrIx.ToString());
            container.AddAttribute("Definition", baseAttr.DefTxt);
            container.AddAttribute("DataType", baseAttr.DataTypeCode);
            container.AddAttribute("DataLength", baseAttr.DataLenCnt.ToString());
            container.AddAttribute("DataDecimals", baseAttr.DataDecCnt.ToString());
            container.AddAttribute("DomId", baseAttr.DomId.ToString());
            container.AddAttribute("NetType", this.GetNetType(attr, baseAttr));
            container.AddAttribute("BaseNetType", this.GetBaseNetType(baseAttr));
            container.AddAttribute("SQLServerType", this.GetSQLServerType(baseAttr));
            container.AddAttribute("Name", this.GetAttributeName(attr, baseAttr));
            container.AddAttribute("ExistsInParent", this.AttributeExistsInParent(this.GetAttributeName(attr, baseAttr), paEnt).ToString());
            container.AddAttribute("IsCategory", "false");
        }

        private SubtRel GetSubtRel(List<SubtRel> subtRels, double domValIx)
        {
            foreach (SubtRel item in subtRels)
            {
                if (item.DomValIx == domValIx)
                {
                    return item;
                }
            }
            return null;
        }

        private void FillAttribute(Attr attr, TemplateContainer container, Ent paEnt, List<SubtRel> subtRels, bool isComplete)
        {
            this.FillAttribute(attr, container, paEnt);
            container.AddAttribute("IsCategory", "true");
            TemplateContainer sonContainer = container.AddSon("Subtypes");
            Dom dom = this.domains[adapter.GetOneKeyStr(subtRels[0].DomId)];
            string defEnum = string.Empty;
            foreach (DomVal val in dom.DomVals)
            {
                SubtRel rel = this.GetSubtRel(subtRels, val.DomValIx);
                if (rel != null)
                {
                    TemplateContainer itemContainer = sonContainer.AddArrayValue();
                    string name = StringUtil.Pascalize(val.NameTxt);
                    int number;
                    if (int.TryParse(name.Substring(0, 1), out number))
                    {
                        name = "_" + name;
                    }
                    Ent subEnt = this.entities[adapter.GetOneKeyStr(rel.SubEntId)];
                    itemContainer.AddAttribute("EntName", StringUtil.Pascalize(subEnt.NameTxt));
                    itemContainer.AddAttribute("EnumValue", name);
                }
            }
            if (defEnum == string.Empty)
            {
                string name = StringUtil.Pascalize(dom.DomVals[dom.DomVals.Count - 1].NameTxt);
                int number;
                if (int.TryParse(name.Substring(0, 1), out number))
                {
                    name = "_" + name;
                }
                defEnum = name;
            }
            container.AddAttribute("DefEnum", defEnum);
        }

        private Ent GetInheritsFrom(Ent ent)
        {
            foreach (SubtRel subtRel in this.subtRelations.Values)
            {
                if (subtRel.SubEntId == ent.EntId)
                {
                    string key = this.adapter.GetOneKeyStr(subtRel.SupEntId);
                    return this.entities[key];
                }
            }
            return null;
        }

        private Cat GetEntCat(Ent ent)
        {
            foreach (Cat cat in this.categories.Values)
            {
                if (cat.SupEntId == ent.EntId)
                {
                    return cat;
                }
            }
            return null;
        }

        private void FillEntity(Ent ent, TemplateContainer container)
        {
            container.AddAttribute("EntId", ent.EntId.ToString());
            container.AddAttribute("LogicalName", ent.NameTxt);
            container.AddAttribute("PhysicalName", ent.TabNameTxt);
            container.AddAttribute("Name", StringUtil.Pascalize(ent.NameTxt));
            container.AddAttribute("Definition", ent.DefTxt);
            container.AddAttribute("DependencyCode", ent.DepenCode);
            container.AddAttribute("Depth", ent.DepthCnt.ToString());
            container.AddAttribute("StorageType", ent.StgTypeCode);
            container.AddAttribute("StandardisationLevel", ent.StdnLvlCode);
            container.AddAttribute("ModelLevel", ent.ModLvlCode);
            if (ent.TabNameTxt == "ATTR")
            {
                container.AddAttribute("PKName", "PK_ATTR_PK");
            }
            else
            {
                container.AddAttribute("PKName", "PK_" + StringUtil.Pascalize(ent.TabNameTxt));
            }
            Ent paEnt = this.GetInheritsFrom(ent);
            if (paEnt != null)
            {
                container.AddAttribute("InheritsFrom", StringUtil.Pascalize(paEnt.NameTxt));
            }
            else
            {
                container.AddAttribute("InheritsFrom", "");
            }
            TemplateContainer attributeContainer = container.AddSon("Attributes");
            TemplateContainer pkAttributeContainer = container.AddSon("PKAttributes");
            List<SubtRel> subtRels = new List<SubtRel>();
            foreach (SubtRel item in this.subtRelations.Values)
            {
                if (item.SupEntId == ent.EntId)
                {
                    subtRels.Add(item);
                }
            }
            Cat cat = this.GetEntCat(ent);
            foreach (Attr attr in ent.Attributes)
            {
                if ((cat != null) && (cat.DiscrIx == attr.AttrIx))
                {
                    this.FillAttribute(attr, attributeContainer.AddArrayValue(), paEnt, subtRels, cat.ComplIndCode.Equals("CC"));
                }
                else
                {
                    this.FillAttribute(attr, attributeContainer.AddArrayValue(), paEnt);
                }
                if (attr.PkIndCode.Equals("PK"))
                {
                    this.FillAttribute(attr, pkAttributeContainer.AddArrayValue(), paEnt);
                }
            }
            // Foreign keys.
            List<Attr> fkAttr = new List<Attr>();
            int numFks = 0;
            foreach (Attr attr in ent.Attributes)
            {
                if (attr.FkAttr != null)
                {
                    fkAttr.Add(attr);
                    if (attr.FkAttr.MigrRelIx > numFks)
                    {
                        numFks = (int)attr.FkAttr.MigrRelIx;
                    }
                }
            }
            if (paEnt != null)
            {
                TemplateContainer catKeysContainer = container.AddSon("CatForeignKeys");
                catKeysContainer.AddAttribute("ParentTable", paEnt.TabNameTxt);
                string pkFields = string.Empty;
                string fkFields = string.Empty;
                foreach (Attr attr in ent.Attributes)
                {
                    if ((attr.FkAttr != null) && (attr.FkAttr.SrcEntId == paEnt.EntId))
                    {
                        if (pkFields != string.Empty)
                        {
                            pkFields = pkFields + ", ";
                        }
                        pkFields = pkFields + "["+attr.ColNameTxt+"]";
                        foreach (Attr srcAttr in paEnt.Attributes)
                        {
                            if (srcAttr.AttrIx == attr.FkAttr.SrcAttrIx)
                            {
                                if (fkFields != string.Empty)
                                {
                                    fkFields = fkFields + ", ";
                                }
                                fkFields = fkFields + "["+srcAttr.ColNameTxt+"]";
                            }
                        }
                    }
                }
                catKeysContainer.AddAttribute("PkColumns", pkFields);
                catKeysContainer.AddAttribute("FkColumns", fkFields);
            }
        }

        private void FillEntities(TemplateContainer root)
        {
            TemplateContainer entitiesContainer = root.AddSon("Entities");
            foreach (Ent ent in this.entities.Values)
            {
                this.FillEntity(ent, entitiesContainer.AddArrayValue());
            }
        }

        /// <summary>
        /// Gets the container.
        /// </summary>
        /// <returns></returns>
        public TemplateContainer GetContainer()
        {
            TemplateContainer result = new TemplateContainer(null);
            this.FillEnumeratedDomains(result);
            this.FillEntities(result);
            return result;
        }

        #endregion
    }
}
