using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using C4Net.Core.Utils;

namespace C4Net.Data.ETL.Config
{
    public class ETLMap : BaseXmlManagerItem
    {
        #region - Properties -

        public string ItemName { get; private set; }

        public List<ETLMap> Child { get; private set; }

        #endregion

        #region - Constructors -

        public ETLMap(XmlNode node)
            : base(node)
        {
        }

        #endregion

        #region - Methods -

        protected override void InnerLoad(NodeAttributes attributes)
        {
            this.Child = new List<ETLMap>();
            this.ItemName = attributes.AsString("itemName");
            foreach (XmlNode node in attributes.Node.SelectNodes("maps/map"))
            {
                this.Child.Add(new ETLMap(node));
            }
        }

        #endregion

    }
}
