using System;
using System.Collections.Generic;
using C4Net.Core.Utils;
using C4Net.Metamodel.Entities;
using C4Net.Templates;

namespace MetaModel.Business
{
    /// <summary>
    /// Class for the Metamodel Structure Business Object.
    /// </summary>
    public class StructuredBO
    {
        #region - Fields -

        /// <summary>
        /// All entities
        /// </summary>
        private List<EntityBO> allEntities = new List<EntityBO>();

        /// <summary>
        /// The entity index
        /// </summary>
        private Dictionary<decimal, int> entityIndex = new Dictionary<decimal, int>();

        /// <summary>
        /// The attributes
        /// </summary>
        private Dictionary<string, AttributeBO> attributes = new Dictionary<string, AttributeBO>();

        /// <summary>
        /// All domains
        /// </summary>
        private List<DomainBO> allDomains = new List<DomainBO>();

        /// <summary>
        /// The domain index
        /// </summary>
        private Dictionary<int, int> domainIndex = new Dictionary<int, int>();

        /// <summary>
        /// All business rules
        /// </summary>
        private List<BusinessRuleBO> allBusinessRules = new List<BusinessRuleBO>();

        /// <summary>
        /// The business rules index
        /// </summary>
        private Dictionary<long, int> businessRulesIndex = new Dictionary<long, int>();

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets all entities.
        /// </summary>
        /// <value>
        /// All entities.
        /// </value>
        public List<EntityBO> AllEntities
        {
            get { return this.allEntities; }
        }

        /// <summary>
        /// Gets all domains.
        /// </summary>
        /// <value>
        /// All domains.
        /// </value>
        public List<DomainBO> AllDomains
        {
            get { return this.allDomains; }
        }

        #endregion

        #region - Constructors -

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredBO"/> class.
        /// </summary>
        public StructuredBO()
        {
        }

        #endregion

        #region - Methods -

        /// <summary>
        /// Adds the entity.
        /// </summary>
        /// <param name="ent">The ent.</param>
        public void AddEntity(Ent ent)
        {
            EntityBO item = new EntityBO(ent);
            this.allEntities.Add(item);
            this.entityIndex.Add(item.EntId, this.allEntities.Count - 1);
        }

        /// <summary>
        /// Gets the entity by id.
        /// </summary>
        /// <param name="entId">The ent id.</param>
        /// <returns></returns>
        public EntityBO GetEntityById(decimal entId)
        {
            return this.allEntities[this.entityIndex[entId]];
        }

        /// <summary>
        /// Gets the domain by id.
        /// </summary>
        /// <param name="domId">The DOM id.</param>
        /// <returns></returns>
        public DomainBO GetDomainById(int domId)
        {
            return this.allDomains[this.domainIndex[domId]];
        }

        /// <summary>
        /// Gets the rule by id.
        /// </summary>
        /// <param name="ruleId">The rule id.</param>
        /// <returns></returns>
        public BusinessRuleBO GetRuleById(long ruleId)
        {
            return this.allBusinessRules[this.businessRulesIndex[ruleId]];
        }

        /// <summary>
        /// Adds the attribute.
        /// </summary>
        /// <param name="attr">The attr.</param>
        public void AddAttribute(Attr attr)
        {
            AttributeBO attribute = new AttributeBO(attr);
            EntityBO entity = this.GetEntityById(attribute.EntId);
            entity.AddAttribute(attribute);
            this.attributes.Add(attribute.EntId.ToString() + "." + attribute.AttrIx.ToString(), attribute);
        }

        /// <summary>
        /// Adds the nk attribute.
        /// </summary>
        /// <param name="nkAttr">The nk attr.</param>
        public void AddNkAttribute(NkAttr nkAttr)
        {
            AttributeBO attribute = this.attributes[nkAttr.EntId.ToString() + "." + nkAttr.AttrIx.ToString()];
            attribute.LoadNkAttr(nkAttr);
        }

