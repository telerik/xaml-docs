---
title: Bookmark
page_title: Bookmark
description: Bookmark
slug: radwordsprocessing-model-bookmark
tags: bookmark
publish: True
position: 12
---

# Bookmark



A __Bookmark__ refers to a location in the document and has a unique name, which identifies it. Every __Bookmark__ has a corresponding __BookmarkRangeStart__ and __BookmarkRangeEnd__, which are inline elements. These two elements specify the Bookmark's location as follows:
      

* __BookmarkRangeStart__: Specifies the start of a bookmark annotation.
          

* __BookmarkRangeEnd__: Specifies the end of a bookmark annotation.
          

## Inserting a Bookmark

__Example 1__ shows how to create a __Bookmark__ and add its BookmarkRangeStart and BookmarkRangeEnd elements in a [Paragraph]({%slug radwordsprocessing-model-paragraph%}):
        

#### __[C#] Example 1: Add Bookmark to Paragraph__

{{region radwordsprocessing-model-bookmark_0}}
	            Bookmark bookmark = new Bookmark(document, "MyBookmark");
	            paragraph.Inlines.Add(bookmark.BookmarkRangeStart);
	            paragraph.Inlines.AddRun("text");
	            paragraph.Inlines.Add(bookmark.BookmarkRangeEnd);
	{{endregion}}



Note, that the paragraph should belong to the same document that is passed to the constructor of the __Bookmark__ object, otherwise an exception is thrown. The bookmark's location is specified around a run with text "text".
        

Inserting a __Bookmark__ in the document can also be done with through the [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}) class like shown in __Example 2__:
        

#### __[C#] Example 2: Insert Bookmark using RadFlowDocumentEditor__

{{region radwordsprocessing-model-bookmark_1}}
	            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());
	            Bookmark bookmark = editor.InsertBookmark("MyBookmark");
	{{endregion}}



The __InsertBookmark()__ method from __Example 2__ creates a Bookmark with name "MyBookmark" and inserts one after another its BookmarkRangeStart and BookmarkRangeEnd elements.
        

## Removing a Bookmark 

You can remove an inserted __Bookmark__ by using __RadFlowDocumentEditor__'s __DeleteBookmark()__ method. You can pass to the method the name of the Bookmark to remove, or the Bookmark itself.
        

__Example 3__ demonstrates how you can delete the bookmark created in __Example 2__.
        

#### __[C#] Example 2: Delete Bookmark using RadFlowDocumentEditor__

{{region radwordsprocessing-model-bookmark_2}}
	            editor.DeleteBookmark("MyBookmark");
	{{endregion}}



# See Also

 * [Paragraph]({%slug radwordsprocessing-model-paragraph%})

 * [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%})
