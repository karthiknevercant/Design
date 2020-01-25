using Foundation;
using System;
using System.Diagnostics;
using System.Drawing;
using UIKit;

namespace Designer.iOS
{
    public partial class CreateAccountViewController : BaseViewController
    {
        public CreateAccountViewController(IntPtr handle) : base(handle)
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

            //HIDING KEYBAORD WHILE CLICKING RETURN ON USERNAME FIELD
            usernameTextField.ShouldReturn += (textField) =>
            {
                Hidekeybaord();
                //scrollviewBottomConstraint.Constant = 0;
                return true;
            };

            //HIDING KEYBAORD WHILE CLICKING RETURN ON PASSWORD FIELD
            passwordTextField.ShouldReturn += (textField) =>
            {
                Hidekeybaord();
                //scrollviewBottomConstraint.Constant = 0;
                return true;
            };

            //HIDING KEYBAORD WHILE CLICKING RETURN ON CONFIRM PASSWORD FIELD
            confirmPasswordTextField.ShouldReturn += (textField) =>
            {
                Hidekeybaord();
                //scrollviewBottomConstraint.Constant = 0;
                return true;
            };

            //HIDING KEYBAORD WHILE CLICKING RETURN ON EMAIL ID FIELD
            emailTextField.ShouldReturn += (textField) =>
            {
                Hidekeybaord();
                //scrollviewBottomConstraint.Constant = 0;
                return true;
            };

            //HIDING KEYBAORD WHILE CLICKING RETURN ON MOBILE NO FIELD
            mobileNoTextField.ShouldReturn += (textField) =>
            {
                Hidekeybaord();
                //scrollviewBottomConstraint.Constant = 0;
                return true;
            };

            // FOR OUTSIDE TAPS
            UITapGestureRecognizer outsideGesture = new UITapGestureRecognizer(OutsideTap);
            wholeView.AddGestureRecognizer(outsideGesture);

            backBtn.TouchUpInside += delegate
            {
                this.NavigationController.PopViewController(true);
            };

        }

        // HANDLING OUTSIDE TOUCH => HIDING KEYBOARD
        public void OutsideTap()
        {
            try
            {
                usernameTextField.ResignFirstResponder();

                passwordTextField.ResignFirstResponder();

                confirmPasswordTextField.ResignFirstResponder();

                emailTextField.ResignFirstResponder();

                mobileNoTextField.ResignFirstResponder();

                //scrollviewBottomConstraint.Constant = 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}