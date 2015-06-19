---
title: TabStop
page_title: TabStop
description: TabStop
slug: radwordsprocessing-concepts-tabstop
tags: tab, stop
published: True
position: 3
---

# TabStop

A tab stop is a term used to describe the location the caret stops after tab key is pressed. Tab stops are used in words processing to enable users to align text by inserting the Tab symbol. Each paragraph contains a number of tabs, which could be placed wherever you want. 

## TabStop Overview

The __TabStop__ class is immutable, meaning you should set its properties when initializing an instance.

* __Position__: The position of the tab stop.

* __Type__: The type of the tab stop, defines the behavior of the tab stop. All possibilities are described with the [TabStopType enumeration](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Flow_Model_Styles_TabStopType.htm):

	* __Left__: The text following the tab stop will be left aligned with respect to the tab stop position. This is the *default* value.
	* __Center__: The text following the tab stop will be centered around the tab stop position. 
	* __Right__: The text following the tab stop will be right aligned with respect to the tab stop position. 
	* __Decimal__: Text before the decimal point will be positioned to the left and text after the decimal point will be positioned to the right side of the tab stop.
	* __Bar__: A vertical bar is shown on the tab position.
	* __Clear__: Clears an inherited tab stop.

* __Leader__: Specifies the character which shall be used to fill the space in front of a tab. All possibilities are described with the [TabStopLeader enumeration](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Flow_Model_Styles_TabStopLeader.htm):

	* __None__: The space before the tab will be left empty. This is the default value.
	* __Dot__: The space before the tab will be filled with dots.
	* __Hyphen__: The space before the tab will be filled with hyphens.
	* __Underscore__: The space before the tab will be filled with underscores.
	* __MiddleDot__: The space before the tab will be filled with middle dots.

The distance between automatic tab stops is determined by the __[RadFlowDocument]({%slug radwordsprocessing-model-radflowdocument%}).DefaultTabStopWidth__ property. Automatic tab stops refer to the tab stop location which occur after all custom tab stops in the current paragraph have been surpassed.

## TabStopCollection Overview

This class derives from __System.Collections.Generic.IEnumerable<T>__ and represents a collection of __TabStop__ objects. The collection is immutable and it is used to hold the tab stops in a [Paragraph]({%slug radwordsprocessing-model-paragraph%}).

The __TabStopCollection__ class exposes the following members:

* __Count__: The count of __TabStop__ elements in the collection.
* __Insert()__: This method will return new instance of __TabStopCollection__ with the specified tab stop inserted in it.
* __Remove()__: This method will return new instance of __TabStopCollection__ with the specified tab stop removed.

## Working with TabStopCollection

### Create a TabStopCollection

Excluding the default constructor, the __TabStopCollection__ class exposes an overload allowing you to directly pass a collection of __TabStop__ objects:

<a name="example1"><a/>
#### __[C#] Example 1: Create a TabStopCollection__

{{region radwordsprocessing-concepts-tabstops_0}}
	List<TabStop> tabStops = new List<TabStop>();
	tabStops.Add(new TabStop(Unit.InchToDip(1), TabStopType.Left));
	tabStops.Add(new TabStop(Unit.InchToDip(2), TabStopType.Center, TabStopLeader.Dot));
	tabStops.Add(new TabStop(Unit.InchToDip(3), TabStopType.Right, TabStopLeader.Hyphen));
	tabStops.Add(new TabStop(Unit.InchToDip(5.5), TabStopType.Bar));
	
	TabStopCollection collection = new TabStopCollection(tabStops);
{{endregion}}

### Insert Item in a TabStopCollection

In __Example 2__ is illustrated how to insert items in the __TabStopCollection__ created in [Example 1](#example1). Keep in mind that due to the fact that this collection is immutable, the __Insert()__ method will return a new instance of the class.

#### __[C#] Example 2: Insert Item in a TabStopCollection__
{{region radwordsprocessing-concepts-tabstops_1}}
	TabStopCollection collection = collection.Insert(new TabStop(Unit.InchToDip(4)))
                                             .Insert(new TabStop(Unit.InchToDip(5.5), TabStopType.Right));
{{endregion}}


### Remove Item from a TabStopCollection

The snippet below shows how to remove an item from the __TabStopCollection__ created in [Example 1](#example1). Keep in mind that due to the fact that this collection is immutable, the Remove() method will return new instance of the class.

#### __[C#] Example 3: Remove item from a TabStopCollection__
{{region radwordsprocessing-concepts-tabstops_2}}
	TabStop tabStopToRemove = collection.First();
	collection = collection.Remove(tabStopToRemove);
{{endregion}}


## Working with TabStop

In __RadWordsProcessing__ the tab stops are stored as a collection in the [Paragraph]({%slug radwordsprocessing-model-paragraph%}). This section will show you how to work with the __TabStop__ element.


### Create a TabStop

The code from __Example 4__ demonstrates how to create a tab stop:

<a name="example4"><a/>
#### __[C#] Example 4: Create a TabStop__

{{region radwordsprocessing-concepts-tabstops_3}}
	abStop tabStop = new TabStop(Unit.InchToDip(2), TabStopType.Center);
{{endregion}}

### Adding a TabStop

__Example 5__ shows how to add the tab stop created in [Example 1](#example1) to an existing __Paragraph__ through the _TabStops_ property of type __TabStopCollection__:

#### __[C#] Example 5: Insert a TabStop__

{{region radwordsprocessing-concepts-tabstops_4}}
	paragraph.TabStops = paragraph.TabStops.Insert(tabStop);
{{endregion}}

### Remove a TabStop

The following code-snippet illustrates how to remove the created in [Example 4](#example4) TabStop:

#### __[C#] Example 5: Remove a TabStop__

{{region radwordsprocessing-concepts-tabstops_5}}
	paragraph.TabStops = paragraph.TabStops.Insert(tabStop);
{{endregion}}

# See Also

* [Paragraph]({%slug radwordsprocessing-model-paragraph%})