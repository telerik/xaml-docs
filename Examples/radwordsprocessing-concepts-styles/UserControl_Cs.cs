using System;
using System.Linq;
using System.Windows.Media;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Styles;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ConceptsStyles
{
    public class UserControl_Cs
    {
        private void CreateTableStyle(RadFlowDocument document)
        {
            #region radwordsprocessing-concepts-styles_0
            Style tableStyle = new Style("TableStyle", StyleType.Table);
            tableStyle.Name = "Table Style";
            tableStyle.TableProperties.Borders.LocalValue = new TableBorders(new Border(1, BorderStyle.Single, new ThemableColor(Colors.Blue)));
            tableStyle.TableProperties.Alignment.LocalValue = Alignment.Center;
            tableStyle.TableCellProperties.VerticalAlignment.LocalValue = VerticalAlignment.Center;
            document.StyleRepository.Add(tableStyle);
            #endregion
        }

        private void GetHeading1(RadFlowDocument document)
        {
            #region radwordsprocessing-concepts-styles_1
            string heading1StyleId = BuiltInStyleNames.GetHeadingStyleIdByIndex(1);
            Style heading1Style = document.StyleRepository.AddBuiltInStyle(heading1StyleId);
            #endregion
        }
    }
}
