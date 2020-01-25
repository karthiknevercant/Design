// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Designer.iOS.Storyboards
{
	[Register ("OrderSuccessMsgViewController")]
	partial class OrderSuccessMsgViewController
	{
		[Outlet]
		UIKit.UIImageView closeImgv { get; set; }

		[Outlet]
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
