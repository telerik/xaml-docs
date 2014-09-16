using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Documents.Model;

namespace DocumentElementsTable
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

        private void CreateTable()
        {
            #region radrichtextbox-features-document-elements-tables_2
            RadDocument document = new RadDocument();
            Section section = new Section();

            Table table = new Table();
            table.StyleName = RadDocumentDefaultStyles.DefaultTableGridStyleName;

            TableRow row1 = new TableRow();

            TableCell cell1 = new TableCell();
            Paragraph p1 = new Paragraph();
            Span s1 = new Span();
            s1.Text = "Cell 1";
            p1.Inlines.Add(s1);
            cell1.Blocks.Add(p1);
            row1.Cells.Add(cell1);

            TableCell cell2 = new TableCell();
            Paragraph p2 = new Paragraph();
            Span s2 = new Span();
            s2.Text = "Cell 2";
            p2.Inlines.Add(s2);
            cell2.Blocks.Add(p2);
            row1.Cells.Add(cell2);
            table.Rows.Add(row1);

            TableRow row2 = new TableRow();

            TableCell cell3 = new TableCell();
            cell3.ColumnSpan = 2;
            Paragraph p3 = new Paragraph();
            Span s3 = new Span();
            s3.Text = "Cell 3";
            p3.Inlines.Add(s3);
            cell3.Blocks.Add(p3);
            row2.Cells.Add(cell3);
            table.Rows.Add(row2);

            section.Blocks.Add(new Paragraph());
            section.Blocks.Add(table);
            section.Blocks.Add(new Paragraph());
            document.Sections.Add(section);

            this.radRichTextBox.Document = document;
            #endregion
        }

    }


}
