using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Common;
using Telerik.Windows.Documents.Fixed.Model.Graphics;
using Telerik.Windows.Documents.Fixed.Model.Objects;
using Telerik.Windows.Documents.Fixed.Model.Resources;

namespace PdfProcessingDocumentationSourceCode.Examples.ConceptsClipping
{
    public class UserControl_Cs
    {
        private void CreateClipping(IContentRootElement container, ImageSource imageSource)
        {
            #region radpdfprocessing-concepts-clipping_0
            Clipping clipping = new Clipping();
            clipping.Clip = new RectangleGeometry(new Rect(5, 5, 50, 50));
            #endregion

            #region radpdfprocessing-concepts-clipping_1
            Image image = container.Content.AddImage(imageSource);
            image.Clipping = clipping;
            #endregion
        }
    }
}
