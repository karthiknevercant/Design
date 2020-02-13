using System;
using System.Collections.Generic;
using CoreGraphics;
using Designer.iOS.Common;
using Designer.iOS.Storyboards;
using Designer.iOS.Xibs;
using Foundation;
using UIKit;

namespace Designer.iOS.Sources
{
    public class ProductSource : UICollectionViewSource
    {
        IProductsViewController iProductsViewController;

        public ProductSource(IProductsViewController iProductsViewController)
        {
            this.iProductsViewController = iProductsViewController;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            //Return the number of items
            return 10;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var tabCell = (ProductCollectionViewCell)collectionView.DequeueReusableCell(CellIDS.PRODUCT_CELL, indexPath);

            var attrs = new UICollectionViewLayoutAttributes();
            //var tabTitle = tabTitles[indexPath.Row];

            //if (indexPath.Row == selectedTabIndex)
            //    tabCell.UpdateCell(tabTitle, true);
            //else
            //    tabCell.UpdateCell(tabTitle, false);

            return tabCell;
        }

        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {

            iProductsViewController.OnIndicidualProductCliked(indexPath.Row);
        }
    }

    public class TabCollectionViewLayout : UICollectionViewDelegateFlowLayout
    {
        private List<string> tabTitles;

        private ITab iTab;

        public bool IsAutomaticDimension = false;

        public TabCollectionViewLayout(List<string> tabTitles, ITab iTab)
        {
            this.tabTitles = tabTitles;

            this.iTab = iTab;
        }

        public override nfloat GetMinimumInteritemSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return 0;
        }

        public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            if (!IsAutomaticDimension)
            {
                CGSize size = new CGSize();

                NSString nsString = new NSString(tabTitles[indexPath.Row]);

                size.Width = 110;

                size.Height = collectionView.Frame.Height;

                return size;
            }
            else
            {
                return UICollectionViewFlowLayout.AutomaticSize;
            }
        }

        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
            //MyBookingTabCollectionSource.selectedTabIndex = indexPath.Row;

            //iTab.OnTabChange(indexPath);

        }


    }

    public class SpacingFlowLayout : UICollectionViewFlowLayout
    {
        public SpacingFlowLayout()
        {

        }

        //public override CGPoint TargetContentOffset(CGPoint proposedContentOffset, CGPoint scrollingVelocity)
        //{
        //    return new CGPoint(proposedContentOffset.X + 50, proposedContentOffset.Y);
        //}
    }

    public interface ITab
    {

    }

}
