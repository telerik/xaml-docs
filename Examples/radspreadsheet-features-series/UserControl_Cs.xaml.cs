using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.DataSeries;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FeaturesFillDataAutomaticallySeries
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void FillSeriesLinear()
        {
            #region radspreadsheet-features-series_0

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetValue(1);
            worksheet.Cells[0, 1].SetValue(3);

            CellRange range = new CellRange(0, 0, 0, 5);
            worksheet.Cells[range].FillDataSeriesLinear(CellOrientation.Horizontal, 2);

            #endregion
        }

        public void FillSeriesLinearTrend()
        {
            #region radspreadsheet-features-series_1

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetValue(1);
            worksheet.Cells[0, 1].SetValue(8);
            worksheet.Cells[0, 2].SetValue(3);
            worksheet.Cells[0, 3].SetValue(10);
            worksheet.Cells[0, 4].SetValue(5);

            CellRange range = new CellRange(0, 0, 0, 9);
            worksheet.Cells[range].FillDataSeriesLinearTrend(CellOrientation.Horizontal);

            #endregion
        }

        public void FillSeriesExponential()
        {
            #region radspreadsheet-features-series_2

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetValue(1);
            worksheet.Cells[0, 1].SetValue(3);

            CellRange range = new CellRange(0, 0, 0, 5);
            worksheet.Cells[range].FillDataSeriesExponential(CellOrientation.Horizontal, 4);

            #endregion
        }

        public void FillSeriesExponentialTrend()
        {
            #region radspreadsheet-features-series_3

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetValue(1);
            worksheet.Cells[0, 1].SetValue(5);
            worksheet.Cells[0, 2].SetValue(2);
            worksheet.Cells[0, 3].SetValue(9);

            CellRange range = new CellRange(0, 0, 0, 5);
            worksheet.Cells[range].FillDataSeriesExponentialTrend(CellOrientation.Horizontal);

            #endregion
        }

        public void FillSeriesDate()
        {
            #region radspreadsheet-features-series_4

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetValue(new DateTime(2013, 5, 28));

            CellRange range = new CellRange(0, 0, 0, 9);
            worksheet.Cells[range].FillDataSeriesDate(CellOrientation.Horizontal, DateUnitType.Weekday, 2);

            #endregion
        }

        public void FillSeriesAuto1()
        {
            #region radspreadsheet-features-series_5

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 0].SetValue("1st");

            CellRange range = new CellRange(0, 0, 0, 5);
            worksheet.Cells[range].FillDataSeriesAuto(CellOrientation.Horizontal, true);

            #endregion
        }

        public void FillSeriesAuto2()
        {
            #region radspreadsheet-features-series_6

            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet.Cells[0, 5].SetValue("6th");

            CellRange range = new CellRange(0, 5, 0, 0);
            worksheet.Cells[range].FillDataSeriesAuto(CellOrientation.Horizontal, true);

            #endregion
        }
    }
}
