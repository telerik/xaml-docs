using System;
using System.Linq;
using System.Windows.Controls;
using Telerik.Windows.Controls.Spreadsheet.Worksheets;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Model.Shapes;

namespace UIWorkingWithSelection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs : UserControl
    {
        public Default_Cs()
        {
            InitializeComponent();
        }

        public void RetrievingTheActiveCellAndAllSelectedCellsExample()
        {
            #region radspreadsheet-ui-working-with-selection_0
            Selection selection = this.radSpreadsheet.ActiveWorksheetEditor.Selection;

            selection.ActiveCellMode = ActiveCellMode.Edit;
            #endregion
        }

        public void ChangingTheUISelection1()
        {
            #region radspreadsheet-ui-working-with-selection_1
            Selection selection = this.radSpreadsheet.ActiveWorksheetEditor.Selection;

            selection.Select(new CellIndex(0, 0), false);
            #endregion
        }

        public void ChangingTheUISelection2()
        {
            #region radspreadsheet-ui-working-with-selection_2
            Selection selection = this.radSpreadsheet.ActiveWorksheetEditor.Selection;

            selection.Select(new CellRange(0, 0, 2, 2));
            #endregion
        }

        public void ChangingTheUISelection3()
        {
            #region radspreadsheet-ui-working-with-selection_3
            Selection selection = this.radSpreadsheet.ActiveWorksheetEditor.Selection;

            selection.Select(6, 1, 2, 4);
            #endregion
        }

        public void SelectingAllCellsInAWorksheet()
        {
            #region radspreadsheet-ui-working-with-selection_4
            Selection selection = this.radSpreadsheet.ActiveWorksheetEditor.Selection;

            selection.SelectAll();

            CellRange usedRange = this.radSpreadsheet.ActiveWorksheet.UsedCellRange;
            selection.Select(usedRange);
            #endregion
        }

        public void SelectionEvents()
        {
            #region radspreadsheet-ui-working-with-selection_5
            Selection selection = this.radSpreadsheet.ActiveWorksheetEditor.Selection;

            selection.BeginUpdate();

            selection.Select(new CellRange(4, 3, 8, 5));
            selection.Select(new CellRange(5, 2, 3, 3), clearSelection: false);
            selection.Select(new CellIndex(2, 1), clearSelection: false);

            selection.EndUpdate();
            #endregion
        }

        public void SavingAndRestoringTheUISelection()
        {
            #region radspreadsheet-ui-working-with-selection_6
            Selection selection = this.radSpreadsheet.ActiveWorksheetEditor.Selection;

            selection.Select(new CellRange(4, 3, 8, 5));

            SelectionState selectionState = selection.CreateSelectionState();

            selection.Select(new CellRange(5, 2, 3, 3), clearSelection: false);
            selection.Select(new CellIndex(2, 1), clearSelection: false);

            selection.RestoreSelectionState(selectionState);
            #endregion
        }

        public void FloatingImageTheUISelection()
        {
            #region radspreadsheet-ui-working-with-selection_7
            Selection selection = this.radSpreadsheet.ActiveWorksheetEditor.Selection;

            FloatingImage image = this.radSpreadsheet.ActiveWorksheet.Shapes.First() as FloatingImage;
            selection.Select(image);

            #endregion
        }

        public void FloatingImageTheUIDeselection()
        {
            #region radspreadsheet-ui-working-with-selection_8
            Selection selection = this.radSpreadsheet.ActiveWorksheetEditor.Selection;

            FloatingImage image2 = this.radSpreadsheet.ActiveWorksheet.Shapes.ElementAt(1) as FloatingImage;
            selection.Select(image2, true);

            #endregion
        }
    }
}