        /// <summary>
        /// Adds the fk attribute.
        /// </summary>
        /// <param name="fkAttr">The fk attr.</param>
        public void AddFkAttribute(FkAttr fkAttr)
        {
            AttributeBO attribute = this.attributes[fkAttr.HostEntId.ToString() + "." + fkAttr.AttrIx.ToString()];
            attribute.LoadFkAttr(fkAttr);
        }

        /// <summary>
        /// Adds the base attribute.
        /// </summary>
        /// <param name="baseAttr">The base attr.</param>
        public void AddBaseAttribute(BaseAttr baseAttr)
        {
            AttributeBO attribute = this.attributes[baseAttr.EntId.ToString() + "." + baseAttr.AttrIx.ToString()];
            attribute.LoadBaseAttr(baseAttr);
        }

        /// <summary>
        /// Adds the domain.
        /// </summary>
        /// <param name="dom">The DOM.</param>
        public void AddDomain(Dom dom)
        {
            DomainBO domain = new DomainBO(dom);
            this.allDomains.Add(domain);
            this.domainIndex.Add(domain.DomId, this.allDomains.Count - 1);
        }

        /// <summary>
        /// Adds the domain value.
        /// </summary>
        /// <param name="domVal">The DOM val.</param>
        public void AddDomainValue(DomVal domVal)
        {
            DomainBO domain = this.GetDomainById(Convert.ToInt32(domVal.DomId));
            if (domVal.TypeCode.Equals("MIN-IN"))
            {
                domain.AddMin(domVal);
            }
            else if (domVal.TypeCode.Equals("MAX-IN"))
            {
                domain.AddMax(domVal);
            }
            else
            {
                domain.AddEnum(domVal);
            }
        }

        /// <summary>
        /// Adds the subtype relationship.
        /// </summary>
        /// <param name="subtRel">The subt rel.</param>
        public void AddSubtypeRelationship(SubtRel subtRel)
        {
            EntityBO parentEntity = this.GetEntityById(Convert.ToDecimal(subtRel.SupEntId));
            EntityBO childEntity = this.GetEntityById(Convert.ToDecimal(subtRel.SubEntId));
            parentEntity.AddSubtype(childEntity, Convert.ToInt32(subtRel.DomId), Convert.ToInt64(subtRel.DomValIx));
        }

        /// <summary>
        /// Adds the category.
        /// </summary>
        /// <param name="cat">The cat.</param>
        public void AddCategory(Cat cat)
        {
            EntityBO entity = this.GetEntityById(Convert.ToDecimal(cat.SupEntId));
            entity.SubtypeAttributeIx = Convert.ToDecimal(cat.DiscrIx);
            entity.SubtypeIsComplete = cat.ComplIndCode.Equals("CC");
        }

        /// <summary>
        /// Adds the cardinality.
        /// </summary>
        /// <param name="rel">The rel.</param>
        public void AddCardinality(CardRel rel)
        {
            EntityBO parentEntity = this.GetEntityById(Convert.ToDecimal(rel.PaEntId));
            EntityBO childEntity = this.GetEntityById(Convert.ToDecimal(rel.ChEntId));
            CardinalityRelBO cardinality = new CardinalityRelBO(rel, parentEntity, childEntity);
            parentEntity.CardinalitySons.Add(cardinality);
            childEntity.CardinalityParents.Add(cardinality);
        }

        /// <summary>
        /// Adds the business rule.
        /// </summary>
        /// <param name="rule">The rule.</param>
        public void AddBusinessRule(Br rule)
        {
            BusinessRuleBO businessRule = new BusinessRuleBO(rule);
            this.allBusinessRules.Add(businessRule);
            this.businessRulesIndex.Add(businessRule.RuleId, this.allBusinessRules.Count - 1);
        }

        /// <summary>
        /// Adds the business rule ent.
        /// </summary>
        /// <param name="ruleEnt">The rule ent.</param>
        public void AddBusinessRuleEnt(BrEnt ruleEnt)
        {
            BusinessRuleBO rule = this.GetRuleById(Convert.ToInt64(ruleEnt.BrId));
            if (rule.EntityOfInterest == null)
            {
                EntityBO entity = this.GetEntityById(Convert.ToDecimal(ruleEnt.EntOfInterestId));
                rule.LoadEnt(entity);
            }
        }

