using Designer.iOS.Common;
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

        #region LifeCycle

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

            txtCreateAccount.TouchUpInside += delegate
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
                NavigateToHomeScreen();
            };
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            AnimationForThisPage();
        }

        private void AnimationForThisPage()
        {
            Animation.Movement(usernameTextField, usernameTextField.Center.X - 200, usernameTextField.Center.Y);
            Animation.Movement(passwordTextField, passwordTextField.Center.X - 200, passwordTextField.Center.Y);

            Animation.AnimateWithSpring(appleSignInBtn, 0.4f, 2f, appleSignInBtn.Center.X, -200);
            Animation.AnimateWithSpring(fbSignInBtn, 0.4f, 2f, fbSignInBtn.Center.X, -200);
            Animation.AnimateWithSpring(googleSignInBtn, 0.4f, 2f, googleSignInBtn.Center.X, -200);
            Animation.AnimateWithSpring(lblLogin, 0.4f, 2f, lblLogin.Center.X, 200);
            Animation.Fade(txtOr, false, 3);
            Animation.Fade(txtCreateAccount, false, 3);
            Animation.Fade(txtstaticCreateAccount, false, 3);
            Animation.Fade(forgotPasswordBtn, false, 3);

        }



        #endregion

        #region Methods
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
                var createAccountViewController = Storyboard.InstantiateViewController("CreateAccountViewController_ID") as CreateAccountViewController;

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
                ForgotPaswordController forgotPaswordController = Storyboard.InstantiateViewController("ForgotPaswordController_ID", null) as ForgotPaswordController;

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
            NavigationController.PopViewController(false);

            var homeTabbarController = Storyboard.InstantiateViewController("HomeTabbarController_ID") as HomeTabbarController;

            this.NavigationController.PushViewController(homeTabbarController, true);
        }

        public void TopToBottomAnimation()
        {
            Animation.AnimateWithSpring(appleSignInBtn, 0.4f, 2f, appleSignInBtn.Center.X, 200);
            Animation.AnimateWithSpring(fbSignInBtn, 0.4f, 2f, fbSignInBtn.Center.X, 200);
            Animation.AnimateWithSpring(googleSignInBtn, 0.4f, 2f, googleSignInBtn.Center.X, 200);
            Animation.AnimateWithSpring(lblLogin, 0.4f, 2f, lblLogin.Center.X, 200);
            Animation.AnimateWithSpring(txtOr, 0.4f, 2f, txtOr.Center.X, 200);
            Animation.AnimateWithSpring(txtCreateAccount, 0.4f, 2f, txtCreateAccount.Center.X, 200);
            Animation.AnimateWithSpring(txtstaticCreateAccount, 0.4f, 2f, txtstaticCreateAccount.Center.X, 200);
            Animation.AnimateWithSpring(forgotPasswordBtn, 0.4f, 2f, forgotPasswordBtn.Center.X, 200);
            Animation.AnimateWithSpring(usernameTextField, 0.4f, 2f, usernameTextField.Center.X, 200);
            Animation.AnimateWithSpring(passwordTextField, 0.4f, 2f, passwordTextField.Center.X, 200);
            Animation.AnimateWithSpring(btnPassword, 0.4f, 2f, btnPassword.Center.X, 200);
            Animation.AnimateWithSpring(loginBtn, 0.4f, 2f, loginBtn.Center.X, 200);

        }

        public void Fade()
        {
            Animation.Fade(lblLogin, false, 3);
            Animation.Fade(txtOr, false, 3);
            Animation.Fade(txtCreateAccount, false, 3);
            Animation.Fade(txtstaticCreateAccount, false, 3);

            Animation.Fade(txtOr, false, 3);
            Animation.Fade(txtCreateAccount, false, 3);
            Animation.Fade(txtstaticCreateAccount, false, 3);
            Animation.Fade(forgotPasswordBtn, false, 3);
        }

        public void Movement()
        {
            Animation.Movement(usernameTextField, usernameTextField.Center.X - 200, usernameTextField.Center.Y);
            Animation.Movement(passwordTextField, passwordTextField.Center.X - 200, passwordTextField.Center.Y);
        }
        #endregion
    }
}