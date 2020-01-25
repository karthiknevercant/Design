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
	[Register ("ProductsViewController")]
	partial class ProductsViewController
	{
		[Outlet]
		UIKit.UIButton cartBtn { get; set; }

		[Outlet]
		UIKit.UICollectionView categoryCollectionVIew { get; set; }

		[Outlet]
		UIKit.UICollectionView productCollectionView { get; set; }

		[Outlet]
		UIKit.UICollectionView sizeCollectionView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (productCollectionView != null) {
				productCollectionView.Dispose ();
				productCollectionView = null;
			}

			if (cartBtn != null) {
				cartBtn.Dispose ();
				cartBtn = null;
			}

			if (categoryCollectionVIew != null) {
				categoryCollectionVIew.Dispose ();
				categoryCollectionVIew = null;
			}

			if (sizeCollectionView != null) {
				sizeCollectionView.Dispose ();
				sizeCollectionView = null;
			}
		}
	}
}
