using System;
using Telerik.Windows.Documents.Fixed.Model.Common;
using Telerik.Windows.Documents.Fixed.Model.Graphics;

namespace PdfProcessingDocumentationSourceCode.Examples.ModelPath
{
    public class UserControl_Cs
    {
        private void CreatePath(IContainerElement container, GeometryBase geometry)
        {
            #region radpdfprocessing-model-path_0
            Path path = new Path();
            path.Geometry = geometry;
            container.Content.Add(path); 
            #endregion
        }

        private void AddPath(IContainerElement container, GeometryBase geometry)
        {
            #region radpdfprocessing-model-path_1
            Path path = container.Content.AddPath();
            path.Geometry = geometry;
            #endregion
        }
    }
}