        /// <summary>
        /// Adds the business rule composite.
        /// </summary>
        /// <param name="ruleComp">The rule comp.</param>
        public void AddBusinessRuleComposite(BrEntAttrComp ruleComp)
        {
            BusinessRuleBO rule = this.GetRuleById(Convert.ToInt64(ruleComp.BrId));
            AttributeBO attribute = this.attributes[ruleComp.EntId.ToString() + "." + ruleComp.AttrIx.ToString()];
            if (!rule.Attributes.Contains(attribute))
            {
                rule.LoadAttribute(attribute, ruleComp.NullIndCode.Equals("YES"));
            }
        }

        /// <summary>
        /// Adds the business rule value.
        /// </summary>
        /// <param name="ruleVal">The rule val.</param>
        public void AddBusinessRuleValue(BrEntAttrCompDomVal ruleVal)
        {
            BusinessRuleBO rule = this.GetRuleById(Convert.ToInt64(ruleVal.BrId));
            DomainBO domain = this.GetDomainById(Convert.ToInt32(ruleVal.DomId));
            DomainValueBO domainValue = domain.GetDomainValue(Convert.ToInt32(ruleVal.DomValIx));
            rule.AddValue(domainValue);
        }

        /// <summary>
        /// Builds the attributes.
        /// </summary>
        public void BuildAttributes()
        {
            foreach (AttributeBO attribute in this.attributes.Values)
            {
                if (attribute.IsForeignKey)
                {
                    attribute.BaseAttribute = this.attributes[attribute.BaseEntId.ToString() + "." + attribute.BaseAttrIx.ToString()];
                    attribute.BaseEntId = attribute.BaseAttribute.EntId;
                    attribute.BaseAttrIx = attribute.BaseAttribute.AttrIx;
                    attribute.BaseDataDecimals = attribute.BaseAttribute.BaseDataDecimals;
                    attribute.BaseDataLength = attribute.BaseAttribute.BaseDataLength;
                    attribute.BaseDataType = attribute.BaseAttribute.BaseDataType;
                    attribute.BaseDefinition = attribute.BaseAttribute.BaseDefinition;
                    attribute.BaseDomId = attribute.BaseAttribute.BaseDomId;
                    attribute.SourceAttribute = this.attributes[attribute.SrcEntId.ToString() + "." + attribute.SrcAttrIx.ToString()];
                    attribute.BaseDomId = attribute.BaseAttribute.BaseDomId;
                }
                else
                {
                    attribute.SourceAttribute = null;
                    attribute.BaseAttribute = attribute;
                }
                attribute.Domain = this.allDomains[this.domainIndex[attribute.BaseDomId]];
            }
        }

        /// <summary>
        /// Selects the table.
        /// </summary>
        /// <param name="entId">The ent id.</param>
        public void SelectTable(decimal entId)
        {
            EntityBO entity = this.GetEntityById(entId);
            entity.Select();
        }

        private void GenerateDomainValue(TemplateContainer root, DomainValueBO domainValue)
        {
            root.AddAttribute("DomId", domainValue.DomainId.ToString());
            root.AddAttribute("DomValIx", domainValue.DomValIx.ToString());
            root.AddAttribute("Description", domainValue.Description);
            root.AddAttribute("LogicalName", domainValue.Name);
            string name = StringUtil.Pascalize(domainValue.Name);
            int number;
            if (int.TryParse(name.Substring(0, 1), out number))
            {
                name = "_" + name;
            }
            root.AddAttribute("Name", name);
            root.AddAttribute("Definition", domainValue.Definition);
            root.AddAttribute("StandardisationLevel", domainValue.StandardisationLevel);
            root.AddAttribute("Source", domainValue.SourceText);
        }

