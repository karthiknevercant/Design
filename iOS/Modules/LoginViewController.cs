using Designer.iOS.Helper;
using Foundation;
using System;
using System.Diagnostics;
using System.Drawing;
using UIKit;

namespace Designer.iOS
{
    public partial class LoginViewController : BaseViewController
    {
        public LoginViewController(IntPtr handle) : base(handle)
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

            // FOR OUTSIDE TAPS
            UITapGestureRecognizer outsideGesture = new UITapGestureRecognizer(OutsideTap);
            wholeView.AddGestureRecognizer(outsideGesture);

            createAccountBtn.TouchUpInside += delegate
            {
                NavigateToCreateAccountScreen();
            };

            forgotPasswordBtn.TouchUpInside += delegate
            {
                NavigateToForgotPasswordScreen();
            };

            loginBtn.TouchUpInside += delegate
            {
                Animation.Shrink(loginBtn, loginBtn.Frame.Height, 5);
                //NavigateToHomeScreen();
            };
        }


        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            Animation.Movement(usernameTextField, contentBaseView.Center.X, loginBtn.Center.Y);

        }
        // HANDLING OUTSIDE TOUCH => HIDING KEYBOARD
        public void OutsideTap()
        {
            try
            {
                usernameTextField.ResignFirstResponder();

                passwordTextField.ResignFirstResponder();

                //scrollviewBottomConstraint.Constant = 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        // LOGIN SCREEN TO CREATE ACCOUNT SCREEN NAVIGATION
        public void NavigateToCreateAccountScreen()
        {
            try
            {
                UIStoryboard patientStoryboard = UIStoryboard.FromName("User", null) as UIStoryboard;

                CreateAccountViewController createAccountViewController = patientStoryboard.InstantiateViewController("CreateAccountViewController_ID", null) as CreateAccountViewController;

                this.NavigationController.PushViewController(createAccountViewController, true);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        // LOGIN SCREEN TO FORGOT PASSWORD SCREEN NAVIGATION
        public void NavigateToForgotPasswordScreen()
        {
            try
            {
                UIStoryboard patientStoryboard = UIStoryboard.FromName("User", null) as UIStoryboard;

                ForgotPaswordController forgotPaswordController = patientStoryboard.InstantiateViewController("ForgotPaswordController_ID", null) as ForgotPaswordController;

                this.NavigationController.PushViewController(forgotPaswordController, true);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        // LOGIN SCREEN TO HOME TABS SCREEN NAVIGATION
        public void NavigateToHomeScreen()
        {
            UINavigationController navigationController = NavigationController;

            NavigationController.PopViewController(false);

            UIStoryboard patientStoryboard = UIStoryboard.FromName("User", null) as UIStoryboard;

            HomeTabbarController homeTabbarController = patientStoryboard.InstantiateViewController("HomeTabbarController_ID", null) as HomeTabbarController;

            navigationController.PushViewController(homeTabbarController, true);
        }
    }
}