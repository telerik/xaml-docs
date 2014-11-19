using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Annotations;
using Telerik.Windows.Documents.Fixed.Model.Common;
using Telerik.Windows.Documents.Fixed.Model.Data;

namespace PdfProcessingDocumentationSourceCode.Examples.ModelRadFixedPage
{
    public class UserControl_Cs
    {
        private void CreateRadFixedPage()
        {
            #region radpdfprocessing-model-radfixedpage_0
            RadFixedDocument document = new RadFixedDocument();
            RadFixedPage page = new RadFixedPage();
            document.Pages.Add(page);
            #endregion
        }

        private void AddContentElement(ContentElementBase contentElement)
        {
            #region radpdfprocessing-model-radfixedpage_1
            RadFixedPage page = new RadFixedPage();
            page.Content.Add(contentElement);
            #endregion
        }

        private void AddAnnotation(Annotation annotation)
        {
            #region radpdfprocessing-model-radfixedpage_2
            RadFixedPage page = new RadFixedPage();
            page.Annotations.Add(annotation);
            #endregion
        }

        private void ModifyProperties()
        {
            #region radpdfprocessing-model-radfixedpage_3
            RadFixedPage page = new RadFixedPage();
            page.Rotation = Rotation.Rotate270;
            page.Size = new Size(792, 1128);
            #endregion
        }

    }
}
