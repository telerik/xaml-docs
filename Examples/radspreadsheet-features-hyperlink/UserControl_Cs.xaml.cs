using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;
using Telerik.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FeaturesHyperlink
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static RadSpreadsheet radSpreadsheet = new RadSpreadsheet();
        Worksheet worksheet = radSpreadsheet.ActiveWorksheet;
        //get an instance of a worksheet. May be link to the UI documentation that shows: 
        //Worksheet worksheet = this.radSpreadsheet.ActiveWorksheet;

        public void CreateHyperlink()
        {
            //Create a hyperlink to a web address: 
            #region radspreadsheet-features-hyperlink_0
            HyperlinkInfo webAddres = HyperlinkInfo.CreateHyperlink("http://google.com", "Google");
            #endregion

            //Create a hyperlink to a cell range somewhere in the document: 
            #region radspreadsheet-features-hyperlink_1
            HyperlinkInfo inDocument = HyperlinkInfo.CreateInDocumentHyperlink("A1:B3", "Go to A1:B3");
            #endregion

            //Create a hyperlink to an email address: 
            #region radspreadsheet-features-hyperlink_2
            HyperlinkInfo mailto = HyperlinkInfo.CreateMailtoHyperlink("someOne@someCompany.com", "someSubject", "Mail to someOne");
            #endregion
        }

        public void AddNewHyperlink()
        {
            #region radspreadsheet-features-hyperlink_3
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            HyperlinkInfo webAddres = HyperlinkInfo.CreateHyperlink("http://google.com", "Google");
            CellIndex a1Index = new CellIndex(0, 0);
            SpreadsheetHyperlink spreadsheetHyperlink = worksheet.Hyperlinks.Add(a1Index, webAddres);
            #endregion
        }

        public void GetHyperlinks()
        {
            #region radspreadsheet-features-hyperlink_4
            CellIndex a1Index = new CellIndex(0, 0);
            CellIndex b3Index = new CellIndex(2, 1);
            CellRange a1b3Range = new CellRange(a1Index, b3Index);
            #endregion

            SpreadsheetHyperlink spreadsheetHyperlink;

            //Get all hyperlinks which ranges are contained in the A1:B3 cell range:
            #region radspreadsheet-features-hyperlink_5
            IEnumerable<SpreadsheetHyperlink> containingHyperlinks = worksheet.Hyperlinks.GetContainingHyperlinks(a1b3Range);
            #endregion

            //Get all hyperlinks which ranges intersect with in the A1:B3 cell range:
            #region radspreadsheet-features-hyperlink_6
            IEnumerable<SpreadsheetHyperlink> intersectingHyperlinks = worksheet.Hyperlinks.GetIntersectingHyperlinks(a1b3Range);
            #endregion

            //Get the last added hyperlink that intersects with the A1:B3 cell range:
            #region radspreadsheet-features-hyperlink_7
            bool canGetHyperlink = worksheet.Hyperlinks.TryGetHyperlink(a1Index, out spreadsheetHyperlink);
            #endregion

            //Get the hyperlink which range matches A1:B3 cell range: 
            #region radspreadsheet-features-hyperlink_8
            bool canGetHyperlinkExact = worksheet.Hyperlinks.TryGetHyperlinkExact(a1b3Range, out spreadsheetHyperlink);
            #endregion
        }

        public void RemoveHyperlinks()
        {
            CellIndex a1Index = new CellIndex(0, 0);

            #region radspreadsheet-features-hyperlink_9
            SpreadsheetHyperlink spreadsheetHyperlink;
            if (worksheet.Hyperlinks.TryGetHyperlink(a1Index, out spreadsheetHyperlink))
            {
                worksheet.Hyperlinks.Remove(spreadsheetHyperlink);
            }
            #endregion
        }
    }
}
