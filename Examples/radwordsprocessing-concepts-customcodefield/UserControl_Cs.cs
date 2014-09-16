using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Fields;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ConceptsCustomCodeField
{
    public class UserControl_Cs
    {
        private void CreateFields(RadFlowDocumentEditor editor)
        {
            #region radwordsprocessing-concepts-customcodefield_0
            editor.InsertField("PAGE  \\* ROMAN", "VII");
            #endregion

            #region radwordsprocessing-concepts-customcodefield_1
            editor.InsertText("Page ");
            editor.InsertField("PAGE", "3");
            editor.InsertText(" of ");
            editor.InsertField("NUMPAGES", "5");
            #endregion

            #region radwordsprocessing-concepts-customcodefield_2
            //editor.InsertField("DATE  \\@ \"M/d/yy\"", "17/2/14");
            #endregion

            #region radwordsprocessing-concepts-customcodefield_3
            editor.InsertField("AUTHOR  \\* Upper", "JOHN DOE");
            #endregion

            #region radwordsprocessing-concepts-customcodefield_4
            FieldInfo tocField = editor.InsertField("TOC \\o \"1-3\" \\h \\z \\u", "result");
            tocField.IsDirty = true;
            #endregion
        }

    }
}
