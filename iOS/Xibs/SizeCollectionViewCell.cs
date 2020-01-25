using System;

using Foundation;
using UIKit;

namespace Designer.iOS.Xibs
{
    public partial class SizeCollectionViewCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("SizeCollectionViewCell");
        public static readonly UINib Nib;

        static SizeCollectionViewCell()
        {
            Nib = UINib.FromName("SizeCollectionViewCell", NSBundle.MainBundle);
        }

        protected SizeCollectionViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