        private void GenerateDomain(TemplateContainer root, DomainBO domain)
        {
            root.AddAttribute("DomId", domain.DomId.ToString());
            root.AddAttribute("LogicalName", domain.Name);
            string name = StringUtil.Pascalize(domain.Name);
            if (name.EndsWith("Code"))
            {
                name = name.Remove(name.Length - 4, 4);
            }
            if (domain.IsEnumerated)
            {
                name = name + "Enum";
            }
            root.AddAttribute("Name", name);
            root.AddAttribute("Definition", domain.Definition);
            root.AddAttribute("ClassName", domain.ClassName);
            root.AddAttribute("MeasurementUnit", domain.MeasurementUnit);
            root.AddAttribute("ParentDomId", domain.ParentDomId.ToString());
            root.AddAttribute("StandardisationLevel", domain.StandardisationLevel);
            root.AddAttribute("ModelLevel", domain.ModelLevel);
            root.AddAttribute("DefinitionSource", domain.DefinitionSource);
            if (domain.IsRange)
            {
                root.AddAttribute("MinValue", domain.MinValue);
                root.AddAttribute("MaxValue", domain.MaxValue);
            }
            if (domain.IsEnumerated)
            {
                TemplateContainer valuesContainer = root.AddSon("Values");
                foreach (DomainValueBO domainValue in domain.Enumerateds)
                {
                    this.GenerateDomainValue(valuesContainer.AddArrayValue(), domainValue);
                }
            }
        }

        private void GenerateDomains(TemplateContainer root)
        {
            TemplateContainer domainContainer = root.AddSon("Domains");
            TemplateContainer enumContainer = root.AddSon("Enumerateds");
            TemplateContainer rangeContainer = root.AddSon("Ranges");
            foreach (DomainBO domain in this.allDomains)
            {
                if (domain.Selected)
                {
                    this.GenerateDomain(domainContainer.AddArrayValue(), domain);
                    if (domain.IsEnumerated)
                    {
                        this.GenerateDomain(enumContainer.AddArrayValue(), domain);  
                    }
                    if (domain.IsRange)
                    {
                        this.GenerateDomain(rangeContainer.AddArrayValue(), domain);
                    }
                }
            }
        }

        private string GetPkName(string name)
        {
            if (name.Equals("ATTR"))
            {
                return "PK_ATTR_PK";
            }
            return "PK_" + StringUtil.Pascalize(name);
        }

        private void GenerateTable(TemplateContainer root, EntityBO table)
        {
            root.AddAttribute("EntId", table.EntId.ToString());
            root.AddAttribute("LogicalName", table.Name);
            root.AddAttribute("PhysicalName", table.TableName);
            root.AddAttribute("Name", StringUtil.Pascalize(table.Name));
            root.AddAttribute("Definition", table.Definition);
            root.AddAttribute("DependencyCode", table.Dependency);
            root.AddAttribute("Depth", table.Depth.ToString());
            root.AddAttribute("StorageType", table.StorageType);
            root.AddAttribute("StandardisationLevel", table.StandardisationLevel);
            root.AddAttribute("ModelLevel", table.ModelLevel);
            root.AddAttribute("PKName", this.GetPkName(table.TableName));
            if (table.Supertype != null)
            {
                root.AddAttribute("PaEntId", table.Supertype.EntId.ToString());
                root.AddAttribute("InheritsFrom", StringUtil.Pascalize(table.Supertype.Name));
            }
            else
            {
                root.AddAttribute("PaEntId", "");
                root.AddAttribute("InheritsFrom", "");
            }
            this.GenerateAttributes(root, table.Attributes);
        }

        private void GenerateTables(TemplateContainer root)
        {
            TemplateContainer tablesContainer = root.AddSon("Entities");
            TemplateContainer metaContainer = root.AddSon("MetaEntities");
            TemplateContainer appContainer = root.AddSon("AppEntities");
            foreach (EntityBO entity in this.allEntities)
            {
                if (entity.Selected)
                {
                    this.GenerateTable(tablesContainer.AddArrayValue(), entity);
                    if (entity.ModelLevel.Equals("META"))
                    {
                        this.GenerateTable(metaContainer.AddArrayValue(), entity);
                    }
                    else
                    {
                        this.GenerateTable(appContainer.AddArrayValue(), entity);
                    }
                }
            }
        }

