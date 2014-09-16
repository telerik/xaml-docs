using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Styles;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelHeaderFooter
{
    public class UserControl_Cs
    {
        private void CreateHeaders()
        {
            #region radwordsprocessing-model-headers-footers_0
            RadFlowDocument document = new RadFlowDocument();
            document.Sections.AddSection();

            document.Sections.First().Headers.Add(); // Creates the default Header.
            document.Sections.First().Headers.Add(HeaderFooterType.First);
            document.Sections.First().Headers.Add(HeaderFooterType.Even);
            #endregion
        }

        private void CreateFooters()
        {
            #region radwordsprocessing-model-headers-footers_1
            RadFlowDocument document = new RadFlowDocument();
            document.Sections.AddSection();

            document.Sections.First().Footers.Add(); // Creates the default Footer.
            document.Sections.First().Footers.Add(HeaderFooterType.First);
            document.Sections.First().Footers.Add(HeaderFooterType.Even);
            #endregion
        }

        private void ObtainDefaultHeaderFooter(Section section)
        {
            #region radwordsprocessing-model-headers-footers_2
            Header defaultHeader = section.Headers.Default;
            #endregion

            #region radwordsprocessing-model-headers-footers_3
            Footer defaultFooter = section.Footers.Default;
            #endregion
        }

        private void AddEvenOddHeader()
        {
            #region radwordsprocessing-model-headers-footers_4
            RadFlowDocument document = new RadFlowDocument();
            document.Sections.AddSection();
            document.HasDifferentEvenOddPageHeadersFooters = true;

            Header defaultHeader = document.Sections.First().Headers.Add();
            Paragraph defaultHeaderParagraph = defaultHeader.Blocks.AddParagraph();
            defaultHeaderParagraph.TextAlignment = Alignment.Right;
            defaultHeaderParagraph.Inlines.AddRun("This is a sample odd page header.");

            Header evenHeader = document.Sections.First().Headers.Add(HeaderFooterType.Even);
            Paragraph evenHeaderParagraph = evenHeader.Blocks.AddParagraph();
            evenHeaderParagraph.TextAlignment = Alignment.Left;
            evenHeaderParagraph.Inlines.AddRun("This is a sample even page header.");
            #endregion
        }
    }
}
