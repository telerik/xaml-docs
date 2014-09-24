using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radrichtextbox-guidelines-for-printing-with-raddocument_0
Table table = new Table();
TableRow row1 = new TableRow();
TableRow row2 = new TableRow();
TableCell cell11 = new TableCell() { ColumnSpan = 2};
TableCell cell12 = new TableCell();
TableCell cell21 = new TableCell();
TableCell cell22 = new TableCell() { ColumnSpan = 2 };

row1.Cells.Add(cell11);
row1.Cells.Add(cell12);
row2.Cells.Add(cell21);
row2.Cells.Add(cell22);

table.Rows.Add(row1);
table.Rows.Add(row2);
#endregion

    
#region radrichtextbox-guidelines-for-printing-with-raddocument_1
cell.PreferredWidth = new TableWidthUnit(TableWidthUnitType.Fixed, width);
#endregion

#region radrichtextbox-guidelines-for-printing-with-raddocument_2
TableCell cell11 = new TableCell() { Padding = new Padding(20) };
#endregion

#region radrichtextbox-guidelines-for-printing-with-raddocument_3
private void AddContentToCell(TableCell cell)
{
    Paragraph paragraph1 = new Paragraph();
    Paragraph paragraph2 = new Paragraph();
    Span span1 = new Span("Some text in the first paragraph");
    paragraph1.Inlines.Add(span1);

    cell.Blocks.Add(paragraph1);
    cell.Blocks.Add(paragraph2);            
}
#endregion

#region radrichtextbox-guidelines-for-printing-with-raddocument_4
Paragraph paragraph = new Paragraph();
Span span = new Span("Text in the first paragraph");
paragraph.Inlines.Add(span);
Paragraph emptyParagraph = new Paragraph();

section.Blocks.Add(paragraph);
section.Blocks.Add(emptyParagraph);
#endregion

#region radrichtextbox-guidelines-for-printing-with-raddocument_5

#endregion

#region radrichtextbox-guidelines-for-printing-with-raddocument_6

#endregion

#region radrichtextbox-guidelines-for-printing-with-raddocument_7

#endregion

}