        private string GetAttributeName(AttributeBO attribute)
        {
            if (attribute.Name.Equals("physical model only"))
            {
                return StringUtil.Pascalize(attribute.ColumnName);
            }
            string result = StringUtil.Pascalize(attribute.Name);
            if (attribute.Domain.IsEnumerated)
            {
                if (result.EndsWith("Code"))
                {
                    result = result.Remove(result.Length - 4, 4);
                }
            }
            string parentEntityName = StringUtil.Pascalize(attribute.ParentEntity.Name);
            if (result.StartsWith(parentEntityName))
            {
                if (result.Length > parentEntityName.Length)
                {
                    result = result.Remove(0, parentEntityName.Length);
                }
            }
            if (result.Equals(parentEntityName))
            {
                result = result + "Code";
            }
            if ((result.Equals("Category")) && (attribute.Domain.IsEnumerated))
            {
                result = StringUtil.Pascalize(attribute.ParentEntity.Name) + "Category";
            }
            return result;
        }


        private string GetNetType(AttributeBO attribute)
        {
            if (attribute.Domain.IsEnumerated)
            {
                string result = StringUtil.Pascalize(attribute.Domain.Name);
                if (result.EndsWith("Code"))
                {
                    result = result.Remove(result.Length - 4, 4);
                }
                result = result + "Enum";
                if (!attribute.IsMandatory)
                {
                    result = result + "?";
                }
                return result;
            }
            if (attribute.BaseDataType.Equals("VARCHAR"))
            {
                return "string";
            }
            if (attribute.BaseDataType.Equals("NUMBER"))
            {
                string result = string.Empty;
                if (attribute.BaseDataDecimals > 0)
                {
                    result = "double";
                }
                else if (attribute.BaseDataLength > 18)
                {
                    result = "decimal";
                }
                else if (attribute.BaseDataLength > 9)
                {
                    result = "long";
                }
                else if (attribute.BaseDataLength > 4)
                {
                    result = "int";
                }
                else
                {
                    result = "short";
                }
                if (!attribute.IsMandatory)
                {
                    result = result + "?";
                }
                return result;
            }
            return "string";
        }

