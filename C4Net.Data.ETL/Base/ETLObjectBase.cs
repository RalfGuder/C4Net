using System;
using C4Net.Core.IoC;
using C4Net.Core.Log;
using C4Net.Data.ETL.Config;
using C4Net.Data.ETL.Interfaces;
using C4Net.Templates;

namespace C4Net.Data.ETL.Base
{
    /// <summary>
    /// Abstract object for the base of an ETL Object
    /// </summary>
    public abstract class ETLObjectBase : LoggableClass, IETLObject
    {
        #region - Fields -

        /// <summary>
        /// The shell
        /// </summary>
        protected IETLShell shell;

        /// <summary>
        /// The config
        /// </summary>
        protected ETLItemConfig config;

        protected TemplateContainer container;

        #endregion

        #region - Properties -

        /// <summary>
        /// Gets the name of the ETL Object
        /// </summary>
        /// <value>
        /// The name of the ETL Object.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of the ETL object.
        /// </summary>
        /// <value>
        /// The type of the item.
        /// </value>
        public string ItemType { get; private set; }

        /// <summary>
        /// Gets the name of the child template.
        /// </summary>
        /// <value>
        /// The name of the child template.
        /// </value>
        public string ChildTemplateName { get; private set; }

        #endregion

        #region - Events -

        /// <summary>
        /// Occurs when [on begin process item].
        /// </summary>
        public event EventHandler OnBeginProcessItem;

        /// <summary>
        /// Occurs when [on end process item].
        /// </summary>
        public event EventHandler OnEndProcessItem;

        #endregion

        #region - Methods -

        /// <summary>
        /// Internal configuration.
        /// </summary>
        /// <returns></returns>
        protected virtual bool InnerConfigure() 
        {
            return true;
        }

        /// <summary>
        /// Internal open.
        /// </summary>
        /// <returns></returns>
        protected virtual bool InnerOpen()
        {
            return true;
        }

        /// <summary>
        /// Internal close.
        /// </summary>
        protected virtual void InnerClose() 
        {
        }

        /// <summary>
        /// Internal process
        /// </summary>
        /// <param name="container">The container.</param>
        protected abstract void InnerProcess(TemplateContainer sourceContainer);

        /// <summary>
        /// Configures the ETL Object.
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool Configure(ETLItemConfig config)
        {
            this.LogDebug("Begin");
            try
            {
                this.Name = config.Name;
                this.ItemType = config.ItemType;
                this.ChildTemplateName = config.ChildTemplateName;
                this.config = config;
                this.shell = DefaultContainer.Get<IETLShell>();
                return this.InnerConfigure();
            }
            catch (Exception ex)
            {
                this.LogError(ex);
                return false;
            }
            finally
            {
                this.LogDebug("End");
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Opens the object.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool Open()
        {
            this.LogDebug("Begin");
            try
            {
                return this.InnerOpen();
            }
            catch (Exception ex)
            {
                this.LogError(ex);
                return false;
            }
            finally
            {
                this.LogDebug("End");
            }
        }

        /// <summary>
        /// Closes the object.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Close()
        {
            this.LogDebug("Begin");
            try
            {
                this.InnerClose();
            }
            catch (Exception ex)
            {
                this.LogError(ex);
            }
            finally
            {
                this.LogDebug("End");
            }
        }

        /// <summary>
        /// Executes the object using the specified container path.
        /// </summary>
        /// <param name="path">The path.</param>
        public void Process(string containerPath)
        {
            this.LogDebug("Begin");
            try
            {
                this.shell = DefaultContainer.Get<IETLShell>();
                object source = this.shell.RootContainer.GetByPath(containerPath);
                this.container = ((source != null) && (source is TemplateContainer)) ? source as TemplateContainer : this.shell.RootContainer;
                this.Open();
                this.InnerProcess(this.container);
                this.Close();
            }
            catch (Exception ex)
            {
                this.LogError(ex);
            }
            finally
            {
                this.LogDebug("End");
            }
        }

        /// <summary>
        /// Raises the on begin process event.
        /// </summary>
        protected void RaiseOnBeginProcess()
        {
            if (this.OnBeginProcessItem != null)
            {
                this.OnBeginProcessItem(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Raises the on end process event.
        /// </summary>
        protected void RaiseOnEndProcess()
        {
            if (this.OnEndProcessItem != null)
            {
                this.OnEndProcessItem(this, EventArgs.Empty);
            }
        }

        #endregion
    }
}
