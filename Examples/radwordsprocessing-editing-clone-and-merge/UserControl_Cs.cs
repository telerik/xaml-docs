using System;
using System.Linq;
using Telerik.Windows.Documents.Flow.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.EditingCloneAndMerge
{
    public class UserControl_Cs
    {
        private void MergeDocuments()
        {
            #region radwordsprocessing-editing-clone-and-merge_0
            RadFlowDocument target = new RadFlowDocument();
            RadFlowDocument source = new RadFlowDocument();
            //...
            // target will contain merged content and styles.
            target.Merge(source);
            #endregion
        }

        private void MergeDocumentsWithOptions()
        {
            #region radwordsprocessing-editing-clone-and-merge_1
            RadFlowDocument target = new RadFlowDocument();
            RadFlowDocument source = new RadFlowDocument();
            //...
            MergeOptions mergeOptions = new MergeOptions()
            {
                ConflictingStylesResolutionMode = ConflictingStylesResolutionMode.RenameSourceStyle
            };
            target.Merge(source, mergeOptions);
            #endregion
        }

        private void CloneDocument(RadFlowDocument document)
        {
            #region radwordsprocessing-editing-clone-and-merge_2
            RadFlowDocument clonedDocument = document.Clone();
            #endregion
        }

        private void CloneSection(RadFlowDocument radFlowDocument, Section section)
        {
            #region radwordsprocessing-editing-clone-and-merge_3
            Section clonedSection = section.Clone(radFlowDocument);
            #endregion
        }


    }
}
