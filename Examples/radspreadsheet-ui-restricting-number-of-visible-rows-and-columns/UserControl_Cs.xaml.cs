using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace UIRestrictingNumberOfVisibleRowsColumns
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs : UserControl
    {
        public void ChangeVisibleSize()
        {
            #region radspreadsheet-ui-restricting-number-of-visible-rows-and-columns_0
            radSpreadsheet.VisibleSize = new SizeI(50, 100);
            #endregion
        }
    }
}