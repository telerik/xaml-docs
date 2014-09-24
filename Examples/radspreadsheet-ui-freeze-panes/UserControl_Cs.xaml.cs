using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Spreadsheet.Worksheets;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FreezPanes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        RadSpreadsheet radSpreadsheet = new RadSpreadsheet();

        private void FreezePanesRight()
        {
            #region radspreadsheet-ui-freez-panes_01

            RadWorksheetEditor worksheetEditor = radSpreadsheet.ActiveWorksheetEditor;
            worksheetEditor.FreezePanes(new CellIndex(4, 1));

            #endregion
        }

        private void FreezePanesUnfreezePanes()
        {
            #region radspreadsheet-ui-freez-panes_02

            RadWorksheetEditor worksheetEditor = radSpreadsheet.ActiveWorksheetEditor;
            worksheetEditor.UnfreezePanes();

            #endregion
        }

    }
}
