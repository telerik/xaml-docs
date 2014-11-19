using System;
using System.Linq;
using System.Windows.Media;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Editing;
using Telerik.Windows.Documents.Fixed.Model.Editing.Tables;

namespace PdfProcessingDocumentationSourceCode.Examples.EditingRadFixedDocumentEditor
{
    public class UserControl_Cs
    {
        private void CreateRadFixedDocumentEditor(RadFixedDocument radFixedDocument, FontFamily fontFamily)
        {
            #region radpdfprocessing-editing-radfixeddocumenteditor_0
            RadFixedDocumentEditor editor = new RadFixedDocumentEditor(radFixedDocument);
            #endregion

            #region radpdfprocessing-editing-radfixeddocumenteditor_1
            editor.InsertSectionBreak();
            #endregion
        }

        private void InsertParagraphAndInlines(RadFixedDocumentEditor editor, FontFamily fontFamily)
        {
            #region radpdfprocessing-editing-radfixeddocumenteditor_2
            editor.InsertParagraph();
            #endregion

            #region radpdfprocessing-editing-radfixeddocumenteditor_3
            editor.InsertRun("text");
            editor.InsertRun(fontFamily, "text");
            #endregion

            #region radpdfprocessing-editing-radfixeddocumenteditor_4
            editor.InsertLine("Line of text");
            #endregion
        }

        private void InsertTable(RadFixedDocumentEditor editor, Table table)
        {
            #region radpdfprocessing-editing-radfixeddocumenteditor_5
            editor.InsertTable(table);
            #endregion
        }
    }
}
