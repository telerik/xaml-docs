---
title: Section Columns
page_title: Section Columns
description: Check our &quot;Section Columns&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-ui-for-applying-rich-text-formatting-section-columns
tags: section, column
published: True
position: 1
---

# {{ site.framework_name }} RadRichTextBox Section Columns

With the Section Columns feature, **RadRichTextBox** allows you arrange the text in a [Section]({%slug radrichtextbox-features-document-elements-section%}) into columns. This article will show you how to use the predefined UI to arrange the text into columns with equal or different width.

* [Create Section Columns](#create-section-columns)

* [Changing the Width of a Section Column](#changing-the-width-of-a-section-column)


#### __Figure 1: Text laid out in columns__
![RadRichTextBox_Features_Section_Columns_01](images/RadRichTextBox_Features_Section_Columns_01.png)

## Create Section Columns

The Page Layout tab of [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}) allows you set different types of section columns.

#### __Figure 2: Section columns menu__
![RadRichTextBox_Features_Section_Columns_03](images/RadRichTextBox_Features_Section_Columns_03.png)

* **One**: Represents a single text column.

* **Two**: Represents two text columns with equal width.

* **Three**: Represents three text columns with equal width.

* **Left**: Represents two text columns where the left one has a smaller width than the right one.

* **Right**: Represents two text columns where the right one has a smaller width than the left one.

* **More Columns...**: Opens the Section Columns Dialog that allows you set columns with custom width and spacing. 

#### __Figure 3: Left option applied on a section__
![RadRichTextBox_Features_Section_Columns_02](images/RadRichTextBox_Features_Section_Columns_02.png)

## Changing the Width of a Section Column

When the Section contains columns with equal width, you can customize the width of a column through the Document Ruler. When the caret is positioned on a column, a thumb appears that allows you change the width by dragging it.

#### __Figure 3: Customizing the width of a column__
![RadRichTextBox_Features_Section_Columns_04](images/RadRichTextBox_Features_Section_Columns_04.png)

Another approach for applying different settings to section columns is through the Columns dialog.

#### __Figure 4: Customizing the width and spacing of columns using dialog__
![RadRichTextBox_Features_Section_Columns_04](images/RadRichTextBox_Features_Section_Columns_05.png)

## See Also

* [Section]({%slug radrichtextbox-features-document-elements-section%})
* [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})
* [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%})
