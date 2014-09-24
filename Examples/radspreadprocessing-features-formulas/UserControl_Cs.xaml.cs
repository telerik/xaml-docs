using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Expressions;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FeaturesFormulas
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static void SetAndGetValueOfCellA1()
        {
            #region radspreadprocessing-features-formulas_0
            Workbook workbook = new Workbook();
            workbook.Worksheets.Add();
            workbook.ActiveWorksheet.Cells[0, 0].SetValue("=3+4");
            #endregion

            #region radspreadprocessing-features-formulas_1
            FormulaCellValue formulaCellValue = workbook.ActiveWorksheet.Cells[0, 0].GetValue().Value as FormulaCellValue;
            if (formulaCellValue != null)
            {
                RadExpression expression = formulaCellValue.Value;
                //expression is AdditionExpression with operands 3 and 4

                CellValueFormat format = workbook.ActiveWorksheet.Cells[0, 0].GetFormat().Value;
                string valueAsString = formulaCellValue.GetValueAsString(format);
                //valueAsString = "=3+4"

                string resultValueAsString = formulaCellValue.GetResultValueAsString(format);
                //resultAsString = "7"

                CellValueType valueType = formulaCellValue.ValueType;
                //valueType = Formula

                CellValueType resultValueType = formulaCellValue.ResultValueType;
                //resultValueType = Number
            }
            #endregion
        }
    }
}