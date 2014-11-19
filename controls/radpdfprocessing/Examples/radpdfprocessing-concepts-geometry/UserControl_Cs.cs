using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Fixed.Model.Graphics;

namespace PdfProcessingDocumentationSourceCode.Examples.ConceptsGeometry
{
    public class UserControl_Cs
    {
        private void CreateRectangleGeometry()
        {
            #region radpdfprocessing-concepts-geometry_0
            RectangleGeometry rectangleGeometry = new RectangleGeometry();
            rectangleGeometry.Rect = new Rect(10, 5, 400, 300);
            #endregion
        }

        private void CreatePathGeometry()
        {
            #region radpdfprocessing-concepts-geometry_1
            PathGeometry pathGeometry = new PathGeometry();
            PathFigure pathFigure = pathGeometry.Figures.AddPathFigure();
            pathFigure.StartPoint = new Point(5, 5);
            LineSegment lineSegment = pathFigure.Segments.AddLineSegment();
            lineSegment.Point = new Point(205, 5);
            BezierSegment bezierSegment = pathFigure.Segments.AddBezierSegment();
            bezierSegment.Point1 = new Point(105, 50);
            bezierSegment.Point2 = new Point(130, 105);
            bezierSegment.Point3 = new Point(100, 200);
            pathFigure.IsClosed = true;
            #endregion
        }
    }
}
