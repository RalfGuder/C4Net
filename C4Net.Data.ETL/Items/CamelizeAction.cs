using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C4Net.Core.Utils;
using C4Net.Data.ETL.Base;
using C4Net.Templates;
using C4Net.Templates.Parser;

namespace C4Net.Data.ETL.Items
{
    public class CamelizeAction : ETLObjectBase
    {
        #region - Fields -

        private string fieldName;

        #endregion

        /// <summary>
        /// Internal open.
        /// </summary>
        /// <returns></returns>
        protected override bool InnerOpen()
        {
            bool result = base.InnerOpen();
            if (result)
            {
                this.fieldName = LanguageParser.ReplaceString(this.config.Parameters["fieldName"].Trim(), this.container);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Internal process
        /// </summary>
        /// <param name="sourceContainer"></param>
        protected override void InnerProcess(TemplateContainer sourceContainer)
        {
            if (sourceContainer.Attributes.ContainsKey(this.fieldName))
            {
                sourceContainer.Attributes[fieldName] = StringUtil.Camelize(sourceContainer.Attributes[fieldName].ToString());
            }
        }
    }
}
