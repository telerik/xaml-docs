using System;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.ColorSpaces;
using Telerik.Windows.Documents.Fixed.Model.Editing;
using Telerik.Windows.Documents.Fixed.Model.Graphics;
using Telerik.Windows.Documents.Fixed.Model.Navigation;

namespace PdfProcessingDocumentationSourceCode.Examples.ConceptsColorsAndColorSpaces
{
    public class UserControl_Cs
    {
        private void CreateSimpleColor()
        {
            #region radpdfprocessing-concepts-colors-and-color-spaces_0
            RgbColor magenta = new RgbColor(255, 0, 255);
            Path path = new Path();
            path.Fill = magenta;
            #endregion
        }

        private void CreateLinearGradient(RadFixedPage container)
        {
            #region radpdfprocessing-concepts-colors-and-color-spaces_1
            FixedContentEditor containerEditor = new FixedContentEditor(container);

            LinearGradient linearGradient = new LinearGradient(new Point(0, 0), new Point(30, 30));
            linearGradient.GradientStops.Add(new GradientStop(new RgbColor(0, 207, 0), 0));
            linearGradient.GradientStops.Add(new GradientStop(new RgbColor(0, 102, 204), 0));

            containerEditor.GraphicProperties.FillColor = linearGradient;
            containerEditor.DrawRectangle(new Rect(10, 10, 48, 29));
            #endregion
        }

        private void CreateTiling(RadFixedPage container)
        {
            #region radpdfprocessing-concepts-colors-and-color-spaces_2
            FixedContentEditor containerEditor = new FixedContentEditor(container);

            Tiling tiling = new Tiling(new Rect(0, 0, 10, 10));
            FixedContentEditor tilingEditor = new FixedContentEditor(tiling);
            tilingEditor.GraphicProperties.IsStroked = false;
            tilingEditor.GraphicProperties.FillColor = new RgbColor(128, 28, 43);
            tilingEditor.DrawRectangle(new Rect(2, 2, 5, 7));

            containerEditor.GraphicProperties.FillColor = tiling;
            containerEditor.DrawCircle(new Point(30, 30), 20);
            #endregion
        }
    }
}
