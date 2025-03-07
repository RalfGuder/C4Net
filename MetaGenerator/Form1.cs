using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
using C4Net.Metamodel;
using C4Net.Templates;

namespace MetaGenerator
{
    public partial class Form1 : Form
    {
        ModelLoader loader;

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
            loader = new ModelLoader();
            loader.Load();
            TemplateContainer root = loader.GetContainer();
            root.AddAttribute("Namespace", "C4Net.JC3IEDM");
            root.AddAttribute("Author", "JSeijas");
            root.AddAttribute("ProductName", "C4Net");
            root.AddAttribute("OutputPath", "D:\\templates\\Generator\\output");
            root.AddAttribute("DatabaseName", "Test");
            root.AddAttribute("DatabaseSchema","JC3IEDM");
            TemplateEngine engine = new TemplateEngine();
            engine.LoadRulesFromXml("D:\\templates\\Generator\\input\\templateRules.xml");
            engine.Iterate(root);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
