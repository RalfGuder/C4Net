using C4Net.MVVM.Base;
using C4Net.MVVM.Themes;
using Caliburn.Micro;

namespace MVVMDemo.Controls
{
    /// <summary>
    /// Bootstrapper for the application.
    /// </summary>
    public class DemoBootstrapper : MefBootstrapper<IShell>
    {
        #region - Methods -

        /// <summary>
        /// Configures the container.
        /// </summary>
        protected override void ConfigureIoC()
        {
            IThemeManager themeManager = IoC.Get<IThemeManager>();
            themeManager.RegisterTheme("Theme1", "pack://application:,,,/Resources/Theme1.xaml");
        }

        #endregion
    }
}
