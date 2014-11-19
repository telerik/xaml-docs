using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Editing;
using Telerik.Windows.Documents.Fixed.Model.Graphics;

namespace PdfProcessingDocumentationSourceCode.Examples.GettingStarted
{
    public class UserControl_Cs
    {
        private void GettingStarted()
        {
            #region radpdfprocessing-getting-started_0
            RadFixedDocument document = new RadFixedDocument();
            RadFixedPage page = document.Pages.AddPage();
            #endregion

            #region radpdfprocessing-getting-started_1
            FixedContentEditor editor = new FixedContentEditor(page);
            editor.DrawText("Hello RadPdfProcessing!");
            #endregion

            #region radpdfprocessing-getting-started_2
            PdfFormatProvider provider = new PdfFormatProvider();
            using (Stream output = File.OpenWrite("Hello.pdf"))
            {
                provider.Export(document, output);
            }
            #endregion
        }
    }
}
