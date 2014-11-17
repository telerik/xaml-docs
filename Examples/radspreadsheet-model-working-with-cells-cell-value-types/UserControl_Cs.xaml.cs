using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Expressions;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ModelCellsCellValueTypes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void SetValueMethod()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_0
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue(string.Empty);
            #endregion
        }

        public void ClearMethod()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_1
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].ClearValue();
            #endregion
        }

        public void SetBooleanValueUsingString()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_2
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue(true);
            worksheet.Cells[0, 1].SetValue(false);
            #endregion
        }

        public void SetBooleanValueUsingICellValue()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_3
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            ICellValue booleanCellValueTrue = CellValueFactory.Create(true);
            ICellValue booleanCellValueFalse = CellValueFactory.Create(false);
            worksheet.Cells[0, 0].SetValue(booleanCellValueTrue);
            worksheet.Cells[0, 1].SetValue(booleanCellValueFalse);
            #endregion
        }

        public void SetNumberCellValueUsingString()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_4
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("1.23");
            #endregion
        }

        public void SetNumberCelllValueUsingICellValue()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_5
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            ICellValue value = CellValueFactory.Create(3.14);
            worksheet.Cells[0, 0].SetValue(value);
            #endregion
        }

        public void SetNunmberCellValueWithFormat()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_6
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("1,234.5678");
            #endregion
        }

        public void SetNunmberCellValueWithCurrencyFormat()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_7
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("$123");
            #endregion
        }

        public void SetNunmberCellValueWithDateFormat()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_8
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("10/06/1987");
            #endregion
        }

        public void SetNunmberCellValueWithTimeFormat()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_9
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("13:30:45");
            #endregion
        }

        public void SetNunmberCellValueWithPercentageFormat()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_10
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("13%");
            #endregion
        }

        public void SetNunmberCellValueWithFractionFormat()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_11
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("1 13/67");
            #endregion
        }

        public void SetNunmberCellValueWithScientificFormat()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_12
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("1.24E+05");
            #endregion
        }

        public void SetFormulaCellValueUsingString()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_13
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("=A2");
            #endregion
        }

        public void SetFormulaCellValueUsingPredefinedFormulaString()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_14
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("=SUM(A2, 3)");
            #endregion
        }

        public void SetFormulaCellValueUsingICellValue()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_15
          
            #endregion
        }

        public void SetTextCellValueUsingString2()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_16
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetValue("Total");
            #endregion

            #region radspreadsheet-model-working-with-cells-cell-value-types_17
            RangePropertyValue<ICellValue> rangeValue = worksheet.Cells[0, 0].GetValue();
            ICellValue value = rangeValue.Value;
            #endregion
        }

        public void SetTextCellValueUsingString()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_19
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetValue("some text");
            #endregion
        }

        public void SetFormulaCellValueUsingPredefinedFormula()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_18
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellIndex cellIndex = new CellIndex(0, 0);

            ICellValue cellValue;
            CellValueFormat newFormatValue;
            CellValueFactory.Create("=A2 + B2", worksheet, cellIndex, CellValueFormat.GeneralFormat, out cellValue, out newFormatValue);
            worksheet.Cells[cellIndex].SetValue(cellValue);
            #endregion
        }

        public void SetTextCellValueUsingFormulaString()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_20
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            worksheet.Cells[0, 0].SetFormat(new CellValueFormat("@"));
            worksheet.Cells[0, 0].SetValue("=1+2");
            #endregion
        }

        public void SetTextCellValueUsingFormulaStringCellValueFactory()
        {
            #region radspreadsheet-model-working-with-cells-cell-value-types_21
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            CellIndex cellIndex = new CellIndex(0, 0);

            ICellValue cellValue;
            CellValueFormat newFormatValue;
            CellValueFactory.Create("=1 + 2", worksheet, cellIndex, new CellValueFormat("@"), out cellValue, out newFormatValue);
            worksheet.Cells[cellIndex].SetValue(cellValue);
            #endregion
        }
    }
}
