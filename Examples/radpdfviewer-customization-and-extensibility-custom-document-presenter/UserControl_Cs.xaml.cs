using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication2
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
    }

    #region radpdfviewer-customization-and-extensibility-custom-document-presenter_0
    public class SinglePageInfo: FixedPageLayoutInfo
    {
        public SinglePageInfo(Telerik.Windows.Documents.Fixed.Model.RadFixedPage page, System.Windows.Rect positionInView) : base(page, positionInView)
        {
        ...
        }
    }
    #endregion

    #region radpdfviewer-customization-and-extensibility-custom-document-presenter_1
    public class CustomSinglePagePresenter : FixedDocumentPresenterBase
    {
        protected override int CurrentPageNo
        {
            get 
            { 
                ...
            }
        }

        public override bool GetLocationFromViewPoint(Point viewPoint, out RadFixedPage page, out Point location)
        {
            ...
        }

        protected override PagesLayoutManagerBase PagesLayoutManager
        {
          get 
            { 
                ...
            }
        }

        protected override void UpdateScrollOffsetFromPosition(TextPosition position)
        {
            ...
        }

        protected override IEnumerable<FixedPageLayoutInfo> VisiblePages
        {
          get 
            { 
                ...
            }
        }
    }
    #endregion

    #region radpdfviewer-customization-and-extensibility-custom-document-presenter_2
    public class SinglePageLayoutManager : PagesLayoutManagerBase
    {
        public override void UpdateLayout(Size viewportSize)
        {
            ...
        }

        public override void Release()
        {
            ...
        }

        protected override List<FixedPageLayoutInfo> GetPagesLayoutInfos()
        {
            ...
        }
    }
    #endregion

    #region radpdfviewer-customization-and-extensibility-custom-document-presenter_3
        private SinglePageInfo visiblePage;
        private readonly List<SinglePageInfo> pageLayoutInfos;

        public SinglePageLayoutManager(IFixedDocumentPresenter presenter)
            : base(presenter)
        {
            this.pageLayoutInfos = new List<SinglePageInfo>();
        }
    #endregion

    #region radpdfviewer-customization-and-extensibility-custom-document-presenter_4
        this.pdfViewer.RegisterPresenter("CustomPresenterName", new CustomSinglePagePresenter());
    #endregion
}
