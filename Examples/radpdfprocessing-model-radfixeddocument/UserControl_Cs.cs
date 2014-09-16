using System;
using System.IO;
using System.Linq;
using Telerik.Windows.Documents.Fixed.Model;

namespace PdfProcessingDocumentationSourceCode.Examples.ModelRadFixedDocument
{
    public class UserControl_Cs
    {
        private void CreateRadFixedDocument()
        {
            #region radpdfprocessing-model-radfixeddocument_0
            RadFixedDocument document = new RadFixedDocument();
            #endregion
        }

        private void AddPagesToFixedDocument(RadFixedDocument document)
        {
            #region radpdfprocessing-model-radfixeddocument_1
            RadFixedPage page = document.Pages.AddPage();
            #endregion
        }

        private void CreateAndAddPagesToFixedDocument(RadFixedDocument document)
        {
            #region radpdfprocessing-model-radfixeddocument_2
            RadFixedPage page = new RadFixedPage();
            document.Pages.Add(page);
            #endregion
        }
    }
}
