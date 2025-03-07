using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using MahApps.Metro.Controls;

namespace C4Net.MVVM.Controls
{
    public class FlashFlyout : Flyout
    {
        #region - Dependency Properties -

        public static new readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(FlashFlyout), new FrameworkPropertyMetadata(default(bool), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, IsOpenedChanged));
        
        #endregion

        #region - Fields -

        private bool isShowing = false;

        private bool isComplete = true;

        #endregion

        #region - Events -

        public event EventHandler IsOpenChanged;

        #endregion

        #region - Properties -

        public new bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }
        
        #endregion

        #region - Constructors -

        static FlashFlyout() 
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlashFlyout), new FrameworkPropertyMetadata(typeof(FlashFlyout)));
        }

        #endregion

        #region - Methods -

        private static void IsOpenedChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            ((FlashFlyout)dependencyObject).IsOpenedChanged(e.NewValue);
        }

        private void IsOpenedChanged(object value)
        {
            this.isShowing = (bool)value;
            if ((this.isShowing) || (this.isComplete))
            {
                this.ChangeState();
            }
            if (this.IsOpenChanged != null)
            {
                this.IsOpenChanged(this, EventArgs.Empty);
            }
        }

        private void ChangeState()
        {
            this.isComplete = false;
            VisualStateManager.GoToState(this, this.isShowing ? "Show" : "Hide", true);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            Storyboard showStoryboard = (Storyboard)this.GetTemplateChild("sbShow");
            if (showStoryboard != null)
            {
                showStoryboard.Completed += DoOnCompletedShowStoryboard;
            }
            this.ApplyAnimation();
        }

        private void DoOnCompletedShowStoryboard(object sender, EventArgs args)
        {
            this.isComplete = true;
            if (!this.isShowing)
            {
                VisualStateManager.GoToState(this, "Hide", true);
            }
        }

        private void ApplyAnimation()
        {
            Grid root = (Grid)this.GetTemplateChild("root");
            if (root == null)
            {
                return;
            }
            EasingDoubleKeyFrame hideFrame = (EasingDoubleKeyFrame)this.GetTemplateChild("hideFrame");
            EasingDoubleKeyFrame hideFrameY = (EasingDoubleKeyFrame)this.GetTemplateChild("hideFrameY");
            EasingDoubleKeyFrame showFrame = (EasingDoubleKeyFrame)this.GetTemplateChild("showFrame");
            EasingDoubleKeyFrame showFrameY = (EasingDoubleKeyFrame)this.GetTemplateChild("showFrameY");
            if (hideFrame == null || hideFrameY == null || showFrame == null || showFrameY == null)
            {
                return;
            }
            if (this.Position == Position.Left || this.Position == Position.Right)
            {
                showFrame.Value = 0;
            }
            root.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            int multiplier = 1;
            if (this.Position == Position.Right)
            {
                HorizontalAlignment = HorizontalAlignment.Right;
            }
            else
            {
                HorizontalAlignment = HorizontalAlignment.Left;
                multiplier = -1;
            }
            VerticalAlignment = VerticalAlignment.Bottom;
            hideFrame.Value = root.DesiredSize.Width * multiplier;
            root.RenderTransform = new TranslateTransform(root.DesiredSize.Width * multiplier, 0);
        }

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            base.OnRenderSizeChanged(sizeInfo);
            if (!sizeInfo.WidthChanged && !sizeInfo.HeightChanged)
            {
                return;
            }
            if (!IsOpen)
            {
                this.ApplyAnimation();
                return;
            }
            Grid root = (Grid)this.GetTemplateChild("root");
            if (root == null)
            {
                return;
            }
            EasingDoubleKeyFrame hideFrame = (EasingDoubleKeyFrame)this.GetTemplateChild("hideFrame");
            EasingDoubleKeyFrame hideFrameY = (EasingDoubleKeyFrame)this.GetTemplateChild("hideFrameY");
            EasingDoubleKeyFrame showFrame = (EasingDoubleKeyFrame)this.GetTemplateChild("showFrame");
            EasingDoubleKeyFrame showFrameY = (EasingDoubleKeyFrame)this.GetTemplateChild("showFrameY");
            if (hideFrame == null || hideFrameY == null || showFrame == null || showFrameY == null)
            {
                return;
            }
            if (this.Position == Position.Left || this.Position == Position.Right)
            {
                showFrame.Value = 0;
            }
            if (this.Position == Position.Right)
            {
                hideFrame.Value = root.DesiredSize.Width;
            }
            else
            {
                hideFrame.Value = -root.DesiredSize.Width;
            }
        }

        #endregion
    }
}
