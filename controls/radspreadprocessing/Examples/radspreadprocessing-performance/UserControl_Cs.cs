using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Core;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace Performance
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public class UserControl_Cs
    {
        private void SuspendLayout()
        {
            #region radspreadprocessing-performance_0
            Workbook workbook = new Workbook();
            workbook.SuspendLayoutUpdate();
            // The code which generates the document
            workbook.ResumeLayoutUpdate();
            #endregion
        }

        private void SuspendLayoutInUndoScope()
        {
            #region radspreadprocessing-performance_1
            Workbook workbook = new Workbook();
            using (new UpdateScope(workbook.SuspendLayoutUpdate, workbook.ResumeLayoutUpdate))
            {
                // The code which generates the document
            }
            #endregion
        }

        private void CreateUndoGroup()
        {
            #region radspreadprocessing-performance_2
            Workbook workbook = new Workbook();
            workbook.History.BeginUndoGroup();
            // The code which generates the document
            workbook.History.EndUndoGroup();
            #endregion
        }

        private void CreateUndoGroupUndoScope()
        {
            #region radspreadprocessing-performance_3
            Workbook workbook = new Workbook();
            using (new UpdateScope(workbook.History.BeginUndoGroup, workbook.History.EndUndoGroup))
            {
                // The code which generates the document
            }
            #endregion
        }

        private void DisableHistory(Workbook workbook)
        {
            #region radspreadprocessing-performance_4
            workbook.History.IsEnabled = false;
            // The code which generates the document
            workbook.History.IsEnabled = true;
            #endregion
        }

        private void DisableHistoryUndoScope(Workbook workbook)
        {
            #region radspreadprocessing-performance_5
            using (new UpdateScope(
                () => { workbook.History.IsEnabled = false; },
                () => { workbook.History.IsEnabled = true; }))
            {
                // The code which generates the document
            }
            #endregion
        }
    }
}
