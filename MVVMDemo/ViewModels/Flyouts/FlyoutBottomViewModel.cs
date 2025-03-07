using C4Net.MVVM.Base;
using MahApps.Metro.Controls;

namespace MVVMDemo.ViewModels.Flyouts
{
    public class FlyoutBottomViewModel : FlyoutBaseViewModel
    {
        public FlyoutBottomViewModel()
            : base("Bottom", "Bottom Flyout", Position.Bottom)
        {
        }
    }
}
