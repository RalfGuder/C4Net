using C4Net.MVVM.Base;
using MahApps.Metro.Controls;

namespace MVVMDemo.ViewModels.Flyouts
{
    public class FlyoutLeftViewModel : FlyoutBaseViewModel
    {
        public FlyoutLeftViewModel()
            : base("Left", "Left Flyout", Position.Left)
        {
        }
    }
}
