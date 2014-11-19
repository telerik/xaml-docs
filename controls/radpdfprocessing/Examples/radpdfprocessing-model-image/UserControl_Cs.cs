using System;
using System.IO;
using System.Linq;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Common;
using Telerik.Windows.Documents.Fixed.Model.Objects;
using Telerik.Windows.Documents.Fixed.Model.Resources;

namespace PdfProcessingDocumentationSourceCode.Examples.ModelImage
{
    public class UserControl_Cs
    {
        private void CreateImage(IContainerElement container)
        {
            #region radpdfprocessing-model-image_0
            Image image = new Image();
            container.Content.Add(image);
            #endregion
        }

        private void AddImage(IContainerElement container, ImageSource imageSource)
        {
            #region radpdfprocessing-model-image_1
            Image image = container.Content.AddImage();
            Image imageWithSource = container.Content.AddImage(imageSource);
            #endregion
        }
    }
}
