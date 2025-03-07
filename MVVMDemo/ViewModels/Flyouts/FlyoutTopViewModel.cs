using C4Net.MVVM.Base;
using MahApps.Metro.Controls;

namespace MVVMDemo.ViewModels.Flyouts
{
    public class FlyoutTopViewModel : FlyoutBaseViewModel
    {
        public FlyoutTopViewModel()
            : base("Top", "Top Flyout", Position.Top)
        {
        }
    }
}
