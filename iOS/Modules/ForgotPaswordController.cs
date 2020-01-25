using Foundation;
using System;
using System.Drawing;
using UIKit;

namespace Designer.iOS
{
    public partial class ForgotPaswordController : UIViewController
    {
        public ForgotPaswordController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NSNotificationCenter.DefaultCenter.AddObserver(UIKeyboard.WillShowNotification, (notification) =>
            {
                NSValue nsKeyboardBounds = (NSValue)notification.UserInfo.ObjectForKey(UIKeyboard.BoundsUserInfoKey);

                RectangleF keyboardBounds = nsKeyboardBounds.RectangleFValue;

                //scrollviewBottomConstraint.Constant = keyboardBounds.Height;
            });

            backBtn.TouchUpInside += delegate
            {
                this.NavigationController.PopViewController(true);
            };
        }
    }
}