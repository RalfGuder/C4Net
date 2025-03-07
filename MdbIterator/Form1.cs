using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C4Net.Core.Conversions;
using C4Net.Core.IoC;
using C4Net.Core.Log;
using C4Net.Core.NLog;
using C4Net.Data.Connections;
using C4Net.Data.Providers;
using C4Net.Data.Transactions;
using C4Net.Schemas.OleDb;
using C4Net.Templates;
using C4Net.Templates.Parser;

namespace MdbIterator
{
    public partial class Form1 : Form
    {
        TemplateContainer root;

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
            //TemplateParser parser = new TemplateParser();
            //parser.Parse("desde Santurce a Bilbao [%foreach(Commands)%] con la[%end%] falda remangada");
            OleDbSchemaReader reader = new OleDbSchemaReader(DefaultContainer.Get<IDbConnectionManager>().GetConnectionInfo().ConnectionString);
            reader.Open();
            reader.Read();
            this.root = reader.GetContainer("", "");
            root.AddAttribute("Namespace", "C4Net.Metamodel");
            root.AddAttribute("Author", "JSeijas");
            root.AddAttribute("ProductName", "C4Net");
            root.AddAttribute("OutputPath", "D:\\templates\\mdbGenerator\\output");
            reader.Close();
            TemplateEngine engine = new TemplateEngine();
            engine.LoadRulesFromXml("D:\\templates\\mdbGenerator\\input\\templateRules.xml");
            engine.Iterate(this.root);
        }
    }
}
