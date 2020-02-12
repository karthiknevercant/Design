// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Designer.iOS
{
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton appleSignInBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView contentBaseView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton createAccountBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton fbSignInBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton forgotPasswordBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton googleSignInBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton loginBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField passwordTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView scrollview { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField usernameTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView wholeView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (appleSignInBtn != null) {
                appleSignInBtn.Dispose ();
                appleSignInBtn = null;
            }

            if (contentBaseView != null) {
                contentBaseView.Dispose ();
                contentBaseView = null;
            }

            if (createAccountBtn != null) {
                createAccountBtn.Dispose ();
                createAccountBtn = null;
            }

            if (fbSignInBtn != null) {
                fbSignInBtn.Dispose ();
                fbSignInBtn = null;
            }

            if (forgotPasswordBtn != null) {
                forgotPasswordBtn.Dispose ();
                forgotPasswordBtn = null;
            }

            if (googleSignInBtn != null) {
                googleSignInBtn.Dispose ();
                googleSignInBtn = null;
            }

            if (loginBtn != null) {
                loginBtn.Dispose ();
                loginBtn = null;
            }

            if (passwordTextField != null) {
                passwordTextField.Dispose ();
                passwordTextField = null;
            }

            if (scrollview != null) {
                scrollview.Dispose ();
                scrollview = null;
            }

            if (usernameTextField != null) {
                usernameTextField.Dispose ();
                usernameTextField = null;
            }

            if (wholeView != null) {
                wholeView.Dispose ();
                wholeView = null;
            }
        }
    }
}