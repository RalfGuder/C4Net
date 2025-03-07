using C4Net.MVVM.Base;
using MahApps.Metro.Controls;

namespace MVVMDemo.ViewModels.Flyouts
{
    public class FlyoutRightViewModel : FlyoutBaseViewModel
    {
        public FlyoutRightViewModel()
            : base("Right", "Right Flyout", Position.Right)
        {
        }
    }
}
