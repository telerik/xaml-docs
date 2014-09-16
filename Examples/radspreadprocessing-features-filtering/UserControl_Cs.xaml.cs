using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.DataSeries;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Model.Filtering;

namespace FeaturesFiltering
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void CreateValuesCollectionFilter()
        {
            #region radspreadprocessing-features-filtering_0
            IEnumerable<string> stringItems = new List<string>() { "test", "1%", "1.0" };
            IEnumerable<DateGroupItem> dateItems = new List<DateGroupItem>()
            {
                new DateGroupItem(2013),
                new DateGroupItem(2014, 3)
            };

            ValuesCollectionFilter filter = new ValuesCollectionFilter(0, stringItems, dateItems, true);
            #endregion
        }

        public void CreateCustomFilter()
        {
            #region radspreadprocessing-features-filtering_1
            CustomFilterCriteria critera1 =
new CustomFilterCriteria(ComparisonOperator.EqualsTo, "Test string");
            CustomFilterCriteria critera2 =
            new CustomFilterCriteria(ComparisonOperator.GreaterThan, "-5");
            CustomFilter filter = new CustomFilter(0, critera1, LogicalOperator.Or, critera2);
            #endregion
        }

        public void CreateTopFilter()
        {
            #region radspreadprocessing-features-filtering_2
            TopFilter filter = new TopFilter(0, TopFilterType.BottomPercent, 30);
            #endregion
        }

        public void CreateDynamicFilter()
        {
            #region radspreadprocessing-features-filtering_3
            DynamicFilter filter = new DynamicFilter(0, DynamicFilterType.LastWeek);
            #endregion
        }

        public void CreateForeColorFilter()
        {
            #region radspreadprocessing-features-filtering_4
            ThemableColor color = new ThemableColor(Colors.Red);
            ForeColorFilter filter = new ForeColorFilter(0, color);
            #endregion
        }

        public void CreateFillColorFilter()
        {
            #region radspreadprocessing-features-filtering_5
            IFill fill = new PatternFill(PatternType.Solid, Colors.Red, Colors.Red);
            FillColorFilter filter = new FillColorFilter(0, fill);
            #endregion
        }

        public void SetFilter(Workbook workbook)
        {
            #region radspreadprocessing-features-filtering_6
            Worksheet worksheet = workbook.ActiveWorksheet;

            CellRange filterRange = new CellRange(0, 1, 5, 2);
            worksheet.Filter.FilterRange = filterRange;
            #endregion

            #region radspreadprocessing-features-filtering_7
            DynamicFilter filter = new DynamicFilter(1, DynamicFilterType.AboveAverage);
            #endregion

            #region radspreadprocessing-features-filtering_8
            worksheet.Filter.SetFilter(filter);
            #endregion

            #region radspreadprocessing-features-filtering_9
            worksheet.Cells[filterRange].Filter(filter);
            #endregion

            #region radspreadprocessing-features-filtering_10
            worksheet.Filter.ReapplyFilter(1);
            #endregion
        }

        public void RemoveFilter(Worksheet worksheet)
        {
            #region radspreadprocessing-features-filtering_11
            bool success = worksheet.Filter.RemoveFilter(1);
            #endregion
        }
    }
}
