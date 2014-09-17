---
title: List Styles
page_title: List Styles
description: List Styles
slug: radrichtextbox-features-list-styles
tags: list,styles
published: True
position: 1
---

# List Styles



__RadRichTextBox__ has support for bulleted, numbered and multilevel lists. In addition, you have 
      the ability to create custom list styles and add them to the list styles gallery.

## User Interface

You can specify whether you wish to use bulleted, numbered or some kind of multilevel list from the predefined UI 
        of __RadRichTextBox__:![Rad Rich Text Box Features List Styles 01](images/RadRichTextBox_Features_List_Styles_01.png)

When using a multilevel list, you can easily change the level using the default key-bindings (Tab for increasing 
      	the indent and Shift + Tab for decreasing it).

Through the user interface, you can also create a multilevel list using the *Define New List Style* 
      	dialog. Your new style can have up to 9 levels, each of which can be customized. You can choose the font, font size, font 
      	weight, color and symbol to be used as the current level's mark. In addition, using the advanced settings you can 
      	create a level which includes in itself the symbol from another level.![Rad Rich Text Box Features List Styles 02](images/RadRichTextBox_Features_List_Styles_02.png)

After defining your new style, it is added to the list gallery and can easily be accessed and used throughout the 
      	document.![Rad Rich Text Box Features List Styles 03](images/RadRichTextBox_Features_List_Styles_03.png)

## Creating Lists Programmatically

The default list styles come handy, as they require little to no effort on your part, but you can create your own 
    	using the API. The functionality you need to use is located in the __DocumentList__, __ListStyle__ and __ListLevelStyle__ classes. Here are the steps you need to follow in order to create 
    	a new list:

1. Create a new instance of __ListStyle__. You can see that the __ListStyle__ 
    		class has a static readonly field __ListLevels__ that keeps the number of levels that the default lists 
    		can have (9). It is recommended that you allow your lists to have that many levels for uniformity and for prettier conversion 
    		between list types.

1. Define a __ListLevelStyle__ for each level depending on the way you wish your bullet or number 
    		to appear, and add it to the __Levels__ property. The customization options are presented by several 
    		properties. In the example below, these are specified:
	    		

* __StartingIndex__ – should the list start at 0 or 1 for example;

* __NumberingFormat__ – the numbering format that you wish to use. The available 
	    			numbering formats are defined as an enum called __ListNumberingFormat__. The options provided 
	    			are: *Bullet*, *Decimal*, *UpperLetter*, 
	    			*LowerLetter*, *UpperRoman* and *LowerRoman*.

* __LevelText__ - the string format that you would like the numbers/bullets to appear in at 
	    			each level. Using this property, you can set if you wish the list item to contain the numbers of its predecessors (like 
	    			in the NumberedHierarchical list style) or not (like in the other predefined list styles)

* __Indent__ – affects the indent of each level.

1. Create a __DocumentList__ and in the constructor pass the appropriate __ListStyle__ 
    		object. The __DocumentList__ is the object that knows how the list should look (this is specified by the 
    		__ListStyle__ which we pass through the constructor) and which paragraphs are part of it. You add a paragraph 
    		to a __DocumentList__ by setting paragraph’s __ListId__ property to the ID of the __DocumentList__.

Here as an example of creating a __ListStyle__ and a __DocumentList__ programmatically:

#### __C#__

{{region radrichtextbox-features-list-styles_0}}
	ListStyle upperRomanHierarchical = new ListStyle();
	upperRomanHierarchical.StyleLink = "Style1";
	
	for (int i = 0; i < ListStyle.ListLevels; ++i)
	{
		StringBuilder levelText = new StringBuilder();
		for (int j = 0; j < i + 1; ++j)
		{
			levelText.Append("{" + j + "}.");
		}
	
		upperRomanHierarchical.Levels.Add(new ListLevelStyle()
		{
			StartingIndex = 1,
			NumberingFormat = ListNumberingFormat.UpperRoman,
			LevelText = levelText.ToString(),
			Indent = 48 + i * 24
		});
	}
	{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-list-styles_1}}
	    Dim upperRomanHierarchical As New ListStyle()
				upperRomanHierarchical.StyleLink = "Style1"
	
				For i As Integer = 0 To ListStyle.ListLevels - 1
	    Dim levelText As New StringBuilder()
					For j As Integer = 0 To i
						levelText.Append("{" & j & "}.")
					Next j
	
					upperRomanHierarchical.Levels.Add(New ListLevelStyle() With {.StartingIndex = 1, .NumberingFormat = ListNumberingFormat.UpperRoman, .LevelText = levelText.ToString(), .Indent = 48 + i * 24})
				Next i
	{{endregion}}



## Applying List Style Programmatically

After creating a __ListStyle__ you need to add it to the document. Besides using the UI you can do that 
    	   	through code the method of RadDocument __AddCustomListStyle(ListStyle	listStyle)__. You just pass the style 
    	   	you created and it gets added to the document. It will also be visible in the List Styles gallery.

If you want to apply a style to a paragraph using the user interface you would move the caret to the paragraph and click 
    		the appropriate ListStyle in the gallery. In code behind things are similar. First you need a reference to the paragraph you 
    		want to be added to a list. Let's say you need the current paragraph (in which the caret position resides). The code 
    		is as follows:

#### __C#__

{{region radrichtextbox-features-list-styles_2}}
	Paragraph paragraph = this.radRichTextBox.Document.CaretPosition.GetCurrentParagraphBox().AssociatedParagraph;
	{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-list-styles_3}}
	    Dim paragraph As Paragraph = Me.radRichTextBox.Document.CaretPosition.GetCurrentParagraphBox().AssociatedParagraph
	{{endregion}}



All you have to do now is set the __ListId__ property of the paragraph. However this id should be 
	    	the ID of a __DocumentList__ that uses the new __ListStyle__. This document list 
	    	is created automatically when using the user interface, but in code you have to create it on your own.

As the logic of creating a custom list style is rather complex, the method __AddCustomListStyle__ 
	    	does that and returns an instance of ListStyle which is different from the one you passed. When creating the new document 
	    	list you need to pass the list style returned from this method. So creating a document list look like this:

#### __C#__

{{region radrichtextbox-features-list-styles_4}}
	ListStyle newListStyle = this.radRichTextBox.Document.AddCustomListStyle(upperRomanHierarchical);
	DocumentList documentList = new DocumentList(newListStyle, this.radRichTextBox.Document);
	{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-list-styles_5}}
	    Dim newListStyle As ListStyle = Me.radRichTextBox.Document.AddCustomListStyle(upperRomanHierarchical)
	    Dim documentList As New DocumentList(newListStyle, Me.radRichTextBox.Document)
	{{endregion}}



Having the new __DocumentList__ all you have to do in order the paragraph to be added to the list 
	    	is to set it's __ListId__ property to the ID of the new __DocumentList__:

#### __C#__

{{region radrichtextbox-features-list-styles_6}}
	paragraph.ListId = documentList.ID;
	{{endregion}}



# See Also
