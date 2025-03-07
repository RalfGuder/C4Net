using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MahApps.Metro.Controls;

namespace C4Net.MVVM.Base
{
    public class FlashFlyoutViewModel : FlyoutBaseViewModel
    {
        #region - Singleton -

        private static FlashFlyoutViewModel instance = new FlashFlyoutViewModel();

        public static FlashFlyoutViewModel Instance
        {
            get { return instance; }
        }

        #endregion

        #region - Fields -

        private string message;

        private string subMessage;

        #endregion

        #region - Properties -

        public string Message
        {
            get { return this.message; }
            set { this.SetProperty<string>(ref this.message, value); }
        }

        public string SubMessage
        {
            get { return this.subMessage; }
            set { this.SetProperty<string>(ref this.subMessage, value); }
        }

        #endregion

        #region - Constructors -

        public FlashFlyoutViewModel()
            : base("Flash", "Message", Position.Left)
        {

        }

        #endregion

        #region - Methods -

        public void Show(string message, string subMessage)
        {
            this.Message = message;
            this.SubMessage = subMessage;
            this.IsOpen = true;
        }

        public static void ShowMessage(string message, string subMessage)
        {
            FlashFlyoutViewModel.Instance.Show(message, subMessage);
        }

        #endregion
    }
}
