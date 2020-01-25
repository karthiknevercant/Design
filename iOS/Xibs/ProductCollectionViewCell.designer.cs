// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Designer.iOS.Xibs
{
	[Register ("ProductCollectionViewCell")]
	partial class ProductCollectionViewCell
	{
		[Outlet]
		UIKit.UIView productView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (productView != null) {
				productView.Dispose ();
				productView = null;
			}
		}
	}
}
