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
    [Register ("ForgotPaswordController")]
    partial class ForgotPaswordController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton backBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField confirmPswdTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton doneBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField newPswdTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField oldPswdTextField { get; set; }

        [Action ("UIButtonNADDYpbz_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButtonNADDYpbz_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (backBtn != null) {
                backBtn.Dispose ();
                backBtn = null;
            }

            if (confirmPswdTextField != null) {
                confirmPswdTextField.Dispose ();
                confirmPswdTextField = null;
            }

            if (doneBtn != null) {
                doneBtn.Dispose ();
                doneBtn = null;
            }

            if (newPswdTextField != null) {
                newPswdTextField.Dispose ();
                newPswdTextField = null;
            }

            if (oldPswdTextField != null) {
                oldPswdTextField.Dispose ();
                oldPswdTextField = null;
            }
        }
    }
}