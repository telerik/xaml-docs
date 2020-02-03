---
title: Working with Tables
page_title: Working with Tables
description: Working with Tables
slug: radrichtextbox-working-with-tables
tags: table
published: True
position: 2
---

# Row and Column Span

In order to merge cells in the table you can use the __RowSpan__ and __ColumnSpan__ properties of the __TableCell__. The below code shows how you can use these properties to create a complex table header.

#### Use RowSpan and ColumnSpan Properties

#### __C#__

{{region radrichtextbox-document-elements-working-with-tables_0}}   
    Table table = new Table();
    table.StyleName = RadDocumentDefaultStyles.DefaultTableGridStyleName;

    //add header
    TableRow headerRow1 = new TableRow();

    TableCell cell = CreateCellWithText("Customer Contanct");
    cell.ColumnSpan = 3;
    cell.RowSpan = 2;
    headerRow1.Cells.Add(cell);

    cell = CreateCellWithText("Details");
    cell.ColumnSpan = 5;
    headerRow1.Cells.Add(cell);

    TableRow headerRow2 = new TableRow();

    cell = CreateCellWithText("Address");
    cell.ColumnSpan = 3;
    headerRow2.Cells.Add(cell);


    cell = CreateCellWithText("Contact");
    cell.ColumnSpan = 2;
    headerRow2.Cells.Add(cell);

    TableRow headerRow3 = new TableRow();

    cell = CreateCellWithText("Comapny Name");
    headerRow3.Cells.Add(cell);

    cell = CreateCellWithText("Contanct Name");
    headerRow3.Cells.Add(cell);

    cell = CreateCellWithText("Contanct Title");
    headerRow3.Cells.Add(cell);

    cell = CreateCellWithText("Address");
    headerRow3.Cells.Add(cell);

    cell = CreateCellWithText("City");
    headerRow3.Cells.Add(cell);

    cell = CreateCellWithText("Country");
    headerRow3.Cells.Add(cell);

    cell = CreateCellWithText("Phone");
    headerRow3.Cells.Add(cell);

    cell = CreateCellWithText("Fax");
    headerRow3.Cells.Add(cell);

    table.Rows.Add(headerRow1);
    table.Rows.Add(headerRow2);
    table.Rows.Add(headerRow3);

    //add data rows
    for (int i = 0; i < 3; i++)
    {
        TableRow row = new TableRow();
        for (int j = 0; j < 8; j++)
        {
            row.Cells.Add(new TableCell());

        }
        table.Rows.Add(row);
    }

    radRichTextBox.InsertTable(table);

{{endregion}}

The result is demonstrated in the following image.

> caption Merging cells with RowsSpan and ColSpan properties

![radrichtextbox-document-elements-working-with-tables001](images/radrichtextbox-document-elements-working-with-tables001.png) 

# Iterate Table

In order to iterate a table you need to get it firs. You can use the EnumerateChildrenOfType method to get all tables in the document.

#### Get All Tables from the Document

#### __C#__

{{region radrichtextbox-document-elements-working-with-tables_1}}   

   var tables = radRichTextBox.Document.EnumerateChildrenOfType<Table>();
   
{{endregion}}


Now that you have the table you can iterate the rows and columns by using the following approach. 

#### Iterate all Rows and Columns

#### __C#__

{{region radrichtextbox-document-elements-working-with-tables_2}}   

    var table = radRichTextBox.Document.EnumerateChildrenOfType<Table>().FirstOrDefault();
    if (table != null)
    {
        foreach (TableRow row in table.Rows)
        {
            foreach (TableCell cell in row.Cells)
            {
                var content = cell.EnumerateChildrenOfType<Span>().FirstOrDefault();
                if (content != null)
                {
                    Console.WriteLine(content.Text);
                }

            }
        }
    }

{{endregion}}

# Set Border Styles

# Set Other Styles

# Model Properties