        private string GetBaseNetType(AttributeBO attribute)
        {
            if (attribute.BaseDataType.Equals("VARCHAR"))
            {
                return "string";
            }
            if (attribute.BaseDataType.Equals("NUMBER"))
            {
                if (attribute.BaseDataDecimals > 0)
                {
                    return "double";
                }
                else
                {
                    if (attribute.BaseDataLength > 18)
                    {
                        return "decimal";
                    }
                    else if (attribute.BaseDataLength > 9)
                    {
                        return "long";
                    }
                    else if (attribute.BaseDataLength > 4)
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

        private string GetSQLServerType(AttributeBO attribute)
        {
            if (attribute.BaseDataType.Equals("VARCHAR"))
            {
                return "[NVARCHAR](" + attribute.BaseDataLength.ToString() + ")";
            }
            if (attribute.BaseDataType.Equals("NUMBER"))
            {
                return "[NUMERIC](" + attribute.BaseDataLength.ToString() + "," + attribute.BaseDataDecimals.ToString() + ")";
            }
            if (attribute.BaseDataType.Equals("CHAR"))
            {
                return "[CHAR](" + attribute.BaseDataLength.ToString() + ")";
            }
            return "";
        }

        private bool ExistsInEntity(EntityBO entity, string attributeName)
        {
            foreach (AttributeBO attribute in entity.Attributes)
            {
                if (this.GetAttributeName(attribute).Equals(attributeName)) 
                {
                    return true;
                }
            }
            return false;
        }

        private bool ExistsInParent(AttributeBO attribute)
        {
            string attributeName = this.GetAttributeName(attribute);
            EntityBO entity = attribute.ParentEntity;
            while (entity.Supertype != null)
            {
                entity = entity.Supertype;
                if (this.ExistsInEntity(entity,attributeName))
                {
                    return true;
                }
            }
            return false;
        }

        private void GenerateAttribute(TemplateContainer root, AttributeBO attribute)
        {
            root.AddAttribute("EntId", attribute.EntId.ToString());
            root.AddAttribute("AttrIx", attribute.AttrIx.ToString());
            root.AddAttribute("LogicalName", attribute.Name);
            root.AddAttribute("PhysicalName", attribute.ColumnName);
            root.AddAttribute("Name", this.GetAttributeName(attribute));
            root.AddAttribute("SequenceNumber", attribute.SequenceNumber.ToString());
            root.AddAttribute("StandardisationLevel", attribute.StandardisationLevel);
            root.AddAttribute("IsPrimaryKey", attribute.IsPrimaryKey.ToString());
            root.AddAttribute("IsForeignKey", attribute.IsForeignKey.ToString());
            root.AddAttribute("IsMandatory", attribute.IsMandatory.ToString());
            root.AddAttribute("BaseEntId", attribute.BaseEntId.ToString());
            root.AddAttribute("BaseAttrIx", attribute.BaseAttrIx.ToString());
            root.AddAttribute("Definition", attribute.BaseDefinition);
            root.AddAttribute("DataType", attribute.BaseDataType);
            root.AddAttribute("DataLength", attribute.BaseDataLength.ToString());
            root.AddAttribute("DataDecimals", attribute.BaseDataDecimals.ToString());
            root.AddAttribute("DomId", attribute.BaseDomId.ToString());
            root.AddAttribute("NetType", this.GetNetType(attribute));
            root.AddAttribute("BaseNetType", this.GetBaseNetType(attribute));
            root.AddAttribute("SQLServerType", this.GetSQLServerType(attribute));
            root.AddAttribute("ExistsInParent", this.ExistsInParent(attribute).ToString());
        }

        private void GenerateAttributes(TemplateContainer root, List<AttributeBO> attributes)
        {
            TemplateContainer attributeContainer = root.AddSon("Attributes");
            TemplateContainer pkAttributeContainer = root.AddSon("PKAttributes");
            TemplateContainer nkAttributeContainer = root.AddSon("NKAttributes");
            foreach (AttributeBO attribute in attributes)
            {
                this.GenerateAttribute(attributeContainer.AddArrayValue(), attribute);
                if (attribute.IsPrimaryKey)
                {
                    this.GenerateAttribute(pkAttributeContainer.AddArrayValue(), attribute);
                }
                else
                {
                    this.GenerateAttribute(nkAttributeContainer.AddArrayValue(), attribute);
                }
            }
        }

        private void GenerateRule(TemplateContainer root, BusinessRuleBO rule)
        {
            TemplateContainer container = root.AddArrayValue();
            container.AddAttribute("RuleId", rule.RuleId.ToString());
            container.AddAttribute("Section", rule.Section);
            container.AddAttribute("Name", rule.Name);
            container.AddAttribute("Definition", rule.Definition);
            container.AddAttribute("TableReference", rule.TableReference);
            container.AddAttribute("EntIdOfInterest", rule.EntIdOfInterest.ToString());
            this.GenerateTable(container.AddSon("Entity"), rule.EntityOfInterest);
            
            
            //public List<AttributeBO> Attributes { get; set; }
        //public List<bool> AttributesNullable { get; set; }
        //public List<List<DomainValueBO>> AllowedValues { get; set; }

        }

        private void GenerateRules(TemplateContainer root)
        {
            TemplateContainer rulesContainer = root.AddSon("Rules");
            foreach (BusinessRuleBO rule in this.allBusinessRules)
            {
                if (rule.Selected)
                {
                    this.GenerateRule(root, rule);
                }
            }
        }

        public TemplateContainer GetContainer()
        {
            TemplateContainer result = new TemplateContainer(null);
            this.GenerateDomains(result);
            this.GenerateTables(result);
            this.GenerateRules(result);
            return result;
        }

        #endregion
    }
}
