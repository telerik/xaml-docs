using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Documents.Model;

namespace FeaturesReadOnlyRanges
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs : UserControl
    {
        public Default_Cs()
        {
            InitializeComponent();
        }

        private void InsertReadOnlyRange()
        {
            #region radrichtextbox-features-read-only-ranges_0
            this.radRichTextBox.InsertReadOnlyRange();
            #endregion
        }

        private void BuildDocumentWithReadOnlyRange()
        {
            #region radrichtextbox-features-read-only-ranges_1
            RadDocument document = new RadDocument();
            Section section = new Section();
            Paragraph paragraph = new Paragraph();
            Span span = new Span("Content prior range[");
            Span span2 = new Span("]Content after range");
            Span readOnlyContent = new Span("READ ONLY");

            ReadOnlyRangeStart rangeStart = new ReadOnlyRangeStart();
            ReadOnlyRangeEnd rangeEnd = new ReadOnlyRangeEnd();
            rangeEnd.PairWithStart(rangeStart);

            paragraph.Inlines.Add(span);
            paragraph.Inlines.Add(rangeStart);
            paragraph.Inlines.Add(readOnlyContent);
            paragraph.Inlines.Add(rangeEnd);
            paragraph.Inlines.Add(span2);

            section.Blocks.Add(paragraph);
            document.Sections.Add(section);
            #endregion
        }

        private void DeleteReadOnlyrange()
        {
            #region radrichtextbox-features-read-only-ranges_2
            this.radRichTextBox.DeleteReadOnlyRange();
            #endregion

            #region radrichtextbox-features-read-only-ranges_3
            ReadOnlyRangeStart start = this.radRichTextBox.Document.EnumerateChildrenOfType<ReadOnlyRangeStart>().Where(x => x.Tag == "ReadOnly").FirstOrDefault();
            if (start != null)
            {
                this.radRichTextBox.DeleteReadOnlyRange(start);
            }
            #endregion
        }
    }
}
