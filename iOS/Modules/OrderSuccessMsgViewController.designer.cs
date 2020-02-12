// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Designer.iOS.Storyboards
{
    [Register ("OrderSuccessMsgViewController")]
    partial class OrderSuccessMsgViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView closeImgv { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton okayBtn { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (closeImgv != null) {
                closeImgv.Dispose ();
                closeImgv = null;
            }

            if (okayBtn != null) {
                okayBtn.Dispose ();
                okayBtn = null;
            }
        }
    }
}