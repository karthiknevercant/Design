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
    [Register ("ProfileViewController")]
    partial class ProfileViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MaterialComponents.FloatingButton btnFloatingAdd { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnFloatingAdd != null) {
                btnFloatingAdd.Dispose ();
                btnFloatingAdd = null;
            }
        }
    }
}