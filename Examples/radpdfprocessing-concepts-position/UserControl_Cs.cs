using System;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.Fixed.Model.Data;
using Telerik.Windows.Documents.Fixed.Model.Graphics;

namespace PdfProcessingDocumentationSourceCode.Examples.ConceptsPosition
{
    public class UserControl_Cs
    {
        private void MatrixPositionTrasform()
        {
            #region radpdfprocessing-concepts-position_0
            MatrixPosition matrixPosition = new MatrixPosition();
            matrixPosition.Translate(20, 20); // Translates the position by (20, 20)
            matrixPosition.Translate(30, 30); // Translates the position by (30, 30).
            #endregion
        }


        private void SimplePositionTrasform()
        {
            #region radpdfprocessing-concepts-position_1
            SimplePosition simplePosition = new SimplePosition();
            simplePosition.Translate(20, 20); // Translates the position by (30, 30).
            simplePosition.Translate(30, 30); // Translates the position by (20, 20) overwriting the previous translations.
            #endregion
        }
    }
}
