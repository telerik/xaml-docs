---
title: Tables Dialogs
page_title: Tables Dialogs
description: Check our &quot;Tables Dialogs Changes&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-tables
tags: tables,dialogs,insert,modify,manage
published: True
position: 1
---

# Tables Dialogs

The RichTextBox component provides several dialogs to work create and modify [tables]({%slug radrichtextbox-features-document-elements-tables%}).

## Insert Table Dialog

This dialog allows you to create a table by defining its dimensions.

![An image showing the insert tables dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-tables-0.png)

The dialog can be opened from the __Insert Table__ option in the __Table__ drop down button located in the __Insert__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the insert tables dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-tables-1.png)

## Table Properties Dialog

This dialog allows you to adjust the table's [properties]({%slug radrichtextbox-features-api%}).

![An image showing the table properties dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-tables-2.png)

The dialog can be opened from the __Properties__ option in the __Layout__ contextual tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}) or via the in the __Table Properties__ option in the right-click menu (context menu) of `RadRichTextBox`.

![An image showing the button that opens the table properties dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-tables-3.png)

![An image showing the context menu option that opens the table properties dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-tables-4.png)

## Table Borders Dialog

This dialog allows you to adjust the table boders.

![An image showing the table borders dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-tables-5.png)

The dialog can be opened from the __Table Borders__ option in the right-click menu (context menu) of `RadRichTextBox`.

![An image showing the button that opens the table borders dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-tables-6.png)

## Table Styles Dialog

The table style dialogs allows you to create and modify the styling used in the tables of the document.

![An image showing the create table styles dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-tables-7.png)

![An image showing the modify  table styles dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-tables-8.png)

The table styles dialogs can be opened from the __New Table Style__ and __Modify Table Style__ buttons in the __Table Styles__ drop down of the __Design__ contextual tab of [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the table styles dialogs buttons of RadRichTextBoxUI for WPF](images/richtextbox-dialogs-tables-8.png)

## Showing the Dialogs Manually

The table dialogs can be shown by executing the following commands:

* `ShowTablePropertiesDialogCommand`
* `ShowTableBordersDialogCommand`
* `ShowInsertTableDialogCommand`

See how to bind the commands to external buttons in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region richtextbox-dialogs-tables-0}}
	this.richTextBox.Commands.ShowTablePropertiesDialogCommand.Execute(null);
{{endregion}}

Alternatively, you can call the associated `RadRichTextBox` methods.

* `ShowInsertTableDialog`
* `ShowTableBordersDialog`
* `ShowTablePropertiesDialog`

#### __[C#] Using the show dialog method__
{{region richtextbox-dialogs-tables-1}}
	this.richTextBox.ShowInsertTableDialog();
{{endregion}}
