using System.IO;
using C4Net.Data.ETL.Base;
using C4Net.Templates;
using C4Net.Templates.Parser;

namespace C4Net.Data.ETL.Items
{
    public class TextAppendTarget : ETLObjectBase
    {
        #region - Fields -

        private string lineFormat;

        private string fileName;

        private StreamWriter writer=null;

        #endregion

        #region - Methods -

        protected override bool InnerOpen()
        {
            bool result = base.InnerOpen();
            if (result)
            {
                this.lineFormat = this.config.Parameters["lineFormat"].Trim();
                this.fileName = LanguageParser.ReplaceString(this.config.Parameters["fileName"].Trim(), this.container);
                this.writer = File.AppendText(this.fileName);
                return true;
            }
            return false;
        }

        protected override void InnerClose()
        {
            base.InnerClose();
            if (this.writer != null)
            {
                this.writer.Close();
            }
        }

        protected override void InnerProcess(TemplateContainer sourceContainer)
        {
            string s = LanguageParser.ReplaceString(this.lineFormat, sourceContainer);
            this.writer.WriteLine(s);
        }

        #endregion
    }
}
