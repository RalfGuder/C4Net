using System.IO;
using C4Net.Data.ETL.Base;
using C4Net.Templates.Parser;

namespace C4Net.Data.ETL.Items
{
    /// <summary>
    /// Action for removing files.
    /// </summary>
    public class FileRemoveAction : ETLObjectBase
    {
        #region - Fields -

        /// <summary>
        /// The file name.
        /// </summary>
        private string fileName;

        #endregion
        
        #region - Methods -

        /// <summary>
        /// Internal open.
        /// </summary>
        /// <returns></returns>
        protected override bool InnerOpen()
        {
            bool result = base.InnerOpen();
            if (result)
            {
                this.fileName = LanguageParser.ReplaceString(this.config.Parameters["fileName"].Trim(), this.container);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Internal process
        /// </summary>
        /// <param name="sourceContainer"></param>
        protected override void InnerProcess(Templates.TemplateContainer sourceContainer)
        {
            File.Delete(this.fileName);
        }

        #endregion
    }
}
