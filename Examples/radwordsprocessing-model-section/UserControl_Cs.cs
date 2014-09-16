using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Styles;
using Telerik.Windows.Documents.Model;
using Telerik.Windows.Documents.Primitives;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelSection
{
    public class UserControl_Cs
    {
        #region radwordsprocessing-model-section_
        #endregion

        private void CreateSection(RadFlowDocument document)
        {
            #region radwordsprocessing-model-section_0
            Section section = new Section(document);
            document.Sections.Add(section);
            #endregion
        }

        private void CreateSectionWithMethod(RadFlowDocument document)
        {
            #region radwordsprocessing-model-section_1
            Section section = document.Sections.AddSection();
            #endregion
        }

        private void ModifySection(Section section)
        {
            #region radwordsprocessing-model-section_2
            section.PageMargins = new Padding(10, 10, 5, 5);
            #endregion

            #region radwordsprocessing-model-section_3
            section.PageOrientation = PageOrientation.Landscape;
            #endregion

            #region radwordsprocessing-model-section_4
            section.PageSize = PaperTypeConverter.ToSize(PaperTypes.A4);
            #endregion
        }

        private void CreateHeader(Section section)
        {
            #region radwordsprocessing-model-section_5
            Header header = section.Headers.Add();
            Paragraph paragraph = header.Blocks.AddParagraph();
            paragraph.TextAlignment = Alignment.Right;
            paragraph.Inlines.AddRun("This is a sample header.");
            #endregion
        }

        private void AddBlocksToSection(Section section)
        {
            #region radwordsprocessing-model-section_6
            Paragraph paragraph = section.Blocks.AddParagraph();
            Table table = section.Blocks.AddTable();
            #endregion
        }
    }
}
