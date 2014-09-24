using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ModelRadFlowDocument
{
    public class UserControl_Cs
    {
        private void CreateRadFlowDocument()
        {
            #region radwordsprocessing-model-radflowdocument_0
            RadFlowDocument document = new RadFlowDocument();
            #endregion
        }

        private void AddSectionsToDocument()
        {
            #region radwordsprocessing-model-radflowdocument_1
            RadFlowDocument document = new RadFlowDocument();
            document.Sections.AddSection();
            #endregion

            #region radwordsprocessing-model-radflowdocument_2
            Section section = new Section(document);
            #endregion
        }

        private void MergeDocuments(RadFlowDocument document, RadFlowDocument sourceDocument)
        {
            #region radwordsprocessing-model-radflowdocument_3
            document.Merge(sourceDocument);
            #endregion

            #region radwordsprocessing-model-radflowdocument_4
            MergeOptions mergeOptions = new MergeOptions();
            mergeOptions.ConflictingStylesResolutionMode = ConflictingStylesResolutionMode.RenameSourceStyle;

            document.Merge(sourceDocument, mergeOptions);
            #endregion
        }

        private void UpdateFields(RadFlowDocument document)
        {
            #region radwordsprocessing-model-radflowdocument_5
            document.UpdateFields();
            #endregion
        }
    }
}
