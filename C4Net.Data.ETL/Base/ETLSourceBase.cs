using System.Collections.Generic;
using C4Net.Templates;

namespace C4Net.Data.ETL.Base
{
    /// <summary>
    /// Class for an ETL source
    /// </summary>
    public abstract class ETLSourceBase : ETLObjectBase
    {
        #region - Fields -

        /// <summary>
        /// The item container
        /// </summary>
        private TemplateContainer itemContainer;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets the total rows.
        /// </summary>
        /// <value>
        /// The total rows.
        /// </value>
        public int TotalRows { get; protected set; }

        /// <summary>
        /// Gets the current row.
        /// </summary>
        /// <value>
        /// The current row.
        /// </value>
        public int CurrentRow { get; protected set; }

        /// <summary>
        /// Gets the column names.
        /// </summary>
        /// <value>
        /// The column names.
        /// </value>
        public List<string> ColumnNames { get; private set; }

        /// <summary>
        /// Gets the mapped column names.
        /// </summary>
        /// <value>
        /// The mapped column names.
        /// </value>
        public List<string> MappedColumnNames { get; private set; }

        /// <summary>
        /// Gets the row.
        /// </summary>
        /// <value>
        /// The row.
        /// </value>
        public List<string> Row { get; private set; }

        #endregion

        #region - Methods -

        /// <summary>
        /// Internal configuration.
        /// </summary>
        /// <returns></returns>
        protected override bool InnerConfigure()
        {
            bool result = base.InnerConfigure();
            if (result)
            {
                this.ColumnNames = new List<string>();
                this.MappedColumnNames = new List<string>();
                this.Row = new List<string>();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Opens the source.
        /// </summary>
        protected abstract void OpenSource();

        /// <summary>
        /// Gets the column names.
        /// </summary>
        protected abstract void GetColumnNames();

        /// <summary>
        /// Maps the column names.
        /// </summary>
        protected virtual void MapColumnNames()
        {
            foreach (string columnName in this.ColumnNames)
            {
                if (this.config.Mappings.ContainsKey(columnName))
                {
                    this.MappedColumnNames.Add(this.config.Mappings[columnName]);
                }
                else
                {
                    this.MappedColumnNames.Add(columnName);
                }
            }
        }

        /// <summary>
        /// Internal open.
        /// </summary>
        /// <returns></returns>
        protected override bool InnerOpen()
        {
            bool result = base.InnerOpen();
            if (result)
            {
                this.TotalRows = 0;
                this.CurrentRow = 0;
                this.ColumnNames.Clear();
                this.MappedColumnNames.Clear();
                this.OpenSource();
                this.GetColumnNames();
                this.MapColumnNames();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Reads the next record.
        /// </summary>
        /// <returns></returns>
        protected abstract bool ReadNext();

        /// <summary>
        /// Saves the record to the container.
        /// </summary>
        protected virtual void SaveToContainer()
        {
            this.itemContainer.AddAttribute("_RowCount", this.TotalRows.ToString());
            this.itemContainer.AddAttribute("_CurrentRow", this.CurrentRow.ToString());
            for (int i = 0; i < this.MappedColumnNames.Count; i++)
            {
                if (!string.IsNullOrEmpty(this.MappedColumnNames[i]))
                {
                    this.itemContainer.AddAttribute(this.MappedColumnNames[i], this.Row[i]);
                }
            }
        }

        /// <summary>
        /// Internal process.
        /// </summary>
        /// <param name="sourceContainer"></param>
        /// <param name="targetContainer"></param>
        protected override void InnerProcess(TemplateContainer sourceContainer)
        {
            if (!string.IsNullOrEmpty(this.ChildTemplateName))
            {
                this.itemContainer = sourceContainer.AddSon(this.ChildTemplateName);
            }
            else
            {
                this.itemContainer = sourceContainer;
            }
            while (this.ReadNext())
            {
                this.RaiseOnBeginProcess();
                this.SaveToContainer();
                this.CurrentRow = this.CurrentRow + 1;
                this.RaiseOnEndProcess();
            }
        }

        #endregion
    }

}
