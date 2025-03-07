using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using C4Net.Core.Conversions;
using C4Net.Core.IoC;
using C4Net.Core.Log;
using C4Net.Core.NLog;
using C4Net.Data.Adapters;
using C4Net.Data.Entity;
using C4Net.Data.Connections;
using C4Net.Data.Expressions;
using C4Net.Data.Providers;
using C4Net.Data.Transactions;
using C4Net.Schemas.Entities;
using C4Net.Schemas.OleDb;
using C4Net.Templates;
using MetaModel.Business;
using C4Net.Data;
using C4Net.Data.Interfaces;
using C4Net.Data.ETL.Config;
using C4Net.Data.ETL.Base;
using C4Net.Data.ETL.Sources;
using C4Net.Data.ETL.Interfaces;
using C4Net.Data.ETL;
using C4Net.Data.ETL.Items;

namespace CoreBed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DefaultContainer.RegisterSingleton<ILoggable>(new NLoggable());
            DefaultContainer.RegisterSingleton<ITransactionFactory>(new TransactionFactory());
            DefaultContainer.RegisterSingleton<IConversionManager>(new ConversionManager());
            DbProviderManager providerManager = new DbProviderManager();
            providerManager.LoadElements("Providers.config", "configuration/providers/provider");
            DefaultContainer.RegisterSingleton<IDbProviderManager>(providerManager);
            DbConnectionManager connectionManager = new DbConnectionManager();
            connectionManager.LoadElements("Connections.config", "configuration/connections/connection");
            DefaultContainer.RegisterSingleton<IDbConnectionManager>(connectionManager);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ETLEngine engine = new ETLEngine();
            engine.LoadConfiguration("ETLItems.config");
            engine.AddItemClass("DatabaseSource", typeof(DatabaseSource));
            engine.AddItemClass("TextAppendTarget", typeof(TextAppendTarget));
            engine.AddItemClass("FileRemoveAction", typeof(FileRemoveAction));
            engine.AddItemClass("CamelizeAction", typeof(CamelizeAction));
            engine.Start();
            engine.Execute();
            //IUnitOfWork uow = new UnitOfWork(new DataContext());
            //IRepository<Entity> repo = uow.GetRepository<Entity>();
            //Entity entity = repo.SelectFirst();
            //this.Text = entity.TableNameText;

            //IQueryable<Entity> qry = from ent in uow.GetQuery<Entity>() where ent.DepthCount == 0 select ent;
            //foreach (Entity ent in qry)
            //{
            //    this.Text = ent.TableNameText;
            //}
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
