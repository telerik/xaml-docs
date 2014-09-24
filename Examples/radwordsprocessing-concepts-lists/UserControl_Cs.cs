using System;
using System.Linq;
using System.Windows.Media;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Lists;
using Telerik.Windows.Documents.Flow.Model.Styles;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.ConceptsLists
{
    public class UserControl_Cs
    {
        private void AddListTemplate(RadFlowDocument document)
        {
            #region radwordsprocessing-concepts-lists_0
            List list = document.Lists.Add(ListTemplateType.BulletDefault);
            #endregion
        }

        private void CreateList()
        {
            #region radwordsprocessing-concepts-lists_1
            RadFlowDocument document = new RadFlowDocument();
            Section section = document.Sections.AddSection();
            #endregion

            #region radwordsprocessing-concepts-lists_2
            List list = new List();
            document.Lists.Add(list); // Adding the list in the document.
            #endregion

            #region radwordsprocessing-concepts-lists_3
            for (int level = 0; level < list.Levels.Count; ++level)
            #endregion
            {
                #region radwordsprocessing-concepts-lists_4
                bool isEven = (level % 2) == 0;

                list.Levels[level].StartIndex = 1;
                // We set Decimal numbering style to a list level if it is even level, otherwise Bullet.
                list.Levels[level].NumberingStyle = isEven ? NumberingStyle.Decimal : NumberingStyle.Bullet;
                // Accordingly to the above rule, we set the corresponding NumberTextFormat.
                list.Levels[level].NumberTextFormat = isEven ? "%" + (level + 1) + "." : "o";
                // Set the desired indentation of the ListLevel can be done through its ParagraphProperties:
                list.Levels[level].ParagraphProperties.LeftIndent.LocalValue = 48 + (level * 24);
                #endregion
            }

            #region radwordsprocessing-concepts-lists_5
            for (int level = 0; level < list.Levels.Count; level++)
            {
                Paragraph paragrah = section.Blocks.AddParagraph();
                paragrah.Inlines.AddRun(string.Format("ListLevel: {0}", level + 1));
                paragrah.ListId = list.Id;
                paragrah.ListLevel = level;
            }
            #endregion
        }
    }
}
