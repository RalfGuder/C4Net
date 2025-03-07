using System.ComponentModel.Composition;
using C4Net.MVVM.Base;
using C4Net.MVVM.Services;

namespace MetaTool.Controls
{
    public class DemoStartupTasks : StartupTasks
    {
        #region - Constructors -
        
        [ImportingConstructor]
        public DemoStartupTasks(IServiceLocator serviceLocator) 
            : base(serviceLocator)
        {
        }
        
        #endregion

        #region - Methods -

        [Export(typeof(StartupTask))]
        public override void ApplyViewLocatorOverride()
        {
            base.ApplyViewLocatorOverride();
        }

        [Export(typeof(StartupTask))]
        public override void ApplyBindingScopeOverride()
        {
            base.ApplyBindingScopeOverride();
        }

        #endregion
    }
}
