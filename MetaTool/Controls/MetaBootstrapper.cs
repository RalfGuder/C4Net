using C4Net.Core.Conversions;
using C4Net.Core.IoC;
using C4Net.Core.Log;
using C4Net.Core.NLog;
using C4Net.Data.Connections;
using C4Net.Data.Providers;
using C4Net.Data.Transactions;
using C4Net.MVVM.Base;
using C4Net.MVVM.Themes;
using Caliburn.Micro;

namespace MetaTool.Controls
{
    /// <summary>
    /// Bootstrapper for the application.
    /// </summary>
    public class MetaBootstrapper : MefBootstrapper<IShell>
    {
        #region - Methods -

        /// <summary>
        /// Configures the container.
        /// </summary>
        protected override void ConfigureIoC()
        {
            IThemeManager themeManager = IoC.Get<IThemeManager>();
            themeManager.RegisterTheme("Theme1", "pack://application:,,,/Resources/Theme1.xaml");
            //this.RegisterTheme("Theme1", "pack://application:,,,/Resources/Theme1.xaml");
            DefaultContainer.RegisterSingleton<ILoggable>(new NLoggable());
            DefaultContainer.RegisterSingleton<ITransactionFactory>(new TransactionFactory());
            DefaultContainer.RegisterSingleton<IConversionManager>(new ConversionManager());
            DbProviderManager providerManager = new DbProviderManager();
            providerManager.LoadElements("Providers.config", "configuration/providers/provider");
            DefaultContainer.RegisterSingleton<IDbProviderManager>(providerManager);
            DbConnectionManager connectionManager = new DbConnectionManager();
            DefaultContainer.RegisterSingleton<IDbConnectionManager>(connectionManager);
        }

        #endregion
    }
}
