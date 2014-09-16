using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Telerik.Windows.Controls;
using Telerik.Windows.Documents.FormatProviders.Html;
using Telerik.Windows.Documents.FormatProviders.Xaml;
using Telerik.Windows.Documents.Model;

namespace FAQ
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs : UserControl
    {

        #region radrichtextbox-frequently-asked-questions_1
        public void SetDefaultFontPropertiesToEditor(RadRichTextBox editor)
        {
            this.radRichTextBox1.FontFamily = new FontFamily("Comic Sans MS");
            this.radRichTextBox1.FontSize = Unit.PointToDip(12);
            this.radRichTextBox1.FontStyle = FontStyles.Italic;
            this.radRichTextBox1.FontWeight = FontWeights.Bold;
            this.radRichTextBox1.DocumentInheritsDefaultStyleSettings = true;
        }
        #endregion

        #region radrichtextbox-frequently-asked-questions_2
        public string GetXAML(RadDocument document)
        {
            XamlFormatProvider provider = new XamlFormatProvider();
            return provider.Export(document);
        }
        #endregion

        #region radrichtextbox-frequently-asked-questions_3
        public RadDocument ImportHtml(string content)
        {
            HtmlFormatProvider provider = new HtmlFormatProvider();
            return provider.Import(content);
        }
        #endregion

        private void InsertText(string textToInsert)
        {
            #region radrichtextbox-frequently-asked-questions_4
            this.radRichTextBox.Insert(textToInsert);
            #endregion
        }

        private void ChangeMargins()
        {
            #region radrichtextbox-frequently-asked-questions_9
            this.editor.Padding = new Thickness(0, 20, 100, 60);
            #endregion

            #region radrichtextbox-frequently-asked-questions_10
            this.editor.Document.LayoutMode = DocumentLayoutMode.Paged;
            this.editor.Document.SectionDefaultPageMargin = new Telerik.Windows.Documents.Layout.Padding(0, 20, 100, 60);
            #endregion

            #region radrichtextbox-frequently-asked-questions_11
            this.editor.Document.Sections.First.PageMargin = new Telerik.Windows.Documents.Layout.Padding(0, 20, 100, 60);
            #endregion
        }
    }
}