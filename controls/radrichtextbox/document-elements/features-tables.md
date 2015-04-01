---
title: Table
page_title: Table
description: Table
slug: radrichtextbox-features-document-elements-tables
tags: table
published: True
position: 6
---

# Table



The __RadRichTextBox__ is capable of displaying tables. To add a table to the document you can use one of the following approaches:
      

* [Programmatically via RadRichTextBox's API](#creating-a-table-programmatically-via-radrichtextbox-api)

* [Via the built-in UI](#creating-a-table-via-the-built-in-ui)

The same approaches can be adopted when formatting the table:

* [Runtime via RadRichTextBox's API](#formatting-a-table-at-runtime-via-radrichtextbox's-api)

* [Via the built-in UI](#formatting-a-table-via-the-built-in-ui)

## Creating a Table Programmatically via RadRichTextBox API

>tipTo learn more about the __Formatting API__ of the __RadRichTextBox__, read [this topic]({%slug radrichtextbox-features-formatting-api%}).


The __RadRichTextBox__ exposes a rich API, which allows you to use various methods to add, modify or delete elements form the __RadDocument__. The methods exposed by the API can be wired to a UI and get executed upon user interaction with this UI.
        

Here is an example done in the code-behind.

#### __C#__

{{region radrichtextbox-features-document-elements-tables_2}}
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
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-document-elements-tables_3}}
    Dim document As New RadDocument()
    Dim section As New Section()
    section.Blocks.Add(New Paragraph())

    Dim table As New Table()
    table.StyleName = RadDocumentDefaultStyles.DefaultTableGridStyleName

    Dim row1 As New TableRow()

    Dim cell1 As New TableCell()
    Dim p1 As New Paragraph()
    Dim s1 As New Span()
    s1.Text = "Cell 1"
    p1.Inlines.Add(s1)
    cell1.Blocks.Add(p1)
    row1.Cells.Add(cell1)

    Dim cell2 As New TableCell()
    Dim p2 As New Paragraph()
    Dim s2 As New Span()
    s2.Text = "Cell 2"
    p2.Inlines.Add(s2)
    cell2.Blocks.Add(p2)
    row1.Cells.Add(cell2)
    table.Rows.Add(row1)

    Dim row2 As New TableRow()

    Dim cell3 As New TableCell()
    cell3.ColumnSpan = 2
    Dim p3 As New Paragraph()
    Dim s3 As New Span()
    s3.Text = "Cell 3"
    p3.Inlines.Add(s3)
    cell3.Blocks.Add(p3)
    row2.Cells.Add(cell3)
    table.Rows.Add(row2)

    section.Blocks.Add(table)
    section.Blocks.Add(New Paragraph())
    document.Sections.Add(section)

    Me.radRichTextBox.Document = document
{{endregion}}



Here is a snapshot of the result.

![Rad Rich Text Box Features Layout Elements Tables 01](images/RadRichTextBox_Features_LayoutElements_Tables_01.png)

The __RadRichTextBox__ exposes the following methods that regard the creation or deletion of a table:
        

* __DeleteTable__ - deletes the currently selected table.
            

* __DeleteTableColumn__ - deletes the currently selected column.
            

* __DeleteTableRow__ - deletes the currently selected row.
            

* __InsertTable__ - inserts a table. Allows you to specify the number of rows and columns. Has an overload that allows you to specify if a Paragraph should be inserted before the table.
            
        
>important In versions earlier than Q1 2015 before and after each Table element is inserted a Paragraph. When the Table is inserted via the UI or the InsertTable() method this is done automatically, otherwise paragraphs should be inserted manually. In next versions the Paragraph before the Table is not mandatory.

* __InsertTableColumn__- inserts a column at the end.
            

* __InsertTableColumnToTheLeft__ - inserts a column to the left of the selected one.
            

* __InsertTableColumnToTheRight__ - inserts a column to the right of the selected one.
            

* __InsertTableRow__ - inserts a row at the end.
            

* __InsertTableRowAbove__ - inserts a row above the selected one.
            

* __InsertTableRowBelow__ - inserts a row below the selected one.
            

## Creating a Table via the Built-in UI

You can enable the user to create a table via the built-in UI of the __RadRichTextBox__. This is done by using the __RadRichTextBoxRibbonUI__, which exposes two different ways of creating a table by selection in the UI or on button click. To learn more about how to use the __RadRichTextBoxRibbonUI__ read [this topic]({%slug radrichtextbox-features-radrichtextboxribbonui%}).
        

![Rad Rich Text Box Features Layout Elements Tables 02](images/RadRichTextBox_Features_LayoutElements_Tables_02.png)

You can also use the __InsertTableDialog__, which comes out of the box. To show it upon a user action just call the __ShowInsertTableDialog()__ method of the __RadRichTextBox__. Here is a snapshot of it.
        

>The __RadRichTextBoxUI__ also uses this dialog.
          

![Rad Rich Text Box Features Layout Elements Tables 04](images/RadRichTextBox_Features_LayoutElements_Tables_04.png)

A table could be deleted or modified via the Table Tools’ contextual tab __Layout__. There are UI buttons for each of the API methods used for deleting and modifying a table.
        

![Rad Rich Text Box Features Layout Elements Tables 03](images/RadRichTextBox_Features_LayoutElements_Tables_03.png)

## Formatting a Table at Runtime via RadRichTextBox's API

>tipTo learn more about the __Formatting API__ of the __RadRichTextBox__, read [this topic]({%slug radrichtextbox-features-formatting-api%}).
        

The __RadRichTextBox__ exposes a rich API, which allows you to use various methods to add, modify or delete elements form the __RadDocument__. The methods exposed by the API can be wired to a UI and get executed upon user interaction with this UI. The __RadRichTextBox__ exposes the following methods that regard the modifying of a table:
        

* __ChangeTableBorders__ - modifies the borders of the currently selected table via a __TableBorders__ object.
            

* __ChangeTableCellBackground__ - sets the color of the currently selected cell's borders.
            

* __ChangeTableCellBorders__ - modifies the borders of the currently selected table via a __TableCellBorders__ object.
            

* __ChangeTableCellContentAlignment__ - modifies the content alignment of the currently selected cell.
            

* __ChangeTableCellPadding__ - modifies the padding of the currently selected cell.
            

* __ChangeTableColumnsLayoutMode__ - modifies the layout mode of the table's columns.
            

* __ChangeTableGridColumnWidth__ - modifies the width of the column.
            

* __MergeTableCells__ - merges the currently selected cells.
            

## Formatting a Table via the Built-in UI

You can enable the user to modify a table via the built-in UI of the __RadRichTextBox__. This is done by using the __RadRichTextBoxRibbonUI__, which exposes a __Table Tools__ contextual menu with two tabs – __Design__ and __Layout__. They expose UI buttons for all API methods used for formatting and modifying a table. To learn more about how to use the __RadRichTextBoxRibbonUI__ read [this topic]({%slug radrichtextbox-features-radrichtextboxribbonui%}).
        

![Rad Rich Text Box Features Layout Elements Tables 05](images/RadRichTextBox_Features_LayoutElements_Tables_05.png)

The __Design__ contextual tab allows you to use a predefined set of formatting options called Table styles. The __TableStylesGallery__ offers a way to easily create, delete, modify and apply table styles in a document. To learn more about how to use the TableStylesGallery read [this topic]({%slug radrichtextbox-ui-for-applying-formatting-table-styles-gallery%}).
        

![Rad Rich Text Box Features Layout Elements Tables 07](images/RadRichTextBox_Features_LayoutElements_Tables_07.png)

Additionally the built-in context menu of the __RadRichTextBox__ gives the user the possibility to open the __Table Properties__ and __Table Borders__ dialogs.
        

![Rad Rich Text Box Features Layout Elements Tables 06](images/RadRichTextBox_Features_LayoutElements_Tables_06.png)

>tipTo wire these dialogs to your own UI you can use the __ShowTablePropertiesDialog()__ method of __RadRichTextBox__ or the __ShowTablePropertiesCommand__.
        

# See Also

* [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})

* [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})

* [Section]({%slug radrichtextbox-features-document-elements-section%})