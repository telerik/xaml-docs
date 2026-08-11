---
title: Text Position
page_title: Text Position
description: Check our &quot;Text Position&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-text-text-position
tags: text,position
published: True
position: 4
---

# Text Position

__TextPosition__ is a position in the text of a __RadFixedDocument__. They enable keeping track of a "current" position in the document (i.e. a caret) and lay the foundations of document selection.

## Creation

One can create a __TextPostion__ for a particular document, page and index using one of the constructors:

<snippet id='radpdfviewer-document-model-text-position-block_1-cs' />

The constructors that accept a __RadFixedPage__ as parameter create a TextPosition for the particular page.

The __offset__ you specify will be the offset in the current page in terms of number of characters.

If you pass only the __RadFixedDocument__ instance, a TextPosition for the first page will be created.

In case you want to make a copy of a __TextPosition__, you can opt for the constructor listed last.

## Members

The members that the __TextPosition__ class exposes are:

* Properties:
    * __Index__ - the integer offset of the text position into the page.
    * __Page__ - the RadFixedPage that the position belongs to.
* Methods:
    * __TextPosition__ overrides the equality operator, so that you can compare positions in the document depending on their position using <, > and =.
    * The other methods of the class provide the means for navigation in the document and have self-explanatory names and arguments:

	<snippet id='radpdfviewer-document-model-text-position-block_2-cs' />

* Events:
    * __PositionChanging__ - occurs just before the position is moved;
    * __PositionChanged__ - occurs after the position has moved.

The caret position of __RadFixedDocument__ is also a __TextPosition__ and all methods and properties listed above could be used with it as well. 

<snippet id='radpdfviewer-document-model-text-position-block_3-cs' />

This will not only move the caret to the end of the document, but will also [scroll]({%slug radpdfviewer-scrolling%}) the document to bring it into view, as the view port follows the caret.

## See Also

 * [RadFixedDocument]({%slug radpdfviewer-document-model-radfixeddocument%})
 * [Text Selection]({%slug radpdfviewer-text-text-selection%})