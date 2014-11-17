using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Styles;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace RadWordsProcessingDocumentationSourceCode.Examples.EditingRadFlowDocumentEditor
{
    public class UserControl_Cs
    {
        private void CreateRadFlowDocumentEditor()
        {
            #region radwordsprocessing-editing-radflowdocumenteditor_0
            RadFlowDocument document = new RadFlowDocument();
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);
            #endregion
        }

#if silverlight
        #region radwordsprocessing-editing-radflowdocumenteditor_1
            public void MoveToInlineStart(InlineBase inline)
            public void MoveToInlineEnd(InlineBase inline)
            public void MoveToParagraphStart(Paragraph paragraph)
            public void MoveToTableEnd(Table table)
        #endregion
#endif

        private void MovePositonInEditor(RadFlowDocumentEditor editor, RadFlowDocument document)
        {
            #region radwordsprocessing-editing-radflowdocumenteditor_2
            Paragraph firstParagraph = document.EnumerateChildrenOfType<Paragraph>().First();
            editor.MoveToInlineEnd(firstParagraph.Inlines[1]);
            #endregion
        }

        private RadFlowDocument CreateDocument()
        {
            #region radwordsprocessing-editing-radflowdocumenteditor_3
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());
            editor.InsertText("Hello word!");
            return editor.Document;
            #endregion
        }

        private void InsertRun(RadFlowDocumentEditor editor)
        {
            #region radwordsprocessing-editing-radflowdocumenteditor_4
            editor.InsertText("First" + Environment.NewLine + "Second");
            #endregion
        }

        private void InsertParagraph(RadFlowDocumentEditor editor)
        {
            #region radwordsprocessing-editing-radflowdocumenteditor_5
            editor.InsertText("First paragraph");
            editor.InsertParagraph();
            editor.InsertText("Second paragraph");
            #endregion
        }

        private void InsertHyperlink(RadFlowDocumentEditor editor)
        {
            #region radwordsprocessing-editing-radflowdocumenteditor_6
            editor.InsertHyperlink("telerik", "http://www.telerik.com", false, "Telerik site");
            #endregion
        }

        private void InsertFieldInFragment(RadFlowDocumentEditor editor, RadFlowDocument document)
        {
            #region radwordsprocessing-editing-radflowdocumenteditor_7
            // Create header and move the editor
            Header header = document.Sections[0].Headers.Add();
            editor.MoveToParagraphStart(header.Blocks.AddParagraph());

            editor.InsertText("Page ");
            editor.InsertField("PAGE", "1");
            editor.InsertText(" of ");
            editor.InsertField("NUMPAGES", "1");
            #endregion
        }

#if silverlight
        #region radwordsprocessing-editing-radflowdocumenteditor_8
        public ImageInline InsertImageInline(ImageSource source, Size size)
        public ImageInline InsertImageInline(Stream stream, string extension, Size size)
        public FloatingImage InsertFloatingImage(ImageSource source, Size size)
        public FloatingImage InsertFloatingImage(Stream stream, string extension, Size size)
        #endregion
#endif

        private void InsertImage(RadFlowDocumentEditor editor)
        {
            #region radwordsprocessing-editing-radflowdocumenteditor_9
            editor.InsertText("Image:");
            using (Stream stream = this.GetResourceStream("Telerik_logo.png"))
            {
                editor.InsertImageInline(stream, "png", new Size(118, 28));
            }
            #endregion
        }

        private Stream GetResourceStream(string p)
        {
            throw new NotImplementedException();
        }

        private void ImsertTable(RadFlowDocumentEditor editor, RadFlowDocument document)
        {
            #region radwordsprocessing-editing-radflowdocumenteditor_10
            document.StyleRepository.AddBuiltInStyle(BuiltInStyleNames.TableGridStyleId);
            editor.TableFormatting.StyleId = BuiltInStyleNames.TableGridStyleId;

            editor.InsertText("Before table.");
            editor.InsertTable(2, 4);
            editor.InsertText("After table.");
            #endregion
        }

        private void InsertCodeSnippet(RadFlowDocumentEditor editor)
        {
            #region radwordsprocessing-editing-radflowdocumenteditor_11
            // Set code block formatting
            var codeFont = new ThemableFontFamily(new FontFamily("Consolas"));
            editor.CharacterFormatting.FontFamily.LocalValue = codeFont;
            editor.ParagraphFormatting.SpacingAfter.LocalValue = 0;

            editor.InsertLine("static void Main(string[] args)");
            editor.InsertLine("{");
            editor.InsertLine("    Console.WriteLine(\"Hello World\");");
            editor.InsertLine("}");
            #endregion
        }

    }
}
