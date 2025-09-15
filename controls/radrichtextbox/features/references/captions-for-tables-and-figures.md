---
title: Captions for Tables and Figures
page_title: Captions for Tables and Figures
description: Check our &quot;Captions for Tables and Figures&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-captions-for-tables-and-figures
tags: captions,for,tables,and,figures
published: True
position: 3
---

# Captions for Tables and Figures



In __Telerik’s RadRichTextBox__ you can easily insert images, tables, etc. Now it is possible to label these by inserting __captions__. This will help you define an image or a table and then refer to it later.

## Insert Caption

You can open the __Caption__ window by clicking on the __Caption__ button.

![Rad Rich Text Box Features Captions For Tables And Figures 01](images/RadRichTextBox_Features_Captions_For_Tables_And_Figures_01.png)

If the caret is inside a table, the caret would look like this:

![Rad Rich Text Box Features Captions For Tables And Figures 02](images/RadRichTextBox_Features_Captions_For_Tables_And_Figures_02.png)

### Caption Preview

On the top there is a preview of the caption text that would be inserted. In this case we haven’t inserted any other captions with label “Table” so the number that follows is 1. That number represents the number of captions inserted before that one with the same label.

### Options

You can select different options. The first one is __Label__. From here you can select the label text. By default you have two options – __Figure__ and __Table__.

![Rad Rich Text Box Features Captions For Tables And Figures 03](images/RadRichTextBox_Features_Captions_For_Tables_And_Figures_03.png)

You can also specify the __Position__ of the caption - __Above selected item__ or __Below selected item__

We will have this option only if the caret is in a table or on an image. Otherwise it will be disabled.

### Creating and deleting labels

You can add new labels by using the __New Label…__ dialog and of course delete old ones with the __Delete Label__ button.

![Rad Rich Text Box Features Captions For Tables And Figures 04](images/RadRichTextBox_Features_Captions_For_Tables_And_Figures_04.png)

>You cannot delete the two default labels - __Figure__ and __Table__

When __Exclude label from caption__ checkbox is checked the label text will be removed and only the number will be left.

### Format

You can control how the numbering is displayed by using the __Format__ ComboBox. You can see the available formats in the picture below. By default the (“1, 2, 3, …”) format is selected.

![Rad Rich Text Box Features Captions For Tables And Figures 05](images/RadRichTextBox_Features_Captions_For_Tables_And_Figures_05.png)

### Include chapter number

When the __Include chapter number__ checkbox is checked, every time you insert a __Caption__ in a new section, the numbering is restarted. That’s why the preview now looks like this:

![Rad Rich Text Box Features Captions For Tables And Figures 06](images/RadRichTextBox_Features_Captions_For_Tables_And_Figures_06.png)

The first number shows the bullet of the section you are currently in, and the second number shows the number of __Captions__ being inserted in this section.

A section is defined by the __Heading__ styles, but only when they are in a list. You can choose which __Heading__ style the chapter starts from and what separator to use. There are several available separators – __hyphen__, __period__, __colon__.

![Rad Rich Text Box Features Captions For Tables And Figures 07](images/RadRichTextBox_Features_Captions_For_Tables_And_Figures_07.png)

### Insert

Clicking on the __OK__ button will insert the __Caption__.It would look like this:

![Rad Rich Text Box Features Captions For Tables And Figures 08](images/RadRichTextBox_Features_Captions_For_Tables_And_Figures_08.png)

Here the __Below selected item__ position is chosen, __:__ for separator and __A, B, C…__ for formatting.

## Inserting a Caption using RadRichTextBox's API

Using Telerik’s rich text editor’s API is pretty straight forward. There is a method called __InsertCaption()__ on __RadRichTextBox__ which you can use to insert a new __Caption__ into the document with a custom label. The method has the following signature:

#### __C#__

```C#
	public void InsertCaption(CaptionDefinition definition, string caption, bool includeLabel, bool insertBelow)
```



The __CaptionDefinition__ class contains viable information for the creation of the caption like __Label__, __NumberingFormat__ and __SeparatorType__. The “caption” parameter is of type string and represents the text in the caption that will be inserted after the number (also known as caption text). The “includeLabel” parameter is of type Boolean and if true will include the label text to the caption. The “insertBelow” parameter is of type Boolean as well and if true will insert the caption below the table or figure. So, in order to insert a caption using this method you would do something like: 

#### __C#__

```C#
	CaptionDefinition captionDefinition = new CaptionDefinition();
	captionDefinition.Label = "testLabel";
	captionDefinition.NumberingFormat = Documents.Model.Fields.NumberingFormat.Arabic;
	captionDefinition.SeparatorType = Documents.Model.Fields.CaptionSeparatorType.Colon;
	this.radRichTextBox1.InsertCaption(captionDefinition, "captionText", true, true);
```



The __RadDocument__ contains the two default __CaptionDefinitions__ by default. They reside in a collection called “CaptionDefinitions” which is of type Dictionary<string, CaptionDefinition>. If you want to insert a caption of a default type, you can do as follow: 

#### __C#__

```C#
	this.radRichTextBox1.InsertCaption(this.editor.Document.CaptionDefinitions["Table"], "captionText", true, true);
```


This code will insert a default caption with label __Table__.

