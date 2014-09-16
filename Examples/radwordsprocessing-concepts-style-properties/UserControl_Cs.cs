using System;
using System.Linq;
using System.Windows.Media;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Styles;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ConceptsStyleProperties
{
    public class UserControl_Cs
    {
        private void GetParagraphProperties(Paragraph paragraph)
        {
            #region radwordsprocessing-concepts-style-properties_0
            bool keepOnOnePageActualValueShorthand = paragraph.KeepOnOnePage;
            bool keepOnOnePageActualValue = paragraph.Properties.KeepOnOnePage.GetActualValue().Value;
            #endregion
        }

        private void SetParagraphProperties(Paragraph paragraph)
        {
            #region radwordsprocessing-concepts-style-properties_1
            paragraph.KeepOnOnePage = true;
            paragraph.Properties.KeepOnOnePage.LocalValue = true;
            #endregion
        }

        private void GetLocalProperties(Style style)
        {
            #region radwordsprocessing-concepts-style-properties_2
            bool? keepOnOnePage = style.ParagraphProperties.KeepOnOnePage.LocalValue;
            #endregion
        }

        private void GetActualProperties(Style style)
        {
            #region radwordsprocessing-concepts-style-properties_3
            bool keepOnOnePage = style.ParagraphProperties.KeepOnOnePage.GetActualValue().Value;
            #endregion
        }

        private void GetDefaultvalueOfProperty()
        {
            #region radwordsprocessing-concepts-style-properties_4
            bool keepOnOnePageDefaultValue = Paragraph.KeepOnOnePagePropertyDefinition.DefaultValue.Value;
            #endregion
        }

    }
}
